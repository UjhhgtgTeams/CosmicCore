using CosmicCore.Server.Gate.Manager.Handlers.Core;
using CosmicCore.Server.Gate.Network;
using CosmicCore.Server.Utilities;
using CosmicCore.Protos;
using static CosmicCore.Server.Utilities.Avatar.DefaultAvatarConst;

namespace CosmicCore.Server.Gate.Manager.Handlers;

public class BattleReqGroup
{
    [PacketHandler(CmdId.CmdStartCocoonStageCsReq)]
    public static void OnStartCocoonStageCsReq(NetSession session, int cmdId, object data)
    {
        var request = data as StartCocoonStageCsReq;

        var monsterIds = new Dictionary<uint, List<uint>>
        {
            { 1, [3001010, 3001020, 3001020, 3001010] },
            { 2, [3002030, 3002010, 3002010, 3002030] },
            { 3, [3011010, 3012020, 3011010] },
            { 4, [3003010, 3003020] },
            { 5, [3024020] },
            { 6, [3014020] },
            { 7, [3002050] }
        };

        var monsterLevels = new Dictionary<uint, uint>
        {
            { 1, 70 }, { 2, 70 }, { 3, 60 }, { 4, 65 }, { 5, 55 }, { 6, 60 }, { 7, 75 }
        };

        // basic
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

        // avatar
        var skillIdEnds = new List<uint>
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

            foreach (var end in skillIdEnds)
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

        // monsters
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

    [PacketHandler(CmdId.CmdPVEBattleResultCsReq)]
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
