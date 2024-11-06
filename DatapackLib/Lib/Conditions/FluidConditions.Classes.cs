namespace DatapackLib.Lib.Conditions;

public class FluidCondition : Condition;

public partial class FluidConditionTypes
{
    public class Empty : FluidCondition
    {
        public override string? Type => "origins:empty";
    }
    
    public class InTag : FluidCondition
    {
        public override string? Type => "origins:in_tag";
        
        [RequiredParameter("tag")] public string? Tag;
    }
    
    public class Still : FluidCondition
    {
        public override string? Type => "origins:still";
    }
}