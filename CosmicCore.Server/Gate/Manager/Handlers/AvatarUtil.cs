using CosmicCore.Protos;
using CosmicCore.Server.Utilities;
using Serilog;

namespace CosmicCore.Server.Gate.Manager.Handlers;

public static class AvatarUtil
{
    public class Avatar(int id, int rank, Weapon? weapon, List<BattleRelic> relics)
    {
        private static readonly List<int> SkillIdEnds =
            [1, 2, 3, 4, 7, 101, 102, 103, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210];

        public int Id { get; set; } = id;
        public int Rank { get; set; } = rank;
        public Weapon? Weapon { get; set; } = weapon;
        public List<BattleRelic> Relics { get; set; } = relics;

        public static implicit operator Protos.Avatar(Avatar avatar)
        {
            Log.Verbose("Converting avatar {Id} to Avatar...", avatar.Id);

            // base
            var proto = new Protos.Avatar
            {
                BaseAvatarId = (uint)avatar.Id,
                Exp = 0,
                Level = 80,
                Promotion = 6,
                Rank = (uint)avatar.Rank,
                EquipmentUniqueId = 0,
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
                    PointId = (uint)avatar.Id * 1000 + (uint)end,
                    Level = level
                });
            }

            // relics
            // foreach (var relic in avatar.Relics)
            // {
            //     proto.EquipRelicList.Add(relic);
            // }

            return proto;
        }

        public BattleAvatar ToBattleAvatar(int slot)
        {
            Log.Verbose("Converting avatar {Id} to BattleAvatar...", Id);

            // base
            var proto = new BattleAvatar
            {
                Id = (uint)Id,
                Level = 80,
                Promotion = 6,
                Rank = (uint)Rank,
                Hp = 10000,
                AvatarType = AvatarType.AvatarFormalType,
                WorldLevel = 6,
                Index = (uint)slot,
                Sp = new AmountInfo { CurrentAmount = 10000, MaxAmount = 10000 },
                EquipmentList = { Weapon ?? new Weapon(23006, 5) }
            };

            // skills
            foreach (var end in SkillIdEnds)
            {
                var level = end switch
                {
                    1 => 6u,
                    <= 4 => 10u,
                    > 4 => 1u
                };

                proto.SkillTreeList.Add(new AvatarSkillTree
                {
                    PointId = (uint)Id * 1000 + (uint)end,
                    Level = level
                });
            }

            // relics
            foreach (var relic in Relics)
            {
                proto.RelicList.Add(relic);
            }

            if (Relics.Count != 6)
                Log.Fatal("omg {Id} has {Count} relics!!!", Id, Relics.Count);

            return proto;
            // var testProto = new BattleAvatar
            // {
            //     Id = (uint)Id,
            //     Level = 80,
            //     Promotion = 6,
            //     Rank = (uint)Rank,
            //     Hp = 10000,
            //     AvatarType = AvatarType.AvatarFormalType,
            //     WorldLevel = 6,
            //     Index = (uint)slot,
            //     Sp = new AmountInfo { CurrentAmount = 10000, MaxAmount = 10000 },
            //     EquipmentList = { Weapon ?? new Weapon(23006, 5) },
            //     RelicList =
            //     {
            //         new BattleRelic(61171, 15, 1)
            //         {
            //             SubAffixList =
            //             {
            //                 new RelicAffix(8, 2),
            //                 new RelicAffix(9, 2),
            //                 new RelicAffix(7, 1),
            //                 new RelicAffix(5, 1),
            //             }
            //         },
            //         new BattleRelic(61173, 15, 5)
            //         {
            //             SubAffixList =
            //             {
            //                 new RelicAffix(8, 3),
            //                 new RelicAffix(12, 2),
            //                 new RelicAffix(7, 1),
            //                 new RelicAffix(5, 1),
            //             }
            //         },
            //         new BattleRelic(61172, 15, 1)
            //         {
            //             SubAffixList =
            //             {
            //                 new RelicAffix(8, 2),
            //                 new RelicAffix(9, 4),
            //                 new RelicAffix(7, 2),
            //                 new RelicAffix(5, 1),
            //             }
            //         },
            //         new BattleRelic(61174, 15, 2)
            //         {
            //             SubAffixList =
            //             {
            //                 new RelicAffix(8, 2),
            //                 new RelicAffix(9, 2),
            //                 new RelicAffix(12, 1),
            //                 new RelicAffix(5, 2),
            //             }
            //         },
            //         new BattleRelic(63145, 15, 2)
            //         {
            //             SubAffixList =
            //             {
            //                 new RelicAffix(8, 2),
            //                 new RelicAffix(9, 2),
            //                 new RelicAffix(7, 2),
            //                 new RelicAffix(5, 3),
            //             }
            //         },
            //         new BattleRelic(63146, 15, 4)
            //         {
            //             SubAffixList =
            //             {
            //                 new RelicAffix(8, 2),
            //                 new RelicAffix(9, 2),
            //                 new RelicAffix(7, 3),
            //                 new RelicAffix(12, 1),
            //             }
            //         }
            //     }
            // };
            // foreach (var end in SkillIdEnds)
            // {
            //     var level = end switch
            //     {
            //         1 => 6u,
            //         <= 4 => 10u,
            //         > 4 => 1u
            //     };
            //
            //     testProto.SkillTreeList.Add(new AvatarSkillTree
            //     {
            //         PointId = (uint)Id * 1000 + (uint)end,
            //         Level = level
            //     });
            // }
            //
            // return testProto;
        }

        public LineupAvatar ToLineupAvatar(int slot)
        {
            Log.Verbose("Converting avatar {Id} to LineupAvatar at slot {Slot}...", Id, slot);

            return new LineupAvatar
            {
                Id = (uint)Id,
                Hp = 10000,
                Satiety = 100,
                Sp = new AmountInfo { CurrentAmount = 10000, MaxAmount = 10000 },
                AvatarType = AvatarType.AvatarFormalType,
                Slot = (uint)slot
            };
        }
    }

    public class Weapon(int id, int rank)
    {
        public int Id { get; set; } = id;
        public int Rank { get; set; } = rank is >= 1 and <= 5 ? rank : 5;

        // public uint UniqueId { get; } = (uint)RandomUtil.FromIntRange(0, int.MaxValue - 1);

        public static implicit operator BattleEquipment(Weapon weapon)
        {
            Log.Verbose("Converting weapon {Id} to BattleEquipment...", weapon.Id);

            return new BattleEquipment
            {
                Id = (uint)weapon.Id,
                Level = 80,
                Promotion = 6,
                Rank = (uint)weapon.Rank
            };
        }
    }

    public class Relic(int id, int mainAffixId, List<RelicAffix> subAffixes)
    {
        public int Id { get; set; } = id;
        public int MainAffix { get; set; } = mainAffixId;
        public List<RelicAffix> SubAffixes { get; set; } = subAffixes;

        // public uint UniqueId { get; } = (uint)RandomUtil.FromIntRange(0, int.MaxValue - 1);

        // public static implicit operator EquipRelic(Relic relic)
        // {
        //     Log.Verbose("Converting relic {Id} to EquipRelic...", relic.Id);
        //
        //     return new EquipRelic
        //     {
        //         // RelicUniqueId = relic.UniqueId,
        //         Slot = uint.Parse(relic.Id.ToString().Last().ToString()) // hacky way to get relic type without excels
        //     };
        // }

        public static implicit operator BattleRelic(Relic relic)
        {
            Log.Verbose("Converting relic {Id} to BattleRelic...", relic.Id);

            var proto = new BattleRelic((uint)relic.Id, 15, (uint)relic.MainAffix);
            proto.SubAffixList.AddRange(relic.SubAffixes);

            return proto;
        }

        public class SubAffix(int id, int step)
        {
            public int Id { get; set; } = id;
            public int Step { get; set; } = step;

            public static implicit operator RelicAffix(SubAffix affix)
            {
                Log.Verbose("Converting relic sub affix {Id} to RelicAffix...", affix.Id);

                return new RelicAffix
                {
                    AffixId = (uint)affix.Id,
                    Step = (uint)affix.Step * 2,
                    Cnt = (uint)affix.Step
                };
            }
        }
    }
}
