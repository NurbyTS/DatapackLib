using Newtonsoft.Json.Serialization;

namespace DatapackLib.Lib;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public class OptionalParameter(string name, object? defaultValue) : Attribute
{
    public object? DefaultValue { get; } = defaultValue;
    public string Name { get; } = name;
}

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public class RequiredParameter(string name) : Attribute
{
    public string Name { get; } = name;
}