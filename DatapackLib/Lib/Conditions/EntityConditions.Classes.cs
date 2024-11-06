using DatapackLib.Lib.Datapacks;
using DatapackLib.Lib.Other;

namespace DatapackLib.Lib.Conditions;

// Core class
public class EntityCondition : Condition;

public partial class EntityConditionTypes
{
    public class Ability : EntityCondition
    {
        public override string? Type => "origins:ability";
        
        [RequiredParameter("ability")] public string? AbilityName;
    }
    
    public class Advancement : EntityCondition
    {
        public override string? Type => "origins:advancement";
        
        [RequiredParameter("advancement")] public string? AdvancementId;
    }
    
    public class Air : EntityCondition
    {
        public override string? Type => "origins:air";
        
        [RequiredParameter("compare_to")] public float? CompareTo;
        [RequiredParameter("comparison")] public Comparison? Comparison;
    }

    public class Attribute : EntityCondition
    {
        public override string? Type => "origins:attribute";
        
        [RequiredParameter("attribute")] public Attribute? AttributeType;
        [RequiredParameter("compare_to")] public float? CompareTo;
        [RequiredParameter("comparison")] public Comparison? Comparison;
    }
    
    public class Biome : EntityCondition
    {
        public override string? Type => "origins:biome";
        
        [OptionalParameter("biome", null)] public string? BiomeId;
        [OptionalParameter("condition", null)] public BiomeCondition? Condition;
    }

    public class BlockCollision : EntityCondition
    {
        [OptionalParameter("block_condition", null)] public BlockCondition? BlockCondition;
        [OptionalParameter("offset_x", 0)] public int OffsetX;
        [OptionalParameter("offset_y", 0)] public int OffsetY;
        [OptionalParameter("offset_z", 0)] public int OffsetZ;
    }
    
    public class BlockInRadius : EntityCondition
    {
        public override string? Type => "origins:block_in_radius";
        
        [RequiredParameter("block")] public BlockCondition? BlockCondition;
        [RequiredParameter("radius")] public int? Radius;

        [OptionalParameter("shape", "cube")] public string? Shape = "cube";
        [OptionalParameter("comparison", null)] public Comparison? Comparison;
        [OptionalParameter("compare_to", null)] public int? CompareTo;
    }

    public class Brightness : EntityCondition
    {
        public override string? Type => "origins:brightness";
        
        [RequiredParameter("compare_to")] public float? CompareTo;
        [RequiredParameter("comparison")] public Comparison? Comparison;
    }
    
    public class Climbing : EntityCondition
    {
        public override string? Type => "origins:climbing";
    }
    
    public class CollidedHorizontally : EntityCondition
    {
        public override string? Type => "origins:collided_horizontally";
    }

    public class Command : EntityCondition
    {
        public override string? Type => "origins:command";
        
        [RequiredParameter("command")] public string? RanCommand;
        [RequiredParameter("comparison")] public Comparison? Comparison;
        [RequiredParameter("compare_to")] public int? CompareTo;
    }
    
    public class CreativeFlying : EntityCondition
    {
        public override string? Type => "origins:creative_flying";
    }
    
    public class Daytime : EntityCondition
    {
        public override string? Type => "origins:daytime";
    }
    
    public class Dimension : EntityCondition
    {
        public override string? Type => "origins:dimension";
        
        [RequiredParameter("dimension")] public string? DimensionId;
    }
    
    public class ElytraFlightPossible : EntityCondition
    {
        public override string? Type => "origins:elytra_flight_possible";
    }

    public class Enchantment : EntityCondition
    {
        public override string? Type => "origins:enchantment";
        
        [RequiredParameter("enchantment")] public string? EnchantmentType;
        [RequiredParameter("compare_to")] public float? CompareTo;
        [RequiredParameter("comparison")] public Comparison? Comparison;
        
        [OptionalParameter("calculation", null)] public string? Calculation;
    }
    
    public class EntityGroup : EntityCondition
    {
        public override string? Type => "origins:entity_group";
        
        [RequiredParameter("group")] public string? Group;
    }
    
    public class EntityType : EntityCondition
    {
        public override string? Type => "origins:entity_type";
        
        [RequiredParameter("entity_type")] public string? EntityId;
    }
    
    public class EquippedItem : EntityCondition
    {
        public override string? Type => "origins:equipped_item";
        
        [RequiredParameter("equipment_slot")] public EquipmentSlot? EquipmentSlot;
        [RequiredParameter("item_condition")] public ItemCondition? ItemCondition;
    }
    
    public class Exists : EntityCondition
    {
        public override string? Type => "origins:exists";
    }
    
    public class ExposedToSky : EntityCondition
    {
        public override string? Type => "origins:exposed_to_sky";
    }
    
    public class ExposedToSun : EntityCondition
    {
        public override string? Type => "origins:exposed_to_sun";
    }
    
    public class FallDistance : EntityCondition
    {
        public override string? Type => "origins:fall_distance";
        
        [RequiredParameter("compare_to")] public float? CompareTo;
        [RequiredParameter("comparison")] public Comparison? Comparison;
    }
    
    public class FallFlying : EntityCondition
    {
        public override string? Type => "origins:fall_flying";
    }
    
    public class FluidHeight : EntityCondition
    {
        public override string? Type => "origins:fluid_height";
        
        [RequiredParameter("fluid")] public string? FluidId;
        [RequiredParameter("compare_to")] public float? CompareTo;
        [RequiredParameter("comparison")] public Comparison? Comparison;
    }
    
    public class FoodLevel : EntityCondition
    {
        public override string? Type => "origins:food_level";
        
        [RequiredParameter("compare_to")] public float? CompareTo;
        [RequiredParameter("comparison")] public Comparison? Comparison;
    }
    
    public class Glowing : EntityCondition
    {
        public override string? Type => "origins:glowing";
    }
    
    public class Health : EntityCondition
    {
        public override string? Type => "origins:health";
        
        [RequiredParameter("compare_to")] public float? CompareTo;
        [RequiredParameter("comparison")] public Comparison? Comparison;
    }
    
    public class InBlockAnywhere : EntityCondition
    {
        public override string? Type => "origins:in_block_anywhere";
        
        [RequiredParameter("block_condition")] public BlockCondition? BlockCondition;
        
        [OptionalParameter("comparison", null)] public Comparison? Comparison;
        [OptionalParameter("compare_to", null)] public int? CompareTo;
    }
    
    public class InBlock : EntityCondition
    {
        public override string? Type => "origins:in_block";
        
        [RequiredParameter("block_condition")] public BlockCondition? BlockCondition;
    }
    
    public class InRain : EntityCondition
    {
        public override string? Type => "origins:in_rain";
    }
    
    public class InSnow : EntityCondition
    {
        public override string? Type => "origins:in_snow";
    }
    
    public class InTag : EntityCondition
    {
        public override string? Type => "origins:in_tag";
        
        [RequiredParameter("tag")] public string? Tag;
    }
    
    public class InThunderstorm : EntityCondition
    {
        public override string? Type => "origins:in_thunderstorm";
    }
    
    public class Inventory : EntityCondition
    {
        public override string? Type => "origins:inventory";
        
        [OptionalParameter("inventory_types", null)]  public string[]? InventoryTypes;
        [OptionalParameter("process_mode", null)] public string? ProcessMode;
        [OptionalParameter("item_condition", null)] public ItemCondition? ItemCondition;
        [OptionalParameter("slots", null)] public string[]? Slots;
        [OptionalParameter("comparison", null)] public Comparison? Comparison;
        [OptionalParameter("compare_to", null)] public int? CompareTo;
    }
    
    public class Invisible : EntityCondition
    {
        public override string? Type => "origins:invisible";
    }
    
    /*Living
       Moving
       NBT
       On Block
       On Fire
       Origin
       Passenger Recursive
       Passenger
       Power Active
       Power Type
       Power
       Predicate
       Raycast
       Relative Health
       Resource
       Riding Recursive
       Riding Root
       Riding
       Saturation Level
       Scoreboard
       Set Size
       Sneaking
       Sprinting
       Status Effect
       Submerged In
       Swimming
       Tamed
       Time Of Day
       Using Effective Tool
       Using Item
       XP Levels
       XP Points*/

    public class Living : EntityCondition
    {
        public override string? Type => "origins:living";
    }
    
    public class Moving : EntityCondition
    {
        public override string? Type => "origins:moving";
        
        [OptionalParameter("horizontally", null)] public bool? Horizontally;
        [OptionalParameter("vertically", null)] public bool? Vertically;
    }
    
    public class NBT : EntityCondition
    {
        public override string? Type => "origins:nbt";
        
        [RequiredParameter("nbt")] public string? Nbt;
    }
    
    public class OnBlock : EntityCondition
    {
        public override string? Type => "origins:on_block";
        
        [RequiredParameter("block_condition")] public BlockCondition? BlockCondition;
    }
    
    public class OnFire : EntityCondition
    {
        public override string? Type => "origins:on_fire";
    }

    // TODO: Add Origin class
    public class Origin : EntityCondition;
    
    // TODO: Add remaining classes (requires BiEntityCondition)
}