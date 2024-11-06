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