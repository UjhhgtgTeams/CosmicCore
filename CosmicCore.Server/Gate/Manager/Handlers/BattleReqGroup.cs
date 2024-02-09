using CosmicCore.Server.Gate.Manager.Handlers.Core;
using CosmicCore.Server.Gate.Network;
using CosmicCore.Server.Utilities;
using CosmicCore.Protos;
using CosmicCore.Server.Dispatch.Utils;
using static CosmicCore.Server.Utilities.Avatar.DefaultAvatarConst;

namespace CosmicCore.Server.Gate.Manager.Handlers;

internal static class BattleReqGroup
{
    [Handler(CmdId.CmdSetLineupNameCsReq)]
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
            var characters = new List<uint> { Avatar1, Avatar2, Avatar3, Avatar4 }; // hardcode
            foreach (var id in characters.Where(id => id != 0))
                lineupInfo.AvatarLists.Add(new LineupAvatar
                {
                    Id = id,
                    Hp = 10000,
                    Satiety = 100,
                    SpBar = new SpBarInfo { CurSp = 10000, MaxSp = 10000 },
                    AvatarType = AvatarType.AvatarFormalType,
                    Slot = (uint)lineupInfo.AvatarLists.Count
                });

            var sceneInfo = new SceneInfo
            {
                GameModeType = 2,
                EntryId = 2010101,
                PlaneId = 20101,
                FloorId = 20101001
            };

            var calaxInfoTest = new SceneEntityInfo
            {
                GroupId = 19,
                InstId = 300001,
                EntityId = 4194583,
                Prop = new ScenePropInfo
                {
                    PropState = 1, // FIXME: not sure if correct
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

            sceneInfo.EntityLists.Add(calaxInfoTest);

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
            Retcode = (uint)Retcode.Success,
            Name = request.Name,
            Index = request.Index
        });
    }


    [Handler(CmdId.CmdStartCocoonStageCsReq)]
    public static void OnStartCocoonStageCsReq(NetSession session, int cmdId, object data)
    {
        var request = data as StartCocoonStageCsReq;

        var monsterIds = new Dictionary<uint, List<uint>>
        {
            { 1, new List<uint> { 3001010, 3001020, 3001020, 3001010 } },
            { 2, new List<uint> { 3002030, 3002010, 3002010, 3002030 } },
            { 3, new List<uint> { 3011010, 3012020, 3011010 } },
            { 4, new List<uint> { 3003010, 3003020 } },
            { 5, new List<uint> { 3024020 } },
            { 6, new List<uint> { 3014020 } },
            { 7, new List<uint> { 3002050 } }
        };

        var monsterLevels = new Dictionary<uint, uint>
        {
            { 1, 70 }, { 2, 70 }, { 3, 60 }, { 4, 65 }, { 5, 55 }, { 6, 60 }, { 7, 75 }
        };

        //basic
        var battleInfo = new SceneBattleInfo
        {
            StageId = 201012311,
            LogicRandomSeed = 639771447,
            WorldLevel = 6
        };

        var testRelic = new BattleRelic
        {
            Id = 61011,
            Level = 999,
            MainAffixId = 1,
            SubAffixLists =
            {
                new RelicAffix
                {
                    AffixId = 4,
                    Step = 999
                }
            }
        };

        //avatar
        var SkillIdEnds = new List<uint>
            { 1, 2, 3, 4, 7, 101, 102, 103, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210 };
        var characters = new List<uint> { Avatar1, Avatar2, Avatar3, Avatar4 };
        foreach (var avatarId in characters)
        {
            var avatarData = new BattleAvatar
            {
                Id = avatarId,
                Level = 80,
                Promotion = 6,
                Rank = 6,
                Hp = 10000,
                AvatarType = AvatarType.AvatarFormalType,
                WorldLevel = 6,
                SpBar = new SpBarInfo { CurSp = 10000, MaxSp = 10000 },
                RelicLists = { testRelic },
                EquipmentLists =
                {
                    new BattleEquipment
                    {
                        Id = 23006,
                        Level = 80,
                        Rank = 5,
                        Promotion = 6
                    }
                }
            };

            foreach (var end in SkillIdEnds)
            {
                uint level = 1;
                if (end == 1) level = 6;
                else if (end < 4 || end == 4) level = 10;
                if (end > 4) level = 1;
                avatarData.SkilltreeLists.Add(new AvatarSkillTree
                {
                    PointId = avatarId * 1000 + end,
                    Level = level
                });
            }

            battleInfo.BattleAvatarLists.Add(avatarData);
        }

        // monster
        for (uint i = 1; i <= 7; i++)
        {
            var monsterInfo = new SceneMonsterWave
            {
                WaveId = i, // FIXME: not sure if correct
                WaveParam = new SceneMonsterWaveParam
                {
                    Level = monsterLevels[i]
                }
            };

            if (monsterIds.TryGetValue(i, out var monsterIdList))
                foreach (var monsterId in monsterIdList)
                    monsterInfo.MonsterLists.Add(new SceneMonster
                    {
                        MonsterId = monsterId
                    });
            battleInfo.MonsterWaveLists.Add(monsterInfo);
        }

        var response = new StartCocoonStageScRsp
        {
            Retcode = (uint)Retcode.Success,
            CocoonId = request.CocoonId,
            Wave = request.Wave,
            PropEntityId = request.PropEntityId,
            BattleInfo = battleInfo
        };

        session.Send(CmdId.CmdStartCocoonStageScRsp, response);
    }

    [Handler(CmdId.CmdPVEBattleResultCsReq)]
    public static void OnPVEBattleResultCsReq(NetSession session, int cmdId, object data)
    {
        var request = data as PVEBattleResultCsReq;
        session.Send(CmdId.CmdPVEBattleResultScRsp, new PVEBattleResultScRsp
        {
            Retcode = (uint)Retcode.Success,
            EndStatus = request.EndStatus
        });
    }
}
