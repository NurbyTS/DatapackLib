namespace DatapackLib.Lib.Datapacks;

public enum PackFormat
{
    V1_20_1 = 10
}

public abstract class Datapack
{
    public abstract string InternalId { get; }
    public abstract string FolderName { get; }
    public virtual PackFormat PackFormat => PackFormat.V1_20_1;
    public virtual string Description => "";
}