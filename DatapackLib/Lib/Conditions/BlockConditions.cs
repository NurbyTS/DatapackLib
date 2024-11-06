using DatapackLib.Lib.Other;

namespace DatapackLib.Lib.Conditions;

public static class BlockConditions
{
    public static BlockConditionTypes.Adjacent Adjacent(float compareTo, Comparison comparison, BlockCondition condition)
    {
        return new BlockConditionTypes.Adjacent
        {
            CompareTo = compareTo,
            Comparison = comparison,
            Condition = condition
        };
    }
    
    public static BlockConditionTypes.Attachable Attachable() => new();
    
    public static BlockConditionTypes.BlastResistance BlastResistance(float compareTo, Comparison comparison)
    {
        return new BlockConditionTypes.BlastResistance
        {
            CompareTo = compareTo,
            Comparison = comparison
        };
    }
    
    public static BlockConditionTypes.BlockEntity BlockEntity() => new();
    
    public static BlockConditionTypes.BlockState BlockState(string property, Comparison? comparison = null, float? compareTo = null, bool? value = null, string? @enum = null)
    {
        return new BlockConditionTypes.BlockState
        {
            Property = property,
            Comparison = comparison,
            CompareTo = compareTo,
            Value = value,
            Enum = @enum
        };
    }
    
    public static BlockConditionTypes.BlockType BlockType(string blockId)
    {
        return new BlockConditionTypes.BlockType
        {
            BlockId = blockId
        };
    }
    
    public static BlockConditionTypes.Command Command(string ranCommand, Comparison comparison, int compareTo)
    {
        return new BlockConditionTypes.Command
        {
            RanCommand = ranCommand,
            Comparison = comparison,
            CompareTo = compareTo
        };
    }
    
    public static BlockConditionTypes.ExposedToSky ExposedToSky() => new();
    
    public static BlockConditionTypes.Fluid Fluid(FluidCondition condition)
    {
        return new BlockConditionTypes.Fluid
        {
            FluidCondition = condition
        };
    }
    
    public static BlockConditionTypes.Hardness Hardness(float compareTo, Comparison comparison)
    {
        return new BlockConditionTypes.Hardness
        {
            CompareTo = compareTo,
            Comparison = comparison
        };
    }
    
    public static BlockConditionTypes.LightLevel LightLevel(float compareTo, Comparison comparison)
    {
        return new BlockConditionTypes.LightLevel
        {
            CompareTo = compareTo,
            Comparison = comparison
        };
    }
    
    public static BlockConditionTypes.Height Height(float compareTo, Comparison comparison)
    {
        return new BlockConditionTypes.Height
        {
            CompareTo = compareTo,
            Comparison = comparison
        };
    }
    
    public static BlockConditionTypes.InTag InTag(string tag)
    {
        return new BlockConditionTypes.InTag
        {
            Tag = tag
        };
    }
    
    public static BlockConditionTypes.LightBlocking LightBlocking() => new();
    
    public static BlockConditionTypes.MovementBlocking MovementBlocking() => new();
    
    public static BlockConditionTypes.NBT NBT(string nbt)
    {
        return new BlockConditionTypes.NBT
        {
            Nbt = nbt
        };
    }
    
    public static BlockConditionTypes.Replaceable Replaceable() => new();
    
    public static BlockConditionTypes.Slipperiness Slipperiness(float compareTo, Comparison comparison)
    {
        return new BlockConditionTypes.Slipperiness
        {
            CompareTo = compareTo,
            Comparison = comparison
        };
    }
    
    public static BlockConditionTypes.WaterLoggable WaterLoggable() => new();
}