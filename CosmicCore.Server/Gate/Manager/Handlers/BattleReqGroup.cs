using CosmicCore.Server.Gate.Manager.Handlers.Core;
using CosmicCore.Server.Gate.Network;
using CosmicCore.Protos;
using Newtonsoft.Json;
using Serilog;

namespace CosmicCore.Server.Gate.Manager.Handlers;

public class BattleReqGroup
{
    public static uint Avatar1 = 1308; // acheron
    public static uint Avatar2 = 1307; // black swan
    public static uint Avatar3 = 1006; // silver wolf
    public static uint Avatar4 = 1304; // aventurine
    public static uint Weapon1 = 23024; // acheron
    public static uint Weapon2 = 23022; // black swan
    public static uint Weapon3 = 23007; // silver wolf
    public static uint Weapon4 = 23023; // aventurine

    public static uint AvatarRank = 6; // constellations
    public static uint WeaponRank = 5;

    public static Dictionary<uint, List<uint>> Monsters
    {
        get
        {
            const string path = "monsters.json";
            var relics = JsonConvert.DeserializeObject<Dictionary<uint, List<uint>>>(File.ReadAllText(path));

            if (relics is null)
                Log.Error("Cannot load monsters from {0}!", path);

            return relics ?? new Dictionary<uint, List<uint>>
            {
                { 1, [3013010, 3012010, 3013010] },
                { 2, [8034010] },
                { 3, [3014022] }
            };
        }
    }

    public static Dictionary<uint, uint> MonsterLevels
    {
        get
        {
            const string path = "monsterlevels.json";
            var relics = JsonConvert.DeserializeObject<Dictionary<uint, uint>>(File.ReadAllText(path));

            if (relics is null)
                Log.Error("Cannot load monster levels from {0}!", path);

            return relics ?? new Dictionary<uint, uint>
            {
                { 1, 70 }, { 2, 70 }, { 3, 60 }
            };
        }
    }

    public static List<List<BattleRelic>> Relics
    {
        get
        {
            const string path = "relics.json";
            var relics = JsonConvert.DeserializeObject<List<List<BattleRelic>>?>(File.ReadAllText(path));

            if (relics is null)
                Log.Error("Cannot load relics from {0}!", path);

            return relics ?? [];
        }
    }

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

            var characters = new List<uint> { Avatar1, Avatar2, Avatar3, Avatar4 };
            foreach (var id in characters)
            {
                lineupInfo.AvatarList.Add(new LineupAvatar
                {
                    Id = id,
                    Hp = 10000,
                    Satiety = 100,
                    Sp = new AmountInfo { CurAmount = 10000, MaxAmount = 10000 },
                    AvatarType = AvatarType.AvatarFormalType,
                    Slot = (uint)lineupInfo.AvatarList.Count
                });
            }

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

            sceneInfo.EntityList.Add(calaxInfoTest);

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
        var skillIdEnds = new List<uint>
            { 1, 2, 3, 4, 7, 101, 102, 103, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210 };
        var characters = new List<uint> { Avatar1, Avatar2, Avatar3, Avatar4 };
        var weapons = new List<uint> { Weapon1, Weapon2, Weapon3, Weapon4 };

        for (var index = 0; index <= 3; index++)
        {
            var avatarId = characters[index];
            var weaponId = weapons[index];
            var relics = Relics[index];

            var avatarData = new BattleAvatar
            {
                Id = avatarId,
                Level = 80,
                Promotion = 6,
                Rank = AvatarRank,
                Hp = 10000,
                AvatarType = AvatarType.AvatarFormalType,
                WorldLevel = 6,
                Sp = new AmountInfo { CurAmount = 10000, MaxAmount = 10000 },
                EquipmentList =
                {
                    new BattleEquipment
                    {
                        Id = weaponId,
                        Level = 80,
                        Rank = WeaponRank,
                        Promotion = 6
                    }
                }
            };
            avatarData.RelicList.AddRange(relics);

            foreach (var end in skillIdEnds)
            {
                var level = end switch
                {
                    1 => 6u,
                    <= 4 => 10u,
                    > 4 => 1u
                };

                avatarData.SkilltreeLists.Add(new AvatarSkillTree
                {
                    PointId = avatarId * 1000 + end,
                    Level = level
                });
            }

            battleInfo.BattleAvatarList.Add(avatarData);
        }

        // monsters
        for (var monster = 1u; monster <= Monsters.Count; monster++)
        {
            var monsterInfo = new SceneMonsterWave
            {
                Pkgenfbhofi = monster,
                MonsterParam = new SceneMonsterParam
                {
                    Level = MonsterLevels[monster]
                }
            };

            if (Monsters.TryGetValue(monster, out var monsterIdList))
            {
                foreach (var monsterId in monsterIdList)
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
