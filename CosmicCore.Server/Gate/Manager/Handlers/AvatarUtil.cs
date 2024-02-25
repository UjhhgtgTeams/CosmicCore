using CosmicCore.Protos;
using CosmicCore.Server.Utilities;
using Serilog;

namespace CosmicCore.Server.Gate.Manager.Handlers;

public static class AvatarUtil
{
    public class Avatar(uint id, uint rank, Weapon? weapon, List<Relic> relics)
    {
        private static readonly List<uint> SkillIdEnds =
            [1, 2, 3, 4, 7, 101, 102, 103, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210];

        public uint Id { get; set; } = id;
        public uint Rank { get; set; } = rank;
        public Weapon? Weapon { get; set; } = weapon;
        public List<Relic> Relics { get; set; } = relics;

        public static implicit operator Protos.Avatar(Avatar avatar)
        {
            Log.Debug("Converting avatar {Id} to Avatar...", avatar.Id);

            // base
            var proto = new Protos.Avatar
            {
                BaseAvatarId = avatar.Id,
                Exp = 0,
                Level = 80,
                Promotion = 6,
                Rank = avatar.Rank,
                HasTakenPromotionRewardList = ListUtil.FromUIntRange(0, 5).ToArray()
            };
            // if (avatar.Weapon is not null)
            //     proto.EquipmentUniqueId = avatar.Weapon.UniqueId;

            // skills
            foreach (var end in SkillIdEnds)
            {
                var level = end switch
                {
                    1 => 6u,
                    <= 4 => 10u,
                    > 4 => 1u
                };

                proto.SkilltreeList.Add(new AvatarSkillTree
                {
                    PointId = avatar.Id * 1000 + end,
                    Level = level
                });
            }

            // relics
            foreach (var relic in avatar.Relics)
            {
                proto.EquipRelicList.Add(relic);
            }

            return proto;
        }

        public static implicit operator BattleAvatar(Avatar avatar)
        {
            Log.Debug("Converting avatar {Id} to BattleAvatar...", avatar.Id);

            // base
            var proto = new BattleAvatar
            {
                Id = avatar.Id,
                Level = 80,
                Promotion = 6,
                Rank = avatar.Rank,
                Hp = 10000,
                AvatarType = AvatarType.AvatarFormalType,
                WorldLevel = 6,
                Sp = new AmountInfo { CurrentAmount = 10000, MaxAmount = 10000 }
            };
            if (avatar.Weapon is not null)
                proto.EquipmentList.Add(avatar.Weapon);

            // skills
            foreach (var end in SkillIdEnds)
            {
                var level = end switch
                {
                    1 => 6u,
                    <= 4 => 10u,
                    > 4 => 1u
                };

                proto.SkilltreeList.Add(new AvatarSkillTree
                {
                    PointId = avatar.Id * 1000 + end,
                    Level = level
                });
            }

            // relics
            foreach (var relic in avatar.Relics)
            {
                proto.RelicList.Add(relic);
            }

            return proto;
        }

        public LineupAvatar ToLineupAvatar(int slot)
        {
            Log.Debug("Converting avatar {Id} to LineupAvatar at slot {Slot}...", Id, slot);

            return new LineupAvatar
            {
                Id = Id,
                Hp = 10000,
                Satiety = 100,
                Sp = new AmountInfo { CurrentAmount = 10000, MaxAmount = 10000 },
                AvatarType = AvatarType.AvatarFormalType,
                Slot = (uint)slot
            };
        }
    }

    public class Weapon(uint id, uint rank)
    {
        public uint Id { get; set; } = id;
        public uint Rank { get; set; } = rank;

        // public uint UniqueId { get; } = (uint)RandomUtil.FromIntRange(0, int.MaxValue - 1);

        public static implicit operator BattleEquipment(Weapon weapon)
        {
            Log.Debug("Converting weapon {Id} to BattleEquipment...", weapon.Id);

            return new BattleEquipment
            {
                Id = weapon.Id,
                Level = 80,
                Rank = weapon.Rank,
                Promotion = 6
            };
        }
    }

    public class Relic(uint id, uint mainAffixId, List<Relic.SubAffix> subAffixes)
    {
        public uint Id { get; set; } = id;
        public uint MainAffix { get; set; } = mainAffixId;
        public List<SubAffix> SubAffixes { get; set; } = subAffixes;

        // public uint UniqueId { get; } = (uint)RandomUtil.FromIntRange(0, int.MaxValue - 1);

        public static implicit operator EquipRelic(Relic relic)
        {
            Log.Debug("Converting relic {Id} to EquipRelic...", relic.Id);

            return new EquipRelic
            {
                // RelicUniqueId = relic.UniqueId,
                Slot = uint.Parse(relic.Id.ToString().Last().ToString()) // hacky way to get relic type without excels
            };
        }

        public static implicit operator BattleRelic(Relic relic)
        {
            Log.Debug("Converting relic {Id} to BattleRelic...", relic.Id);

            var proto = new BattleRelic
            {
                Id = relic.Id,
                Level = 15,
                MainAffixId = relic.MainAffix
            };

            foreach (var subAffix in relic.SubAffixes)
            {
                proto.SubAffixList.Add(subAffix);
            }

            return proto;
        }

        public class SubAffix(uint id, uint step)
        {
            public uint Id { get; set; } = id;
            public uint Step { get; set; } = step;

            public static implicit operator RelicAffix(SubAffix affix)
            {
                Log.Debug("Converting relic sub affix {Id} to RelicAffix...", affix.Id);

                return new RelicAffix
                {
                    AffixId = affix.Id,
                    Step = affix.Step,
                    Cnt = 1
                };
            }
        }
    }
}
