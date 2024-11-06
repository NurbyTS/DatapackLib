using DatapackLib.Lib.Datapacks;

namespace DatapackLib.Lib.Other;

public class EquipmentSlot(int ignore) : ManualComponent
{
    public static EquipmentSlot MainHand = new(0);
    public static EquipmentSlot OffHand = new(1);
    public static EquipmentSlot Head = new(2);
    public static EquipmentSlot Chest = new(3);
    public static EquipmentSlot Legs = new(4);
    public static EquipmentSlot Feet = new(5);
    public override object ToDatapack()
    {
        return ignore switch
        {
            0 => "mainhand",
            1 => "offhand",
            2 => "head",
            3 => "chest",
            4 => "legs",
            5 => "feet",
            _ => throw new Exception("Invalid comparison value.")
        };
    }
}