using DatapackLib.Lib;
using DatapackLib.Lib.Datapacks;

namespace DatapackLib;

public static class DatapackLib
{
    public static void Compile<T>() where T : Datapack
    {
        T datapack = Activator.CreateInstance<T>();
        DatapackFiles files = new DatapackFiles(datapack.FolderName);
    }

    public static void Setup(Datapack datapack, DatapackFiles files)
    {
        files.AddFolder("", "data");
        var pack = new
        {
            pack = new
            {
                pack_format = (int)datapack.PackFormat,
                description = datapack.Description
            }
        };
    }
}