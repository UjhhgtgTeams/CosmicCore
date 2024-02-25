using CosmicCore.Protos;
using CosmicCore.Server.Gate.Manager.Handlers.Core;
using CosmicCore.Server.Gate.Network;
using Serilog;

namespace CosmicCore.Server.Gate.Manager.Handlers;

public class BattleReqGroup
{
    public static readonly Dictionary<uint, List<AvatarUtil.Relic>> Relics = new()
    {
        {
            1006, [
                new AvatarUtil.Relic(31141, 1, [
                    new AvatarUtil.Relic.SubAffix(10, 20),
                    new AvatarUtil.Relic.SubAffix(12, 20),
                    new AvatarUtil.Relic.SubAffix(7, 40),
                    new AvatarUtil.Relic.SubAffix(5, 10)
                ]),

                new AvatarUtil.Relic(31113, 7, [
                    new AvatarUtil.Relic.SubAffix(12, 20),
                    new AvatarUtil.Relic.SubAffix(7, 30),
                    new AvatarUtil.Relic.SubAffix(11, 20),
                    new AvatarUtil.Relic.SubAffix(5, 20)
                ]),
                new AvatarUtil.Relic(31142, 1, [
                    new AvatarUtil.Relic.SubAffix(11, 20),
                    new AvatarUtil.Relic.SubAffix(10, 40),
                    new AvatarUtil.Relic.SubAffix(7, 30),
                    new AvatarUtil.Relic.SubAffix(5, 10)
                ]),

                new AvatarUtil.Relic(31114, 4, [
                    new AvatarUtil.Relic.SubAffix(11, 20),
                    new AvatarUtil.Relic.SubAffix(10, 30),
                    new AvatarUtil.Relic.SubAffix(12, 10),
                    new AvatarUtil.Relic.SubAffix(5, 20)
                ]),

                new AvatarUtil.Relic(63085, 9, [
                    new AvatarUtil.Relic.SubAffix(11, 20),
                    new AvatarUtil.Relic.SubAffix(10, 300),
                    new AvatarUtil.Relic.SubAffix(7, 30),
                    new AvatarUtil.Relic.SubAffix(5, 30)
                ]),
                new AvatarUtil.Relic(63086, 2, [
                    new AvatarUtil.Relic.SubAffix(1, 20),
                    new AvatarUtil.Relic.SubAffix(11, 20),
                    new AvatarUtil.Relic.SubAffix(7, 30),
                    new AvatarUtil.Relic.SubAffix(12, 20)
                ])
            ]
        },
        {
            1308, [
                new AvatarUtil.Relic(61171, 1, [
                    new AvatarUtil.Relic.SubAffix(8, 20),
                    new AvatarUtil.Relic.SubAffix(9, 20),
                    new AvatarUtil.Relic.SubAffix(7, 10),
                    new AvatarUtil.Relic.SubAffix(5, 10)
                ]),
                new AvatarUtil.Relic(61173, 5, [
                    new AvatarUtil.Relic.SubAffix(8, 30),
                    new AvatarUtil.Relic.SubAffix(12, 20),
                    new AvatarUtil.Relic.SubAffix(7, 10),
                    new AvatarUtil.Relic.SubAffix(5, 10)
                ]),

                new AvatarUtil.Relic(61172, 1, [
                    new AvatarUtil.Relic.SubAffix(8, 20),
                    new AvatarUtil.Relic.SubAffix(9, 40),
                    new AvatarUtil.Relic.SubAffix(7, 20),
                    new AvatarUtil.Relic.SubAffix(5, 10)
                ]),

                new AvatarUtil.Relic(61174, 2, [
                    new AvatarUtil.Relic.SubAffix(8, 20),
                    new AvatarUtil.Relic.SubAffix(9, 20),
                    new AvatarUtil.Relic.SubAffix(12, 10),
                    new AvatarUtil.Relic.SubAffix(7, 20)
                ]),

                new AvatarUtil.Relic(63145, 2, [
                    new AvatarUtil.Relic.SubAffix(8, 20),
                    new AvatarUtil.Relic.SubAffix(9, 20),
                    new AvatarUtil.Relic.SubAffix(7, 20),
                    new AvatarUtil.Relic.SubAffix(5, 30)
                ]),

                new AvatarUtil.Relic(63146, 4, [
                    new AvatarUtil.Relic.SubAffix(8, 20),
                    new AvatarUtil.Relic.SubAffix(9, 20),
                    new AvatarUtil.Relic.SubAffix(7, 30),
                    new AvatarUtil.Relic.SubAffix(12, 10)
                ])
            ]
        },
        {
            1304, [
                new AvatarUtil.Relic(61031, 1, [
                    new AvatarUtil.Relic.SubAffix(6, 40),
                    new AvatarUtil.Relic.SubAffix(7, 20),
                    new AvatarUtil.Relic.SubAffix(3, 30),
                    new AvatarUtil.Relic.SubAffix(5, 10)
                ]),

                new AvatarUtil.Relic(61033, 3, [
                    new AvatarUtil.Relic.SubAffix(3, 30),
                    new AvatarUtil.Relic.SubAffix(7, 40),
                    new AvatarUtil.Relic.SubAffix(11, 20),
                    new AvatarUtil.Relic.SubAffix(4, 20)
                ]),

                new AvatarUtil.Relic(61032, 1, [
                    new AvatarUtil.Relic.SubAffix(7, 20),
                    new AvatarUtil.Relic.SubAffix(11, 20),
                    new AvatarUtil.Relic.SubAffix(6, 50),
                    new AvatarUtil.Relic.SubAffix(5, 10)
                ]),
                new AvatarUtil.Relic(61034, 3, [
                    new AvatarUtil.Relic.SubAffix(6, 40),
                    new AvatarUtil.Relic.SubAffix(7, 30),
                    new AvatarUtil.Relic.SubAffix(3, 20),
                    new AvatarUtil.Relic.SubAffix(5, 20)
                ]),

                new AvatarUtil.Relic(63105, 3, [
                    new AvatarUtil.Relic.SubAffix(11, 20),
                    new AvatarUtil.Relic.SubAffix(1, 30),
                    new AvatarUtil.Relic.SubAffix(6, 40),
                    new AvatarUtil.Relic.SubAffix(7, 30)
                ]),

                new AvatarUtil.Relic(63106, 5, [
                    new AvatarUtil.Relic.SubAffix(7, 30),
                    new AvatarUtil.Relic.SubAffix(11, 20),
                    new AvatarUtil.Relic.SubAffix(6, 30),
                    new AvatarUtil.Relic.SubAffix(3, 20)
                ])
            ]
        },
        {
            1307, [
                new AvatarUtil.Relic(61164, 4, [
                    new AvatarUtil.Relic.SubAffix(4, 1),
                    new AvatarUtil.Relic.SubAffix(5, 4),
                    new AvatarUtil.Relic.SubAffix(10, 1),
                    new AvatarUtil.Relic.SubAffix(12, 3)
                ]),
                new AvatarUtil.Relic(61163, 7, [
                    new AvatarUtil.Relic.SubAffix(4, 1),
                    new AvatarUtil.Relic.SubAffix(7, 4),
                    new AvatarUtil.Relic.SubAffix(5, 1),
                    new AvatarUtil.Relic.SubAffix(12, 3)
                ]),
                new AvatarUtil.Relic(61162, 1, [
                    new AvatarUtil.Relic.SubAffix(4, 1),
                    new AvatarUtil.Relic.SubAffix(5, 4),
                    new AvatarUtil.Relic.SubAffix(7, 3),
                    new AvatarUtil.Relic.SubAffix(12, 1)
                ]),
                new AvatarUtil.Relic(61161, 1, [
                    new AvatarUtil.Relic.SubAffix(4, 1),
                    new AvatarUtil.Relic.SubAffix(5, 3),
                    new AvatarUtil.Relic.SubAffix(10, 4),
                    new AvatarUtil.Relic.SubAffix(12, 1)
                ]),
                new AvatarUtil.Relic(63036, 4, [
                    new AvatarUtil.Relic.SubAffix(4, 1),
                    new AvatarUtil.Relic.SubAffix(7, 4),
                    new AvatarUtil.Relic.SubAffix(10, 1),
                    new AvatarUtil.Relic.SubAffix(12, 3)
                ]),
                new AvatarUtil.Relic(63036, 8, [
                    new AvatarUtil.Relic.SubAffix(5, 4),
                    new AvatarUtil.Relic.SubAffix(7, 3),
                    new AvatarUtil.Relic.SubAffix(10, 1),
                    new AvatarUtil.Relic.SubAffix(12, 1)
                ])
            ]
        }
    };

    public static int AvatarRank = 6;
    public static int WeaponRank = 6;

    public static AvatarUtil.Avatar Avatar1 = new(1308, 6, new AvatarUtil.Weapon(23024, 6), Relics[1308]); // acheron
    public static AvatarUtil.Avatar Avatar2 = new(1307, 6, new AvatarUtil.Weapon(23022, 6), Relics[1307]); // black swan

    public static AvatarUtil.Avatar
        Avatar3 = new(1006, 6, new AvatarUtil.Weapon(23007, 6), Relics[1006]); // silver wolf

    public static AvatarUtil.Avatar Avatar4 = new(1304, 6, new AvatarUtil.Weapon(23023, 6), Relics[1304]); // aventurine

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

            var avatars = new List<AvatarUtil.Avatar> { Avatar1, Avatar2, Avatar3, Avatar4 };
            foreach (var avatar in avatars.Where(avatar => avatar.Id != 0))
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

            var calaxInfo = new SceneEntityInfo
            {
                GroupId = 19,
                InstId = 300001,
                EntityId = 4194583,
                Prop = new ScenePropInfo
                {
                    PropState = 1,
                    PropId = 808
                },
                Motion = new MotionInfo
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
                }
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
                Motion = new MotionInfo
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
                }
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
        var battleInfo = new SceneBattleInfo
        {
            StageId = 201012311,
            LogicRandomSeed = 639771447,
            WorldLevel = 6
        };

        // avatars
        var avatars = new List<AvatarUtil.Avatar> { Avatar1, Avatar2, Avatar3, Avatar4 };
        foreach (var avatar in avatars)
        {
            Log.Debug("Added {@Avatar} to cocoon avatar list!", avatar);
            battleInfo.BattleAvatarList.Add(avatar);
        }

        // monsters
        for (var waveId = 1u; waveId <= Monsters.Count; waveId++)
        {
            var monsterInfo = new SceneMonsterWave
            {
                WaveId = waveId,
                MonsterParam = new SceneMonsterParam
                {
                    Level = MonsterLevels[waveId]
                }
            };

            if (Monsters.TryGetValue(waveId, out var monsterIds))
            {
                foreach (var monsterId in monsterIds)
                {
                    monsterInfo.MonsterList.Add(new SceneMonsterInfo
                    {
                        MonsterId = monsterId
                    });
                }
            }

            battleInfo.MonsterWaveList.Add(monsterInfo);
        }

        var response = new StartCocoonStageScRsp
        {
            Retcode = 0,
            CocoonId = request.CocoonId,
            Wave = request.Wave,
            PropEntityId = request.PropEntityId,
            BattleInfo = battleInfo
        };

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
}
