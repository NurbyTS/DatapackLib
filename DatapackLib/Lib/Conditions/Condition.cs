using DatapackLib.Lib.Datapacks;

namespace DatapackLib.Lib.Conditions;

public class Condition : DatapackComponent
{
    [OptionalParameter("inverted", false)] public bool? Inverted;
    [RequiredParameter("type")] public virtual string? Type => null;
}