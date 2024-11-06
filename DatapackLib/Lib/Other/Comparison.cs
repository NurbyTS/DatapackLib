using DatapackLib.Lib.Datapacks;

namespace DatapackLib.Lib.Other;

public class Comparison(int ignore) : ManualComponent
{
    public static Comparison LessThan = new(0);
    public static Comparison LessThanOrEqual = new(1);
    public static Comparison Equal = new(2);
    public static Comparison GreaterThanOrEqual = new(3);
    public static Comparison GreaterThan = new(4);
    public override object ToDatapack()
    {
        return ignore switch
        {
            0 => "<",
            1 => "<=",
            2 => "==",
            3 => ">=",
            4 => ">",
            _ => throw new Exception("Invalid comparison value.")
        };
    }
}