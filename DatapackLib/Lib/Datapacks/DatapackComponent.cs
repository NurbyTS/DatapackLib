using System.Reflection;

namespace DatapackLib.Lib.Datapacks;

public class DatapackComponent
{
    public virtual void ManualFields(Dictionary<string, object> fields) { }
    
    public virtual void Init() { }
    
    private object HandleProperty(PropertyInfo info)
    {
        if (info.PropertyType.IsArray)
        {
            if (info.PropertyType.GetElementType() == typeof(DatapackComponent) || info.PropertyType.GetElementType()!.IsSubclassOf(typeof(DatapackComponent)))
            {
                var array = (DatapackComponent[]) info.GetValue(this)!;
                var datapackArray = new object[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    datapackArray[i] = array[i].ToDatapack();
                }
                return datapackArray;
            }
            else if (info.PropertyType.GetElementType() == typeof(ManualComponent) || info.PropertyType.GetElementType()!.IsSubclassOf(typeof(ManualComponent)))
            {
                var array = (ManualComponent[]) info.GetValue(this)!;
                var datapackArray = new object[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    datapackArray[i] = array[i].ToDatapack();
                }
                return datapackArray;
            }
        }
        
        if (info.PropertyType == typeof(DatapackComponent) || info.PropertyType.IsSubclassOf(typeof(DatapackComponent)))
        {
            return ((DatapackComponent) info.GetValue(this)!).ToDatapack();
        }
        
        if (info.PropertyType == typeof(ManualComponent) || info.PropertyType.IsSubclassOf(typeof(ManualComponent)))
        {
            return ((ManualComponent) info.GetValue(this)!).ToDatapack();
        }
        
        return info.GetValue(this)!;
    }
    
    private object HandleField(FieldInfo info)
    {
        if (info.FieldType.IsArray)
        {
            if (info.FieldType.GetElementType() == typeof(DatapackComponent) || info.FieldType.GetElementType()!.IsSubclassOf(typeof(DatapackComponent)))
            {
                var array = (DatapackComponent[]) info.GetValue(this)!;
                var datapackArray = new object[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    datapackArray[i] = array[i].ToDatapack();
                }
                return datapackArray;
            }
            else if (info.FieldType.GetElementType() == typeof(ManualComponent) || info.FieldType.GetElementType()!.IsSubclassOf(typeof(ManualComponent)))
            {
                var array = (ManualComponent[]) info.GetValue(this)!;
                var datapackArray = new object[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    datapackArray[i] = array[i].ToDatapack();
                }
                return datapackArray;
            }
        }
        
        if (info.FieldType == typeof(DatapackComponent) || info.FieldType.IsSubclassOf(typeof(DatapackComponent)))
        {
            return ((DatapackComponent) info.GetValue(this)!).ToDatapack();
        }
        else if (info.FieldType == typeof(ManualComponent) || info.FieldType.IsSubclassOf(typeof(ManualComponent)))
        {
            return ((ManualComponent) info.GetValue(this)!).ToDatapack();
        }
        
        return info.GetValue(this)!;
    }
    
    public object ToDatapack()
    {
        Type type = GetType();
        var builtJson = new Dictionary<string, object>();
        Init();
        ManualFields(builtJson);
        
        var properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy);
        foreach (var property in properties)
        {
            if (property.GetCustomAttribute<RequiredParameter>() != null)
            {
                if (property.GetValue(this) == null)
                {
                    throw new Exception($"Property {property.Name} is required but not set.");
                }

                builtJson[property.GetCustomAttribute<RequiredParameter>()!.Name] = HandleProperty(property);
            }
            else if (property.GetCustomAttribute<OptionalParameter>() != null)
            {
                if (property.GetValue(this) != property.GetCustomAttribute<OptionalParameter>()!.DefaultValue && property.GetValue(this) != null)
                {
                    builtJson[property.GetCustomAttribute<OptionalParameter>()!.Name] = HandleProperty(property);
                }
            }
        }
        
        var fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy);
        foreach (var field in fields)
        {
            if (field.GetCustomAttribute<RequiredParameter>() != null)
            {
                string name = field.GetCustomAttribute<RequiredParameter>()!.Name;
                if (field.GetValue(this) == null)
                {
                    throw new Exception($"Field {field.Name} is required but not set.");
                }

                builtJson[name] = HandleField(field);
            }
            else if (field.GetCustomAttribute<OptionalParameter>() != null)
            {
                string name = field.GetCustomAttribute<OptionalParameter>()!.Name;
                if (field.GetValue(this) != field.GetCustomAttribute<OptionalParameter>()!.DefaultValue &&
                    field.GetValue(this) != null)
                {
                    builtJson[name] = HandleField(field);
                }
            }
        }
        
        return builtJson;
    }
}