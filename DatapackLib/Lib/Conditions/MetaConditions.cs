namespace DatapackLib.Lib.Conditions;

public class MetaConditionTypes
{
    public class EntityAnd : EntityCondition
    {
        public override string? Type => "origins:and";
        
        [RequiredParameter("conditions")] public EntityCondition[]? Conditions;
    }
    
    public class EntityOr : EntityCondition
    {
        public override string? Type => "origins:or";
        
        [RequiredParameter("conditions")] public EntityCondition[]? Conditions;
    }
    
    public class BiomeAnd : BiomeCondition
    {
        public override string? Type => "origins:and";
        
        [RequiredParameter("conditions")] public BiomeCondition[]? Conditions;
    }
    
    public class BiomeOr : BiomeCondition
    {
        public override string? Type => "origins:or";
        
        [RequiredParameter("conditions")] public BiomeCondition[]? Conditions;
    }
    
    public class BlockAnd : BlockCondition
    {
        public override string? Type => "origins:and";
        
        [RequiredParameter("conditions")] public BlockCondition[]? Conditions;
    }
    
    public class BlockOr : BlockCondition
    {
        public override string? Type => "origins:or";
        
        [RequiredParameter("conditions")] public BlockCondition[]? Conditions;
    }
    
    public class FluidAnd : FluidCondition
    {
        public override string? Type => "origins:and";
        
        [RequiredParameter("conditions")] public FluidCondition[]? Conditions;
    }
    
    public class FluidOr : FluidCondition
    {
        public override string? Type => "origins:or";
        
        [RequiredParameter("conditions")] public FluidCondition[]? Conditions;
    }
}

public static class MetaConditions
{
    public static T And<T>(params Condition[] conditions) where T : Condition, new()
    {
        Type type = typeof(T);
        if (type == typeof(EntityCondition))
        {
            return (T)(object)new MetaConditionTypes.EntityAnd { Conditions = conditions.Cast<EntityCondition>().ToArray() };
        }

        if (type == typeof(BiomeCondition))
        {
            return (T)(object)new MetaConditionTypes.BiomeAnd { Conditions = conditions.Cast<BiomeCondition>().ToArray() };
        }

        if (type == typeof(BlockCondition))
        {
            return (T)(object)new MetaConditionTypes.BlockAnd { Conditions = conditions.Cast<BlockCondition>().ToArray() };
        }

        if (type == typeof(FluidCondition))
        {
            return (T)(object)new MetaConditionTypes.FluidAnd { Conditions = conditions.Cast<FluidCondition>().ToArray() };
        }

        throw new Exception($"Type {type.Name} is not a valid meta condition type.");
    }
    
    public static T Or<T>(params Condition[] conditions) where T : Condition, new()
    {
        Type type = typeof(T);
        if (type == typeof(EntityCondition))
        {
            return (T)(object)new MetaConditionTypes.EntityOr { Conditions = conditions.Cast<EntityCondition>().ToArray() };
        }
        
        if (type == typeof(BiomeCondition))
        {
            return (T)(object)new MetaConditionTypes.BiomeOr { Conditions = conditions.Cast<BiomeCondition>().ToArray() };
        }
        
        if (type == typeof(BlockCondition))
        {
            return (T)(object)new MetaConditionTypes.BlockOr { Conditions = conditions.Cast<BlockCondition>().ToArray() };
        }
        
        if (type == typeof(FluidCondition))
        {
            return (T)(object)new MetaConditionTypes.FluidOr { Conditions = conditions.Cast<FluidCondition>().ToArray() };
        }

        throw new Exception($"Type {type.Name} is not a valid meta condition type.");
    }
    
    public static T Not<T>(T condition) where T : Condition
    {
        condition.Inverted = true;
        return condition;
    }
}