using CosmicCore.Protos;
using CosmicCore.Server.Gate.Manager.Handlers.Core;
using CosmicCore.Server.Gate.Network;
using CosmicCore.Server.Utilities;

namespace CosmicCore.Server.Gate.Manager.Handlers;

public class BattleReqGroup
{
    public static readonly Dictionary<int, AvatarUtil.Weapon> Weapons = new()
    {
        { 1308, new AvatarUtil.Weapon(23024, 5) },
        { 1307, new AvatarUtil.Weapon(23022, 5) },
        { 1006, new AvatarUtil.Weapon(23007, 5) },
        { 1304, new AvatarUtil.Weapon(23023, 5) }
    };

    public static readonly Dictionary<int, List<BattleRelic>> Relics = new()
    {
        {
            1006, [
                new BattleRelic(id: 61141, level: 15, mainAffixId: 1)
                {
                    SubAffixList =
                    {
                        new RelicAffix(affixId: 5, step: 1),
                        new RelicAffix(affixId: 7, step: 2),
                        new RelicAffix(affixId: 10, step: 2),
                        new RelicAffix(affixId: 12, step: 2)
                    }
                },
                new BattleRelic(id: 61142, level: 15, mainAffixId: 1)
                {
                    SubAffixList =
                    {
                        new RelicAffix(affixId: 5, step: 2),
                        new RelicAffix(affixId: 7, step: 6),
                        new RelicAffix(affixId: 8, step: 8),
                        new RelicAffix(affixId: 9, step: 4)
                    }
                },
                new BattleRelic(id: 61113, level: 15, mainAffixId: 7)
                {
                    SubAffixList =
                    {
                        new RelicAffix(affixId: 5, step: 4),
                        new RelicAffix(affixId: 7, step: 6),
                        new RelicAffix(affixId: 8, step: 4),
                        new RelicAffix(affixId: 9, step: 4)
                    }
                },
                new BattleRelic(id: 61114, level: 15, mainAffixId: 4)
                {
                    SubAffixList =
                    {
                        new RelicAffix(affixId: 5, step: 4),
                        new RelicAffix(affixId: 10, step: 6),
                        new RelicAffix(affixId: 11, step: 4),
                        new RelicAffix(affixId: 12, step: 2)
                    }
                },
                new BattleRelic(id: 63085, level: 15, mainAffixId: 2)
                {
                    SubAffixList =
                    {
                        new RelicAffix(affixId: 1, step: 4),
                        new RelicAffix(affixId: 7, step: 6),
                        new RelicAffix(affixId: 11, step: 4),
                        new RelicAffix(affixId: 12, step: 4)
                    }
                },
                new BattleRelic(id: 63086, level: 15, mainAffixId: 9)
                {
                    SubAffixList =
                    {
                        new RelicAffix(affixId: 5, step: 6),
                        new RelicAffix(affixId: 7, step: 6),
                        new RelicAffix(affixId: 10, step: 6),
                        new RelicAffix(affixId: 11, step: 4)
                    }
                }
            ]
        },
        {
            1308, [
                new BattleRelic(id: 61171, level: 15, mainAffixId: 1)
                {
                    SubAffixList =
                    {
                        new RelicAffix(affixId: 5, step: 2),
                        new RelicAffix(affixId: 7, step: 2),
                        new RelicAffix(affixId: 8, step: 4),
                        new RelicAffix(affixId: 9, step: 4)
                    }
                },
                new BattleRelic(id: 61172, level: 15, mainAffixId: 1)
                {
                    SubAffixList =
                    {
                        new RelicAffix(affixId: 5, step: 2),
                        new RelicAffix(affixId: 7, step: 4),
                        new RelicAffix(affixId: 8, step: 4),
                        new RelicAffix(affixId: 9, step: 8),
                        new RelicAffix(affixId: 12, step: 4)
                    }
                },
                new BattleRelic(id: 61173, level: 15, mainAffixId: 5)
                {
                    SubAffixList =
                    {
                        new RelicAffix(affixId: 5, step: 2),
                        new RelicAffix(affixId: 7, step: 2),
                        new RelicAffix(affixId: 8, step: 6),
                        new RelicAffix(affixId: 12, step: 4)
                    }
                },
                new BattleRelic(id: 61174, level: 15, mainAffixId: 2)
                {
                    SubAffixList =
                    {
                        new RelicAffix(affixId: 8, step: 2),
                        new RelicAffix(affixId: 9, step: 2),
                        new RelicAffix(affixId: 12, step: 1),
                        new RelicAffix(affixId: 7, step: 2)
                    }
                },
                new BattleRelic(id: 63145, level: 15, mainAffixId: 2)
                {
                    SubAffixList =
                    {
                        new RelicAffix(affixId: 5, step: 3),
                        new RelicAffix(affixId: 7, step: 2),
                        new RelicAffix(affixId: 8, step: 2),
                        new RelicAffix(affixId: 9, step: 2)
                    }
                },
                new BattleRelic(id: 63146, level: 15, mainAffixId: 4)
                {
                    SubAffixList =
                    {
                        new RelicAffix(affixId: 7, step: 3),
                        new RelicAffix(affixId: 8, step: 2),
                        new RelicAffix(affixId: 9, step: 2),
                        new RelicAffix(affixId: 12, step: 1)
                    }
                }
            ]
        },
        {
            1304, [
                new BattleRelic(id: 61031, level: 15, mainAffixId: 1)
                {
                    SubAffixList =
                    {
                        new RelicAffix(affixId: 6, step: 8),
                        new RelicAffix(affixId: 7, step: 4),
                        new RelicAffix(affixId: 3, step: 6),
                        new RelicAffix(affixId: 5, step: 2)
                    }
                },
                new BattleRelic(id: 61032, level: 15, mainAffixId: 1)
                {
                    SubAffixList =
                    {
                        new RelicAffix(affixId: 7, step: 4),
                        new RelicAffix(affixId: 11, step: 4),
                        new RelicAffix(affixId: 6, step: 1),
                        new RelicAffix(affixId: 5, step: 2)
                    }
                },
                new BattleRelic(id: 61033, level: 15, mainAffixId: 3)
                {
                    SubAffixList =
                    {
                        new RelicAffix(affixId: 3, step: 6),
                        new RelicAffix(affixId: 7, step: 8),
                        new RelicAffix(affixId: 11, step: 4),
                        new RelicAffix(affixId: 4, step: 4)
                    }
                },
                new BattleRelic(id: 61034, level: 15, mainAffixId: 3)
                {
                    SubAffixList =
                    {
                        new RelicAffix(affixId: 6, step: 8),
                        new RelicAffix(affixId: 7, step: 6),
                        new RelicAffix(affixId: 3, step: 4),
                        new RelicAffix(affixId: 5, step: 4)
                    }
                },
                new BattleRelic(id: 63105, level: 15, mainAffixId: 3)
                {
                    SubAffixList =
                    {
                        new RelicAffix(affixId: 11, step: 4),
                        new RelicAffix(affixId: 1, step: 6),
                        new RelicAffix(affixId: 6, step: 8),
                        new RelicAffix(affixId: 7, step: 6)
                    }
                },
                new BattleRelic(id: 63106, level: 15, mainAffixId: 5)
                {
                    SubAffixList =
                    {
                        new RelicAffix(affixId: 7, step: 6),
                        new RelicAffix(affixId: 11, step: 4),
                        new RelicAffix(affixId: 6, step: 6),
                        new RelicAffix(affixId: 3, step: 4)
                    }
                }
            ]
        },
        {
            1307, [
                new BattleRelic(id: 61161, level: 15, mainAffixId: 1)
                {
                    SubAffixList =
                    {
                        new RelicAffix(affixId: 4, step: 2),
                        new RelicAffix(affixId: 5, step: 6),
                        new RelicAffix(affixId: 10, step: 8),
                        new RelicAffix(affixId: 12, step: 2)
                    }
                },
                new BattleRelic(id: 61162, level: 15, mainAffixId: 1)
                {
                    SubAffixList =
                    {
                        new RelicAffix(affixId: 4, step: 2),
                        new RelicAffix(affixId: 5, step: 8),
                        new RelicAffix(affixId: 7, step: 6),
                        new RelicAffix(affixId: 12, step: 2)
                    }
                },
                new BattleRelic(id: 61163, level: 15, mainAffixId: 7)
                {
                    SubAffixList =
                    {
                        new RelicAffix(affixId: 4, step: 2),
                        new RelicAffix(affixId: 7, step: 8),
                        new RelicAffix(affixId: 5, step: 2),
                        new RelicAffix(affixId: 12, step: 6)
                    }
                },
                new BattleRelic(id: 61164, level: 15, mainAffixId: 4)
                {
                    SubAffixList =
                    {
                        new RelicAffix(affixId: 4, step: 2),
                        new RelicAffix(affixId: 5, step: 8),
                        new RelicAffix(affixId: 10, step: 2),
                        new RelicAffix(affixId: 12, step: 6)
                    }
                },
                new BattleRelic(id: 63035, level: 15, mainAffixId: 8)
                {
                    SubAffixList =
                    {
                        new RelicAffix(affixId: 5, step: 8),
                        new RelicAffix(affixId: 7, step: 6),
                        new RelicAffix(affixId: 10, step: 2),
                        new RelicAffix(affixId: 12, step: 2)
                    }
                },
                new BattleRelic(id: 63036, level: 15, mainAffixId: 4)
                {
                    SubAffixList =
                    {
                        new RelicAffix(affixId: 4, step: 2),
                        new RelicAffix(affixId: 7, step: 8),
                        new RelicAffix(affixId: 10, step: 2),
                        new RelicAffix(affixId: 12, step: 6)
                    }
                }
            ]
        }
    };

    public static AvatarUtil.Avatar[] Avatars =
    [
        new AvatarUtil.Avatar(1308, 6, Weapons[1308], Relics[1308]), // acheron
        new AvatarUtil.Avatar(1307, 6, Weapons[1307], Relics[1307]), // black swan
        new AvatarUtil.Avatar(1006, 6, Weapons[1006], Relics[1006]), // silver wolf
        new AvatarUtil.Avatar(1304, 6, Weapons[1304], Relics[1304]) // aventurine
    ];

    public static Dictionary<uint, List<uint>> Monsters = new()
    {
        { 1, [3013010, 3012010, 3013010] },
        { 2, [8034010] },
        { 3, [3014022] }
    };

    public static Dictionary<uint, uint> MonsterLevels = new()
    {
        { 1, 80 }, { 2, 80 }, { 3, 90 }
    };

    [PacketHandler(CmdId.CmdSetLineupNameCsReq)]
    public static void OnSetLineupNameCsReq(NetSession session, int cmdId, object data)
    {
        var request = data as SetLineupNameCsReq;

        if (request.Name == "battle")
        {
            var lineupInfo = new LineupInfo
            {
                ExtraLineupType = ExtraLineupType.LineupNone,
                Name = "Squad 1",
                Mp = 5,
                MaxMp = 5,
                LeaderSlot = 0
            };

            foreach (var avatar in Avatars.Where(avatar => avatar.Id != 0))
            {
                lineupInfo.AvatarList.Add(avatar.ToLineupAvatar(lineupInfo.AvatarList.Count));
            }

            var sceneInfo = new SceneInfo
            {
                GameModeType = 2,
                EntryId = 2010101,
                PlaneId = 20101,
                FloorId = 20101001
            };

            var motionInfo = new MotionInfo
            {
                Pos = new Vector
                {
                    X = -570,
                    Y = 19364,
                    Z = 4480
                },
                Rot = new Vector
                {
                    Y = 180000
                }
            };

            var calaxInfo = new SceneEntityInfo
            {
                GroupId = 19,
                InstId = 300001,
                EntityId = 4194583,
                Prop = new ScenePropInfo
                {
                    PropId = 808,
                    PropState = 1
                },
                Motion = motionInfo
            };

            sceneInfo.EntityList.Add(calaxInfo);

            session.Send(CmdId.CmdEnterSceneByServerScNotify, new EnterSceneByServerScNotify
            {
                Scene = sceneInfo,
                Lineup = lineupInfo
            });

            session.Send(CmdId.CmdSceneEntityMoveScNotify, new SceneEntityMoveScNotify
            {
                EntryId = 2010101,
                EntityId = 0,
                Motion = motionInfo
            });
        }

        session.Send(CmdId.CmdSetLineupNameScRsp, new SetLineupNameScRsp
        {
            Retcode = 0,
            Name = request.Name,
            Index = request.Index
        });
    }


    [PacketHandler(CmdId.CmdStartCocoonStageCsReq)]
    public static void OnStartCocoonStageCsReq(NetSession session, int cmdId, object data)
    {
        var request = data as StartCocoonStageCsReq;

        // basic
        var response = new StartCocoonStageScRsp
        {
            Retcode = 0,
            CocoonId = request.CocoonId,
            Wave = request.Wave,
            PropEntityId = request.PropEntityId,
            BattleInfo = new SceneBattleInfo
            {
                StageId = 201012311,
                LogicRandomSeed = (uint)RandomUtil.FromIntRange(1, short.MaxValue),
                WorldLevel = 6
            }
        };

        // avatars
        for (var index = 0; index < Avatars.Length; index++)
        {
            var avatar = Avatars[index];
            response.BattleInfo.BattleAvatarList.Add(avatar.ToBattleAvatar(index));
        }

        // monsters
        for (var waveId = 1u; waveId <= Monsters.Count; waveId++)
        {
            var monsterInfo = new SceneMonsterWave
            {
                WaveId = waveId,
                MonsterParam = new SceneMonsterParam(MonsterLevels[waveId])
            };

            foreach (var monsterId in Monsters[waveId])
            {
                monsterInfo.MonsterList.Add(new SceneMonsterInfo(monsterId));
            }

            response.BattleInfo.MonsterWaveList.Add(monsterInfo);
        }

        session.Send(CmdId.CmdStartCocoonStageScRsp, response);
    }

    [PacketHandler(CmdId.CmdPVEBattleResultCsReq)]
    public static void OnPVEBattleResultCsReq(NetSession session, int cmdId, object data)
    {
        var request = data as PVEBattleResultCsReq;
        session.Send(CmdId.CmdPVEBattleResultScRsp, new PVEBattleResultScRsp
        {
            Retcode = 0,
            EndStatus = request.EndStatus
        });
    }

    #region failure

    // public static readonly Dictionary<int, List<AvatarUtil.Relic>> Relics = new()
    // {
    //     {
    //         1006, [
    //             new AvatarUtil.Relic(61141, 1, [
    //                 new AvatarUtil.Relic.SubAffix(10, 20),
    //                 new AvatarUtil.Relic.SubAffix(12, 20),
    //                 new AvatarUtil.Relic.SubAffix(7, 40),
    //                 new AvatarUtil.Relic.SubAffix(5, 10)
    //             ]),
    //
    //             new AvatarUtil.Relic(61113, 7, [
    //                 new AvatarUtil.Relic.SubAffix(12, 20),
    //                 new AvatarUtil.Relic.SubAffix(7, 30),
    //                 new AvatarUtil.Relic.SubAffix(11, 20),
    //                 new AvatarUtil.Relic.SubAffix(5, 20)
    //             ]),
    //             new AvatarUtil.Relic(61142, 1, [
    //                 new AvatarUtil.Relic.SubAffix(11, 20),
    //                 new AvatarUtil.Relic.SubAffix(10, 40),
    //                 new AvatarUtil.Relic.SubAffix(7, 30),
    //                 new AvatarUtil.Relic.SubAffix(5, 10)
    //             ]),
    //
    //             new AvatarUtil.Relic(61114, 4, [
    //                 new AvatarUtil.Relic.SubAffix(11, 20),
    //                 new AvatarUtil.Relic.SubAffix(10, 30),
    //                 new AvatarUtil.Relic.SubAffix(12, 10),
    //                 new AvatarUtil.Relic.SubAffix(5, 20)
    //             ]),
    //
    //             new AvatarUtil.Relic(63085, 9, [
    //                 new AvatarUtil.Relic.SubAffix(11, 20),
    //                 new AvatarUtil.Relic.SubAffix(10, 300),
    //                 new AvatarUtil.Relic.SubAffix(7, 30),
    //                 new AvatarUtil.Relic.SubAffix(5, 30)
    //             ]),
    //             new AvatarUtil.Relic(63086, 2, [
    //                 new AvatarUtil.Relic.SubAffix(1, 20),
    //                 new AvatarUtil.Relic.SubAffix(11, 20),
    //                 new AvatarUtil.Relic.SubAffix(7, 30),
    //                 new AvatarUtil.Relic.SubAffix(12, 20)
    //             ])
    //         ]
    //     },
    //     {
    //         1308, [
    //             new AvatarUtil.Relic(61171, 1, [
    //                 new AvatarUtil.Relic.SubAffix(8, 20),
    //                 new AvatarUtil.Relic.SubAffix(9, 20),
    //                 new AvatarUtil.Relic.SubAffix(7, 10),
    //                 new AvatarUtil.Relic.SubAffix(5, 10)
    //             ]),
    //             new AvatarUtil.Relic(61173, 5, [
    //                 new AvatarUtil.Relic.SubAffix(8, 30),
    //                 new AvatarUtil.Relic.SubAffix(12, 20),
    //                 new AvatarUtil.Relic.SubAffix(7, 10),
    //                 new AvatarUtil.Relic.SubAffix(5, 10)
    //             ]),
    //
    //             new AvatarUtil.Relic(61172, 1, [
    //                 new AvatarUtil.Relic.SubAffix(8, 20),
    //                 new AvatarUtil.Relic.SubAffix(9, 40),
    //                 new AvatarUtil.Relic.SubAffix(7, 20),
    //                 new AvatarUtil.Relic.SubAffix(5, 10)
    //             ]),
    //
    //             new AvatarUtil.Relic(61174, 2, [
    //                 new AvatarUtil.Relic.SubAffix(8, 20),
    //                 new AvatarUtil.Relic.SubAffix(9, 20),
    //                 new AvatarUtil.Relic.SubAffix(12, 10),
    //                 new AvatarUtil.Relic.SubAffix(7, 20)
    //             ]),
    //
    //             new AvatarUtil.Relic(63145, 2, [
    //                 new AvatarUtil.Relic.SubAffix(8, 20),
    //                 new AvatarUtil.Relic.SubAffix(9, 20),
    //                 new AvatarUtil.Relic.SubAffix(7, 20),
    //                 new AvatarUtil.Relic.SubAffix(5, 30)
    //             ]),
    //
    //             new AvatarUtil.Relic(63146, 4, [
    //                 new AvatarUtil.Relic.SubAffix(8, 20),
    //                 new AvatarUtil.Relic.SubAffix(9, 20),
    //                 new AvatarUtil.Relic.SubAffix(7, 30),
    //                 new AvatarUtil.Relic.SubAffix(12, 10)
    //             ])
    //         ]
    //     },
    //     {
    //         1304, [
    //             new AvatarUtil.Relic(61031, 1, [
    //                 new AvatarUtil.Relic.SubAffix(6, 40),
    //                 new AvatarUtil.Relic.SubAffix(7, 20),
    //                 new AvatarUtil.Relic.SubAffix(3, 30),
    //                 new AvatarUtil.Relic.SubAffix(5, 10)
    //             ]),
    //
    //             new AvatarUtil.Relic(61033, 3, [
    //                 new AvatarUtil.Relic.SubAffix(3, 30),
    //                 new AvatarUtil.Relic.SubAffix(7, 40),
    //                 new AvatarUtil.Relic.SubAffix(11, 20),
    //                 new AvatarUtil.Relic.SubAffix(4, 20)
    //             ]),
    //
    //             new AvatarUtil.Relic(61032, 1, [
    //                 new AvatarUtil.Relic.SubAffix(7, 20),
    //                 new AvatarUtil.Relic.SubAffix(11, 20),
    //                 new AvatarUtil.Relic.SubAffix(6, 50),
    //                 new AvatarUtil.Relic.SubAffix(5, 10)
    //             ]),
    //             new AvatarUtil.Relic(61034, 3, [
    //                 new AvatarUtil.Relic.SubAffix(6, 40),
    //                 new AvatarUtil.Relic.SubAffix(7, 30),
    //                 new AvatarUtil.Relic.SubAffix(3, 20),
    //                 new AvatarUtil.Relic.SubAffix(5, 20)
    //             ]),
    //
    //             new AvatarUtil.Relic(63105, 3, [
    //                 new AvatarUtil.Relic.SubAffix(11, 20),
    //                 new AvatarUtil.Relic.SubAffix(1, 30),
    //                 new AvatarUtil.Relic.SubAffix(6, 40),
    //                 new AvatarUtil.Relic.SubAffix(7, 30)
    //             ]),
    //
    //             new AvatarUtil.Relic(63106, 5, [
    //                 new AvatarUtil.Relic.SubAffix(7, 30),
    //                 new AvatarUtil.Relic.SubAffix(11, 20),
    //                 new AvatarUtil.Relic.SubAffix(6, 30),
    //                 new AvatarUtil.Relic.SubAffix(3, 20)
    //             ])
    //         ]
    //     },
    //     {
    //         1307, [
    //             new AvatarUtil.Relic(61164, 4, [
    //                 new AvatarUtil.Relic.SubAffix(4, 1),
    //                 new AvatarUtil.Relic.SubAffix(5, 4),
    //                 new AvatarUtil.Relic.SubAffix(10, 1),
    //                 new AvatarUtil.Relic.SubAffix(12, 3)
    //             ]),
    //             new AvatarUtil.Relic(61163, 7, [
    //                 new AvatarUtil.Relic.SubAffix(4, 1),
    //                 new AvatarUtil.Relic.SubAffix(7, 4),
    //                 new AvatarUtil.Relic.SubAffix(5, 1),
    //                 new AvatarUtil.Relic.SubAffix(12, 3)
    //             ]),
    //             new AvatarUtil.Relic(61162, 1, [
    //                 new AvatarUtil.Relic.SubAffix(4, 1),
    //                 new AvatarUtil.Relic.SubAffix(5, 4),
    //                 new AvatarUtil.Relic.SubAffix(7, 3),
    //                 new AvatarUtil.Relic.SubAffix(12, 1)
    //             ]),
    //             new AvatarUtil.Relic(61161, 1, [
    //                 new AvatarUtil.Relic.SubAffix(4, 1),
    //                 new AvatarUtil.Relic.SubAffix(5, 3),
    //                 new AvatarUtil.Relic.SubAffix(10, 4),
    //                 new AvatarUtil.Relic.SubAffix(12, 1)
    //             ]),
    //             new AvatarUtil.Relic(63035, 4, [
    //                 new AvatarUtil.Relic.SubAffix(4, 1),
    //                 new AvatarUtil.Relic.SubAffix(7, 4),
    //                 new AvatarUtil.Relic.SubAffix(10, 1),
    //                 new AvatarUtil.Relic.SubAffix(12, 3)
    //             ]),
    //             new AvatarUtil.Relic(63036, 8, [
    //                 new AvatarUtil.Relic.SubAffix(5, 4),
    //                 new AvatarUtil.Relic.SubAffix(7, 3),
    //                 new AvatarUtil.Relic.SubAffix(10, 1),
    //                 new AvatarUtil.Relic.SubAffix(12, 1)
    //             ])
    //         ]
    //     }
    // };

    #endregion
}
