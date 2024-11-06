using DatapackLib.Lib.Other;

namespace DatapackLib.Lib.Conditions;

public static class BiEntityConditions
{
    public static BiEntityConditionTypes.AttackTarget AttackTarget => new();
    
    public static BiEntityConditionTypes.Attacker Attacker => new();
    
    public static BiEntityConditionTypes.CanSee CanSee => new();
    
    public static BiEntityConditionTypes.Distance Distance(Comparison comparison, float compareTo) => new()
    {
        Comparison = comparison,
        CompareTo = compareTo
    };
    
    public static BiEntityConditionTypes.Owner Owner => new();
    
    public static BiEntityConditionTypes.RidingRecursive RidingRecursive => new();
    
    public static BiEntityConditionTypes.RidingRoot RidingRoot => new();
    
    public static BiEntityConditionTypes.Riding Riding => new();
    
    public static BiEntityConditionTypes.Equal Equal => new();
    
    // Meta conditions
    public static BiEntityConditionTypes.ActorCondition ActorCondition(EntityCondition condition) => new()
    {
        Condition = condition
    };
    
    public static BiEntityConditionTypes.TargetCondition TargetCondition(EntityCondition condition) => new()
    {
        Condition = condition
    };
    
    public static BiEntityConditionTypes.BothCondition BothCondition(EntityCondition condition) => new()
    {
        Condition = condition
    };
    
    public static BiEntityConditionTypes.EitherCondition EitherCondition(EntityCondition condition) => new()
    {
        Condition = condition
    };
    
    public static BiEntityConditionTypes.InvertedCondition InvertedCondition(EntityCondition condition) => new()
    {
        Condition = condition
    };
    
    public static BiEntityConditionTypes.UndirectedCondition UndirectedCondition(EntityCondition condition) => new()
    {
        Condition = condition
    };
}