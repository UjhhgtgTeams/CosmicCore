using CosmicCore.Protos;
using CosmicCore.Server.Utilities;
using CosmicCore.Server.Utilities.Account;
using CosmicCore.Server.Utilities.Resource;
using CosmicCore.Server.Utilities.Resource.Resources;
using Random = CosmicCore.Server.Utilities.Random;

namespace CosmicCore.Server.Gate.Services.Inventory;

public class Item
{
    public long OwnerId { get; private set; }

    public Account Owner
    {
        get => Program.AccountDatabase[OwnerId];
        set
        {
            OwnerId = value.Id;
            InternalId = value.Inventory.NextInternalId;
        }
    }

    public int InternalId { get; private set; }
    public ItemExcel? Excel { get; set; }

    public int ItemId { get; set; }
    public int Count { get; set; }
    public int Level { get; set; }
    public int Experience { get; set; }
    public int TotalExperience { get; set; }
    public int Promotion { get; set; }
    public int Rank { get; set; }
    public bool Locked { get; set; }
    public bool Discarded { get; set; }

    public int RelicMainAffix { get; set; }
    public List<RelicSubAffix>? RelicSubAffixes { get; private set; }

    public int EquipAvatar { get; set; }

    public bool Destroyable => !Locked && !Discarded;

    public Item(int id) : this(ResourceManager.ItemExcels.First(item => item.Id == id))
    {

    }

    public Item(int id, int count) : this(ResourceManager.ItemExcels.First(item => item.Id == id), count)
    {

    }

    public Item(ItemExcel excel) : this(excel, 1)
    {

    }

    public Item(ItemExcel excel, int count) : this(excel, count, 0)
    {

    }

    public Item(ItemExcel excel, int count, int overrideRelicMainAffix)
    {
        ItemId = excel.Id;
        Excel = excel;

        switch (excel.ItemMainType)
        {
            case ItemMainType.Virtual:
                Count = count;
                break;

            case ItemMainType.Equipment:
                Count = 1;
                Level = 1;
                Rank = 1;
                break;

            case ItemMainType.Relic:
                Count = 1;
                if (Excel.RelicExcel is not null)
                {
                    if (overrideRelicMainAffix != 0)
                    {
                        RelicMainAffix = overrideRelicMainAffix;
                    }
                    else
                    {
                        var affix = Random.FromList(ResourceManager.RelicMainAffixExcels[Excel.RelicExcel.MainAffixGroup]);
                        RelicMainAffix = affix.AffixId;
                    }

                    var baseSubAffixes = Math.Min(Math.Max((int)Excel.Rarity - 2, 0), 3);
                    AddSubAffixes(Random.FromIntRange(baseSubAffixes, baseSubAffixes + 1));
                }

                break;
            default:
                Count = Math.Min(count, Excel.PileLimit);
                break;
        }
    }

    private void AddSubAffixes(int quantity)
    {
        for (var i = 0; i < quantity; i++)
        {
            AddSubAffix();
        }
        RelicSubAffixes.Sort();
    }

    private void AddSubAffix()
    {
        RelicSubAffixes ??= [];

        if (RelicSubAffixes.Count < 4)
        {
            AddNewSubAffix();
        }
        else
        {
            UpgradeRandomSubAffix();
        }
    }

    private void AddNewSubAffix()
    {
        var excels = ResourceManager.RelicSubAffixExcels[Excel.RelicExcel.SubAffixGroup];
        var mainAffixProperty = AvatarPropertyType.Unknown;
        var mainAffix = ResourceManager.RelicMainAffixExcels.Values.SelectMany(list => list.AsEnumerable())
            .First(exc => exc.Id == (Excel.RelicExcel.MainAffixGroup << 16) + RelicMainAffix);
        if (mainAffix is not null)
            mainAffixProperty = mainAffix.Property;

        var blacklist = new HashSet<int>();
        foreach (var subAffix in RelicSubAffixes)
        {
            blacklist.Add(subAffix.Id);
        }

        var subAffixes = new WeightedEnumerable<RelicSubAffixExcel>();
        foreach (var affix in excels)
        {
            if (affix.Property != mainAffixProperty && !blacklist.Contains(affix.AffixId))
            {
                subAffixes.Add(affix, 10);
                // TODO: allow custom weight
            }
        }

        if (!subAffixes.Any())
            return;

        var randomSubAffix = Random.FromList(subAffixes.ToList());
        RelicSubAffixes.Add(new RelicSubAffix(randomSubAffix));
    }

    private void UpgradeRandomSubAffix()
    {
        var subAffix = Random.FromList(RelicSubAffixes);
        var subAffixExcel = ResourceManager.RelicSubAffixExcels.Values.SelectMany(list => list.AsEnumerable())
            .First(exc => exc.Id == (Excel.RelicExcel.SubAffixGroup << 16) + subAffix.Id);
        subAffix.IncrementCount(subAffixExcel.StepNum);
    }

    public Material ToMaterialProto()
    {
        return new Material
        {
            Tid = (uint)ItemId,
            Num = (uint)Count
        };
    }

    public Relic ToRelicProto()
    {
        var proto = new Relic
        {
            Tid = (uint)ItemId,
            UniqueId = (uint)InternalId,
            Level = (uint)Level,
            Exp = (uint)Experience,
            IsProtected = Locked,
            IsDiscarded = Discarded,
            BaseAvatarId = (uint)EquipAvatar,
            MainAffixId = (uint)RelicMainAffix
        };

        if (RelicSubAffixes is not null)
        {
            foreach (var subAffix in RelicSubAffixes)
            {
                proto.SubAffixList.Add(subAffix.ToProto());
            }
        }

        return proto;
    }

    public Equipment ToEquipmentProto()
    {
        return new Equipment
        {
            Tid = (uint)ItemId,
            UniqueId = (uint)InternalId,
            Level = (uint)Level,
            Exp = (uint)Experience,
            IsProtected = Locked,
            Promotion = (uint)Promotion,
            Rank = (uint)Rank,
            BaseAvatarId = (uint)EquipAvatar
        };
    }

    public PileItem ToPileItemProto()
    {
        return new PileItem
        {
            ItemId = (uint)ItemId,
            ItemNum = (uint)Count
        };
    }

    public Protos.Item ToProto()
    {
        return new Protos.Item
        {
            ItemId = (uint)ItemId,
            Num = (uint)Count,
            Level = (uint)Level,
            Rank = (uint)Rank,
            UniqueId = (uint)InternalId,
            Promotion = (uint)Promotion,
            MainAffixId = (uint)RelicMainAffix
        };
    }
}
