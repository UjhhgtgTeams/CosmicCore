using CosmicCore.Protos;

namespace CosmicCore.Server;

public static class Const
{
    #region Server

    public const string Name = "CosmicCore";
    public const string Version = "0.0.1";
    public const string GitBranch = "beta/2.1";

    #endregion

    #region Game

    public const string GameVersion = "beta/2.1.0";

    public static int CurrentZoneOffset => DateTimeOffset.Now.Offset.Hours;

    // Game
    public const int TrailblazerAvatarId = 8001;
    public const int MaxTrailblazerLevel = 70;
    public const int MaxStamina = 240;
    public const int MaxReservedStamina = 2400;
    public const int MaxAvatarsInTeam = 4;
    public const int DefaultTeams = 9;
    public const int MaxMp = 5;
    public const int FarmElementStaminaCost = 30;

    // Chat
    public const int MaxFriendships = 100;
    public const int MaxChatHistory = 100;

    // Inventory
    public const int MaterialHCoinId = 1;
    public const int MaterialCoinId = 2;
    public const int TrailblazerExpId = 22;

    public const int InventoryMaxEquipment = 1500;
    public const int InventoryMaxRelic = 1500;
    public const int InventoryMaxMaterial = 2000;

    // Start position
    public const int StartPlaneId = 20321;
    public const int StartFloorId = 20321001;
    public const int StartEntryId = 2032101;

    public static readonly MotionInfo StartPos = new()
        { Pos = new Vector { X = 99, Y = 62, Z = -4800 }, Rot = new Vector { Y = 180000 } };

    // Battle
    public const int BattleAmbushBuffId = 1000102;

    // Gacha
    public const int MaxGachaCeiling = 300;

    // Challenge
    public const int ChallengeEntrance = 100000103;
    public const int ChallengeStoryEntrance = 102020107;

    // Rogue
    public static bool RogueEnabled = false;
    public const int RogueEntrance = 801120102;
    public const int RogueTalentPointItemId = 32;

    // Custom
    public const int ServerConsoleId = 99;
    public const int EquipmentSlotId = 100;

    #endregion
}
