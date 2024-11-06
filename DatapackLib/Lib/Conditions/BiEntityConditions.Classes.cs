using DatapackLib.Lib.Other;

namespace DatapackLib.Lib.Conditions;

public class BiEntityCondition : Condition;

public class BiEntityConditionTypes
{
    public class AttackTarget : BiEntityCondition
    {
        public override string? Type => "origins:attack_target";
    }
    
    public class Attacker : BiEntityCondition
    {
        public override string? Type => "origins:attacker";
    }
    
    public class CanSee : BiEntityCondition
    {
        public override string? Type => "origins:can_see";

        [OptionalParameter("shape_type", null)] public string? ShapeType;
        [OptionalParameter("fluid_handling", null)] public string? FluidHandling;
    }

    public class Distance : BiEntityCondition
    {
        public override string? Type => "origins:distance";

        [RequiredParameter("comparison")] public Comparison? Comparison;
        [RequiredParameter("compare_to")] public float? CompareTo;
    }
    
    public class Owner : BiEntityCondition
    {
        public override string? Type => "origins:owner";
    }
    
    public class RidingRecursive : BiEntityCondition
    {
        public override string? Type => "origins:riding_recursive";
    }
    
    public class RidingRoot : BiEntityCondition
    {
        public override string? Type => "origins:riding_root";
    }
    
    public class Riding : BiEntityCondition
    {
        public override string? Type => "origins:riding";
    }
    
    public class Equal : BiEntityCondition
    {
        public override string? Type => "origins:equal";
    }
    
    // ignore
    public class MetaBiEntityCondition : BiEntityCondition
    {
        // type should be ignored for now
        [RequiredParameter("condition")] public EntityCondition? Condition;
    }

    public class ActorCondition : MetaBiEntityCondition
    {
        public override string? Type => "origins:actor_condition";
    }
    
    public class TargetCondition : MetaBiEntityCondition
    {
        public override string? Type => "origins:target_condition";
    }
    
    public class BothCondition : MetaBiEntityCondition
    {
        public override string? Type => "origins:both";
    }
    
    public class EitherCondition : MetaBiEntityCondition
    {
        public override string? Type => "origins:either";
    }
    
    public class InvertedCondition : MetaBiEntityCondition
    {
        public override string? Type => "origins:invert";
    }
    
    public class UndirectedCondition : MetaBiEntityCondition
    {
        public override string? Type => "origins:undirected";
    }
}