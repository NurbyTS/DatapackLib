namespace DatapackLib.Lib.Conditions;

public static class FluidConditions
{
    public static FluidConditionTypes.Empty Empty => new();
    public static FluidConditionTypes.InTag InTag(string tag) => new() { Tag = tag };
    public static FluidConditionTypes.Still Still => new();
}