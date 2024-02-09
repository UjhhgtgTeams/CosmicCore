namespace CosmicCore.Server.Utilities.Resource.Resources;

[Resource(FileNames = ["StageConfig.json"])]
public class StageExcel : IResource
{
    public override int Id => StageID;
    public int StageID { get; private set; }
    public long StageName { get; private set; }
    public StageType StageType { get; private set; }
    public int Level { get; private set; }

    public IEnumerable<StageMonsterWave> MonsterList { get; }

    private List<List<int>> monsterWaves;

    public override void OnLoad()
    {
        if (StageType != null)
        {
            StageType = StageType.Unknown;
        }

        monsterWaves = [];

        foreach (var monsterIds in MonsterList.Select(wave => wave.ToList()).Where(monsterIds => monsterIds.Count != 0))
        {
            monsterWaves.Add(monsterIds);
        }
    }

    public class StageMonsterWave
    {
        public int Monster0 { get; }
        public int Monster1 { get; }
        public int Monster2 { get; }
        public int Monster3 { get; }
        public int Monster4 { get; }

        public List<int> ToList()
        {
            List<int> list = [];

            if (Monster0 != 0)
            {
                list.Add(Monster0);
            }

            if (Monster1 != 0)
            {
                list.Add(Monster1);
            }

            if (Monster2 != 0)
            {
                list.Add(Monster2);
            }

            if (Monster3 != 0)
            {
                list.Add(Monster3);
            }

            if (Monster4 != 0)
            {
                list.Add(Monster4);
            }

            return list;
        }
    }
}

// ReSharper disable IdentifierTypo
public enum StageType
{
    Unknown = 0,
    Mainline = 1,
    Maze = 2,
    Adventure = 3,
    Cocoon = 4,
    FarmElement = 5,
    Client = 6,
    FarmRelic = 7,
    VerseSimulation = 8,
    Trial = 9,
    PunkLord = 10,
    FightActivity = 11,
    TrialAdventure = 12,
    BoxingClub = 13,
    TrialInBattle = 14,
    RogueChallengeActivity = 15,
    TreasureDungeon = 16,
    AetherDivide = 17,
    FantasticStory = 18,
    BattleCollege = 19,
    Heliobus = 20,
    RogueEndlessActivity = 21,
    StrongChallengeActivity = 22,
    Challenge = 23
}
