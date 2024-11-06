using DatapackLib.Lib.Datapacks;
using DatapackLib.Lib.Other;

namespace DatapackLib.Lib.Conditions;

// Core class
public class EntityCondition : Condition;

public partial class EntityConditionTypes
{
    public class Ability : EntityCondition
    {
        public override string? Type => "origins:ability";
        
        [RequiredParameter("ability")] public string? AbilityName;
    }
    
    public class Advancement : EntityCondition
    {
        public override string? Type => "origins:advancement";
        
        [RequiredParameter("advancement")] public string? AdvancementId;
    }
    
    public class Air : EntityCondition
    {
        public override string? Type => "origins:air";
        
        [RequiredParameter("compare_to")] public float? CompareTo;
        [RequiredParameter("comparison")] public Comparison? Comparison;
    }

    public class Attribute : EntityCondition
    {
        public override string? Type => "origins:attribute";
        
        [RequiredParameter("attribute")] public Attribute? AttributeType;
        [RequiredParameter("compare_to")] public float? CompareTo;
        [RequiredParameter("comparison")] public Comparison? Comparison;
    }
    
    public class Biome : EntityCondition
    {
        public override string? Type => "origins:biome";
        
        [OptionalParameter("biome", null)] public string? BiomeId;
        [OptionalParameter("condition", null)] public BiomeCondition? Condition;
    }
}