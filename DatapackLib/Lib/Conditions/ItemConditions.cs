using DatapackLib.Lib.Other;

namespace DatapackLib.Lib.Conditions;

public static class ItemConditions
{
    public static ItemConditionTypes.Empty Empty => new();

    public static ItemConditionTypes.Enchantable Enchantable => new();

    public static ItemConditionTypes.FireProof FireProof => new();

    public static ItemConditionTypes.Food Food => new();

    public static ItemConditionTypes.IsDamageable IsDamageable => new();

    public static ItemConditionTypes.IsEquippable IsEquippable => new();

    public static ItemConditionTypes.Meat Meat => new();

    public static ItemConditionTypes.Smeltable Smeltable => new();

    public static ItemConditionTypes.Amount Amount(int compareTo, Comparison comparison)
    {
        return new ItemConditionTypes.Amount
        {
            CompareTo = compareTo,
            Comparison = comparison
        };
    }

    public static ItemConditionTypes.ArmorValue ArmorValue(float compareTo, Comparison comparison)
    {
        return new ItemConditionTypes.ArmorValue
        {
            CompareTo = compareTo,
            Comparison = comparison
        };
    }

    public static ItemConditionTypes.Durability Durability(int compareTo, Comparison comparison)
    {
        return new ItemConditionTypes.Durability
        {
            CompareTo = compareTo,
            Comparison = comparison
        };
    }

    public static ItemConditionTypes.Enchantment Enchantment(Comparison comparison, int compareTo,
        string? enchantmentId = null)
    {
        return new ItemConditionTypes.Enchantment
        {
            Comparison = comparison,
            CompareTo = compareTo,
            EnchantmentId = enchantmentId
        };
    }

    public static ItemConditionTypes.Fuel Fuel(int compareTo, Comparison comparison)
    {
        return new ItemConditionTypes.Fuel
        {
            CompareTo = compareTo,
            Comparison = comparison
        };
    }

    public static ItemConditionTypes.HarvestLevel HarvestLevel(int compareTo, Comparison comparison)
    {
        return new ItemConditionTypes.HarvestLevel
        {
            CompareTo = compareTo,
            Comparison = comparison
        };
    }

    public static ItemConditionTypes.Ingredient Ingredient(params string[] ingredients)
    {
        return new ItemConditionTypes.Ingredient
        {
            Ingredients = ingredients
        };
    }

    public static ItemConditionTypes.NBT NBT(string nbt)
    {
        return new ItemConditionTypes.NBT
        {
            Nbt = nbt
        };
    }

    public static ItemConditionTypes.RelativeDurability RelativeDurability(float compareTo, Comparison comparison)
    {
        return new ItemConditionTypes.RelativeDurability
        {
            CompareTo = compareTo,
            Comparison = comparison
        };
    }
}