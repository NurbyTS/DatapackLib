using DatapackLib.Lib.Datapacks;

namespace DatapackLib.Lib.Other;

public class Attribute(int ignore) : ManualComponent
{
    public static Attribute Armor = new(0);
    public static Attribute ArmorToughness = new(1);
    public static Attribute AttackDamage = new(2);
    public static Attribute AttackKnockback = new(3);
    public static Attribute AttackSpeed = new(4);
    public static Attribute FlyingSpeed = new(5);
    public static Attribute FollowRange = new(6);
    public static Attribute KnockbackResistance = new(7);
    public static Attribute Luck = new(8);
    public static Attribute MaxAbsorption = new(9);
    public static Attribute MaxHealth = new(10);
    public static Attribute MovementSpeed = new(11);
    public static Attribute StepHeight = new(12);
    public static Attribute JumpStrength = new(13);
    
    public override object ToDatapack()
    {
        return ignore switch
        {
            0 => "minecraft:generic.armor",
            1 => "minecraft:generic.armor_toughness",
            2 => "minecraft:generic.attack_damage",
            3 => "minecraft:generic.attack_knockback",
            4 => "minecraft:generic.attack_speed",
            5 => "minecraft:generic.flying_speed",
            6 => "minecraft:generic.follow_range",
            7 => "minecraft:generic.knockback_resistance",
            8 => "minecraft:generic.luck",
            9 => "minecraft:generic.max_absorption",
            10 => "minecraft:generic.max_health",
            11 => "minecraft:generic.movement_speed",
            12 => "minecraft:generic.step_height",
            13 => "minecraft:generic.jump_strength",
            _ => throw new Exception("Invalid comparison value.")
        };
    }
}