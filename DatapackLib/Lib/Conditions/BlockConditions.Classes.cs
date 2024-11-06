using DatapackLib.Lib.Datapacks;
using DatapackLib.Lib.Other;

namespace DatapackLib.Lib.Conditions;

public class BlockCondition : Condition;

public class BlockConditionTypes
{
    public class Adjacent : BlockCondition
    {
        public override string? Type => "origins:adjacent";
        
        [RequiredParameter("compare_to")] public float? CompareTo;
        [RequiredParameter("comparison")] public Comparison? Comparison;
        [RequiredParameter("adjacent_condition")] public BlockCondition? Condition;
    }
    
    public class Attachable : BlockCondition
    {
        public override string? Type => "origins:attachable";
    }
    
    public class BlastResistance : BlockCondition
    {
        public override string? Type => "origins:blast_resistance";
        
        [RequiredParameter("compare_to")] public float? CompareTo;
        [RequiredParameter("comparison")] public Comparison? Comparison;
    }
    
    public class BlockEntity : BlockCondition
    {
        public override string? Type => "origins:block_entity";
    }
    
    public class BlockState : BlockCondition
    {
        public override string? Type => "origins:block_state";
        
        [RequiredParameter("property")] public string? Property;
        
        [OptionalParameter("comparison", null)] public Comparison? Comparison;
        [OptionalParameter("compare_to", null)] public float? CompareTo;
        [OptionalParameter("value", null)] public bool? Value;
        [OptionalParameter("enum", null)] public string? Enum;
    }
    
    public class BlockType : BlockCondition
    {
        public override string? Type => "origins:block";
        
        [RequiredParameter("block")] public string? BlockId;
    }

    public class Command : BlockCondition
    {
        public override string? Type => "origins:command";
        
        [RequiredParameter("command")] public string? RanCommand;
        [RequiredParameter("comparison")] public Comparison? Comparison;
        [RequiredParameter("compare_to")] public int? CompareTo;
    }
    
    public class ExposedToSky : BlockCondition
    {
        public override string? Type => "origins:exposed_to_sky";
    }
    
    public class Fluid : BlockCondition
    {
        public override string? Type => "origins:fluid";
        
        [RequiredParameter("fluid_condition")] public FluidCondition? FluidCondition;
    }
    
    public class Hardness : BlockCondition
    {
        public override string? Type => "origins:hardness";
        
        [RequiredParameter("compare_to")] public float? CompareTo;
        [RequiredParameter("comparison")] public Comparison? Comparison;
    }
    
    public class Height : BlockCondition
    {
        public override string? Type => "origins:height";
        
        [RequiredParameter("compare_to")] public float? CompareTo;
        [RequiredParameter("comparison")] public Comparison? Comparison;
    }
    
    public class InTag : BlockCondition
    {
        public override string? Type => "origins:in_tag";
        
        [RequiredParameter("tag")] public string? Tag;
    }
    
    public class LightBlocking : BlockCondition
    {
        public override string? Type => "origins:light_blocking";
    }
    
    public class LightLevel : BlockCondition
    {
        public override string? Type => "origins:light_level";
        
        [RequiredParameter("compare_to")] public float? CompareTo;
        [RequiredParameter("comparison")] public Comparison? Comparison;
        
        [OptionalParameter("light_type", null)] public string? LightType;
    }
    
    public class MovementBlocking : BlockCondition
    {
        public override string? Type => "origins:movement_blocking";
    }
    
    public class NBT : BlockCondition
    {
        public override string? Type => "origins:nbt";
        
        [RequiredParameter("nbt")] public string? Nbt;
    }
    
    public class Replaceable : BlockCondition
    {
        public override string? Type => "origins:replaceable";
    }
    
    public class Slipperiness : BlockCondition
    {
        public override string? Type => "origins:slipperiness";
        
        [RequiredParameter("compare_to")] public float? CompareTo;
        [RequiredParameter("comparison")] public Comparison? Comparison;
    }
    
    public class WaterLoggable : BlockCondition
    {
        public override string? Type => "origins:water_loggable";
    }
}