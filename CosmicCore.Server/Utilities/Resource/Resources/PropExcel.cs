namespace CosmicCore.Server.Utilities.Resource.Resources;

[Resource(FileNames = ["MazeProp.json"])]
public class PropExcel : IResource
{
    public override int Id => ID;
    public int ID { get; set; }
    public HashedName PropName { get; set; }
    public string JsonPath { get; set; }
    public PropType PropType { get; set; }
    public HashSet<PropState> PropStateList { get; set; }
    public override void OnLoad() { }
}

// ReSharper disable InconsistentNaming
public enum PropType
{
    PROP_NONE = 0,
    PROP_ORDINARY = 1,
    PROP_SUMMON = 2,
    PROP_DESTRUCT = 3,
    PROP_SPRING = 4,
    PROP_PLATFORM = 5,
    PROP_TREASURE_CHEST = 6,
    PROP_MATERIAL_ZONE = 7,
    PROP_COCOON = 8,
    PROP_MAPPINGINFO = 9,
    PROP_PUZZLES = 10,
    PROP_ELEVATOR = 11,
    PROP_NO_REWARD_DESTRUCT = 12,
    PROP_LIGHT = 13,
    PROP_ROGUE_DOOR = 14,
    PROP_ROGUE_OBJECT = 15,
    PROP_ROGUE_CHEST = 16,
    PROP_TELEVISION = 17,
    PROP_RELIC = 18,
    PROP_ELEMENT = 19,
    PROP_ROGUE_HIDDEN_DOOR = 20,
    PROP_PERSPECTIVE_WALL = 21,
    PROP_MAZE_PUZZLE = 22,
    PROP_MAZE_DECAL = 23,
    PROP_ROGUE_REWARD_OBJECT = 24,
    PROP_MAP_ROTATION_CHARGER = 25,
    PROP_MAP_ROTATION_VOLUME = 26,
    PROP_MAP_ROTATION_SWITCHER = 27,
    PROP_BOXMAN_BINDED = 28
}

public enum PropState
{
    Closed = 0,
    Open = 1,
    Locked = 2,
    BridgeState1 = 3,
    BridgeState2 = 4,
    BridgeState3 = 5,
    BridgeState4 = 6,
    CheckPointDisable = 7,
    CheckPointEnable = 8,
    TriggerDisable = 9,
    TriggerEnable = 10,
    ChestLocked = 11,
    ChestClosed = 12,
    ChestUsed = 13,
    Elevator1 = 14,
    Elevator2 = 15,
    Elevator3 = 16,
    WaitActive = 17,
    EventClose = 18,
    EventOpen = 19,
    Hidden = 20,
    TeleportGate0 = 21,
    TeleportGate1 = 22,
    TeleportGate2 = 23,
    TeleportGate3 = 24,
    Destructed = 25,
    CustomState01 = 101,
    CustomState02 = 102,
    CustomState03 = 103,
    CustomState04 = 104,
    CustomState05 = 105,
    CustomState06 = 106,
    CustomState07 = 107,
    CustomState08 = 108,
    CustomState09 = 109
}
