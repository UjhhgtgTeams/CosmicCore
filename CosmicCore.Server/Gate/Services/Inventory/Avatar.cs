using CosmicCore.Protos;
using CosmicCore.Server.Utilities.Account;
using CosmicCore.Server.Utilities.Resource;
using CosmicCore.Server.Utilities.Resource.Resources;
using Newtonsoft.Json;

namespace CosmicCore.Server.Gate.Services.Inventory;

public class Avatar : AccountManager
{
    private AvatarExcel? _excel;
    [JsonIgnore]
    public AvatarExcel? Excel
    {
        get => _excel;
        set
        {
            _excel ??= value;
            Data ??= new AvatarData(value);
        }
    }

    public int AvatarId { get; set; }
    public AvatarData? Data { get; set; }
    public int Level { get; set; } = 1;
    public int Experience { get; set; }
    public int Promotion { get; set; }
    public int Rewards { get; set; }
    public long Timestamp { get; set; }
    public int CurrentHp { get; set; } = int.MaxValue;
    public int CurrentSp { get; set; } = 0;
    public int ExtraLineupHp { get; set; }
    public int ExtraLineupSp { get; set; }
    [JsonIgnore] public int EntityId { get; set; }
    [JsonIgnore] public Dictionary<int, Item> Equips { get; set; } = new();
    [JsonIgnore] public Dictionary<int, long> Buffs { get; set; } = new();

    private AvatarHeroPath? _heroPath;
    [JsonIgnore]
    public AvatarHeroPath? HeroPath
    {
        get
        {
            return _heroPath;
        }
        set
        {
            if (_heroPath is not null)
                _heroPath.Avatar = null;
            Data = value.Data;
            Excel = value.Excel;
            _heroPath = value;
            _heroPath.Avatar = this;
        }
    }

    public bool IsHero => ResourceManager.HeroExcels.Any(hero => hero.HeroAvatarId == AvatarId);
    public int HeadIconId => AvatarId + 200000;

    public Avatar(int id) : this(ResourceManager.AvatarExcels.First(ava => ava.Id == id))
    {

    }

    public Avatar(AvatarExcel excel) : base(null)
    {
        AvatarId = excel.Id;
        Timestamp = DateTimeOffset.Now.ToUnixTimeSeconds();
        Excel = excel;
    }

    public Avatar(AvatarHeroPath path) : base(null)
    {
        AvatarId = Const.TrailblazerAvatarId;
        Timestamp = DateTimeOffset.Now.ToUnixTimeSeconds();
        HeroPath = path;
    }

    public Protos.Avatar ToProto()
    {
        var proto = new Protos.Avatar
        {
            BaseAvatarId = (uint)AvatarId,
            Level = (uint)Level,
            Exp = (uint)Experience,
            Promotion = (uint)Promotion,
            Rank = (uint)Data.Rank,
            FirstMetTimestamp = (ulong)Timestamp
        };

        foreach (var equip in Equips.Values)
        {
            switch (equip.Excel.ItemMainType)
            {
                case ItemMainType.Relic:
                    proto.EquipRelicList.Add(new EquipRelic
                    {
                        Slot = (uint)equip.Excel.EquipSlot,
                        RelicUniqueId = (uint)equip.InternalId
                    });
                    break;
                case ItemMainType.Equipment:
                    proto.EquipmentUniqueId = (uint)equip.InternalId;
                    break;
            }
        }

        foreach (var skill in Data.Skills)
        {
            proto.SkilltreeList.Add(new AvatarSkillTree
            {
                PointId = (uint)skill.Key,
                Level = (uint)skill.Value
            });
        }

        var takenRewards = new List<uint>();
        for (var i = 0; i < Promotion; i++)
        {
            if (HasTakenAward(i))
            {
                takenRewards.Add((uint)i);
            }
        }

        proto.TakenRewards = takenRewards.ToArray();

        return proto;
    }

    public LineupAvatar ToLineupAvatarProto(Lineup.Lineup lineup, int slot)
    {
        return new LineupAvatar
        {
            AvatarType = AvatarType.AvatarFormalType,
            Id = (uint)AvatarId,
            SpBar = new SpBarInfo { CurSp = (uint)CurrentSp, MaxSp = 10000 },
            Hp = (uint)CurrentHp,
            Slot = (uint)slot
        };
    }

    private bool HasTakenAward(int promotion)
    {
        return (Rewards & (1 << promotion)) != 0;
    }

    public class AvatarData
    {
        public int Rank { get; set; }
        public Dictionary<int, int> Skills { get; set; } = new();

        public AvatarData(AvatarExcel excel)
        {
            foreach (var skillTree in excel.DefaultSkillTrees)
            {
                Skills.Add(skillTree.PointId, skillTree.Level);
            }
        }
    }

    public class AvatarHeroPath
    {
        public int Id { get; set; }
        public long OwnerId { get; set; }
        public AvatarData Data { get; set; }
        [JsonIgnore] public Avatar? Avatar { get; set; }
        [JsonIgnore] public AvatarExcel Excel { get; set; }

        public AvatarHeroPath(Account account, AvatarExcel excel)
        {
            Id = excel.Id;
            OwnerId = account.Id;
            Data = new AvatarData(excel);
        }

        public HeroBasicTypeInfo ToProto()
        {
            var proto = new HeroBasicTypeInfo
            {
                BasicType = (HeroBasicType)Id,
                Rank = (uint)Data.Rank
            };

            foreach (var skill in Data.Skills)
            {
                proto.SkillTreeLists.Add(new AvatarSkillTree
                {
                    PointId = (uint)skill.Key,
                    Level = (uint)skill.Value
                });
            }

            return proto;
        }
    }
}
