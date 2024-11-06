using DatapackLib.Lib.Other;

namespace DatapackLib.Lib.Conditions;

public static class BiomeConditions
{
    public static BiomeConditionTypes.HighHumidity HighHumidity => new ();
    public static BiomeConditionTypes.InTag InTag(string tag) => new () { Tag = tag };
    public static BiomeConditionTypes.Precipitation Precipitation(string precipitationType) => new () { PrecipitationType = precipitationType };
    public static BiomeConditionTypes.Temperature Temperature(float value, Comparison comparison) => new () { CompareTo = value, Comparison = comparison };
}