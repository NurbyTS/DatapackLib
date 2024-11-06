using DatapackLib.Lib.Datapacks;

namespace DatapackLib.Lib.Powers;

public class Power : DatapackComponent
{
    [RequiredParameter("type")] public virtual string? Type => null;
    [RequiredParameter("name")] public string? Name;
    [OptionalParameter("description", null)] public string? Description;
    [OptionalParameter("hidden", false)] public bool Hidden;
}