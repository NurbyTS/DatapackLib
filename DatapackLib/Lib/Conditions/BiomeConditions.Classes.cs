using DatapackLib.Lib.Datapacks;
using DatapackLib.Lib.Other;

namespace DatapackLib.Lib.Conditions;

// Core class
public class BiomeCondition : Condition;

public class BiomeConditionTypes
{
    public class HighHumidity : BiomeCondition
    {
        public override string? Type => "minecraft:high_humidity";
    }
    
    public class InTag : BiomeCondition
    {
        public override string? Type => "minecraft:in_tag";
        
        [RequiredParameter("tag")] public string? Tag;
    }
    
    public class Precipitation : BiomeCondition
    {
        public override string? Type => "minecraft:precipitation";
        
        [RequiredParameter("precipitation")] public string? PrecipitationType;
    }
    
    public class Temperature : BiomeCondition
    {
        public override string? Type => "minecraft:temperature";
        
        [RequiredParameter("compare_to")] public float? CompareTo;
        [RequiredParameter("comparison")] public Comparison? Comparison;
    }
}