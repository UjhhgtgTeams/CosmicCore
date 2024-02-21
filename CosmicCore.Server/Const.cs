using CosmicCore.Protos;

namespace CosmicCore.Server;

public static class Const
{
    #region Server

    public const string Name = "CosmicCore";
    public const string Version = "0.0.1";

    #endregion

    #region Game

    public const string GameVersion = "beta/2.1.0";

    public static int CurrentZoneOffset = DateTimeOffset.Now.Offset.Hours;

    // Game
    public static string DefaultName = "Trailblazer";
    public static int[] DefaultHeadIcons = [208001, 208002];
    public static int TrailblazerAvatarId = 8001;
    public static int MaxTrailblazerLevel = 70;
    public static int[] WorldLevelUpgrades = [0, 20, 30, 40, 50, 60, 65];
    public static int MaxStamina = 240;
    public static int MaxReservedStamina = 2400;
    public static int MaxAvatarsInTeam = 4;
    public static int DefaultTeams = 9;
    public static int MaxMp = 5;
    public static int FarmElementStaminaCost = 30;

    // Chat
    public static int MaxFriendships = 100;
    public static int MaxChatHistory = 100;

    // Inventory
    public static int MaterialHCoinId = 1;
    public static int MaterialCoinId = 2;
    public static int TrailblazerExpId = 22;

    public static int InventoryMaxEquipment = 1500;
    public static int InventoryMaxRelic = 1500;
    public static int InventoryMaxMaterial = 2000;

    // Start position
    public static int StartPlaneId = 20001;
    public static int StartFloorId = 20001001;
    public static int StartEntryId = 2000101;

    public static MotionInfo StartPos = new()
        { Pos = new Vector { X = 99, Y = 62, Z = -4800 }, Rot = new Vector { Y = 180000 } };

    // Battle
    public static int BattleAmbushBuffId = 1000102;

    // Gacha
    public static int MaxGachaCeiling = 300;

    // Challenge
    public static int ChallengeEntrance = 100000103;
    public static int ChallengeStoryEntrance = 102020107;

    // Rogue
    public static bool RogueEnabled = false;
    public static int RogueEntrance = 801120102;
    public static int RogueTalentPointItemId = 32;

    // Custom
    public static int ServerConsoleId = 99;
    public static int EquipmentSlotId = 100;

    #endregion
}
