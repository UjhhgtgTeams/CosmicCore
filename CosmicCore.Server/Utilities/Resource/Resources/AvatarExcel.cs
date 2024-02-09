namespace CosmicCore.Server.Utilities.Resource.Resources;

[Resource(FileNames = ["AvatarConfig.json"])]
public partial class AvatarExcel : IResource
{
    public override int Id => AvatarID;
    public int RankUpItemId => AvatarID + 10000;

    public int AvatarID { get; private set; }
    public long AvatarName { get; private set; }
    public DamageType DamageType { get; private set; }
    public AvatarBaseType AvatarBaseType { get; private set; }

    public int ExpGroup { get; private set; }
    public int MaxPromotion { get; private set; }
    public int MaxRank { get; private set; }

    public int[] RankIdList { get; private set; }
    public int[] SkillList { get; private set; }
    public string JsonPath { get; private set; }

    public int GetRankId(int rank)
    {
        return RankIdList[Math.Min(rank, RankIdList.Length - 1)];
    }

    public override void OnLoad()
    {
    }
}

public enum DamageType
{
    Physical = 1000111,
    Fire = 1000112,
    Ice = 1000113,
    Thunder = 1000114,
    Wind = 1000115,
    Quantum = 1000116,
    Imaginary = 1000117
}

public enum AvatarBaseType
{
    Unknown = 0,
    Warrior = 1,
    Rogue = 2,
    Mage = 3,
    Shaman = 4,
    Warlock = 5,
    Knight = 6,
    Priest = 7
}
