using DatapackLib.Lib.Other;

namespace DatapackLib.Lib.Conditions;

public class ItemCondition : Condition;

public class ItemConditionTypes
{
    public class Amount : ItemCondition
    {
        public override string? Type => "origins:amount";
        
        [RequiredParameter("compare_to")] public int? CompareTo;
        [RequiredParameter("comparison")] public Comparison? Comparison;
    }
    
    public class ArmorValue : ItemCondition
    {
        public override string? Type => "origins:armor_value";
        
        [RequiredParameter("compare_to")] public float? CompareTo;
        [RequiredParameter("comparison")] public Comparison? Comparison;
    }
    
    public class Durability : ItemCondition
    {
        public override string? Type => "origins:durability";
        
        [RequiredParameter("compare_to")] public int? CompareTo;
        [RequiredParameter("comparison")] public Comparison? Comparison;
    }
    
    public class Empty : ItemCondition
    {
        public override string? Type => "origins:empty";
    }
    
    public class Enchantable : ItemCondition
    {
        public override string? Type => "origins:enchantable";
    }
    
    public class Enchantment : ItemCondition
    {
        public override string? Type => "origins:enchantment";
        
        [RequiredParameter("comparison")] public Comparison? Comparison;
        [RequiredParameter("compare_to")] public int? CompareTo;
        
        [OptionalParameter("enchantment", null)] public string? EnchantmentId;
    }
    
    public class FireProof : ItemCondition
    {
        public override string? Type => "origins:fire_proof";
    }
    
    public class Food : ItemCondition
    {
        public override string? Type => "origins:food";
    }
    
    public class Fuel : ItemCondition
    {
        public override string? Type => "origins:fuel";
        
        [RequiredParameter("compare_to")] public int? CompareTo;
        [RequiredParameter("comparison")] public Comparison? Comparison;
    }
    
    public class HarvestLevel : ItemCondition
    {
        public override string? Type => "origins:harvest_level";
        
        [RequiredParameter("compare_to")] public int? CompareTo;
        [RequiredParameter("comparison")] public Comparison? Comparison;
    }

    public class Ingredient : ItemCondition
    {
        public override string? Type => "origins:ingredient";
        
        // Not a parameter, this will be added manually
        public string[] Ingredients;

        public override void ManualFields(Dictionary<string, object> fields)
        {
            var ingredient = new object[Ingredients.Length];
            int i = 0;
            foreach (string s in Ingredients)
            {
                if (s.StartsWith("#"))
                {
                    ingredient[i] = new {tag = s[1..]};
                }
                else
                {
                    ingredient[i] = new {item = s};
                }

                i++;
            }
            
            fields.Add("ingredient", ingredient);
        }
    }
    
    public class IsDamageable : ItemCondition
    {
        public override string? Type => "origins:is_damageable";
    }
    
    public class IsEquippable : ItemCondition
    {
        public override string? Type => "origins:is_equippable";
        
        [OptionalParameter("equipment_slot", null)] public EquipmentSlot? EquipmentSlot;
    }
    
    public class Meat : ItemCondition
    {
        public override string? Type => "origins:meat";
    }
    
    public class NBT : ItemCondition
    {
        public override string? Type => "origins:nbt";
        
        [RequiredParameter("nbt")] public string? Nbt;
    }
    
    public class RelativeDurability : ItemCondition
    {
        public override string? Type => "origins:relative_durability";
        
        [RequiredParameter("compare_to")] public float? CompareTo;
        [RequiredParameter("comparison")] public Comparison? Comparison;
    }
    
    public class Smeltable : ItemCondition
    {
        public override string? Type => "origins:smeltable";
    }
}