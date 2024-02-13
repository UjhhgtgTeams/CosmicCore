using CosmicCore.Protos;

namespace CosmicCore.Server.Utilities.Command.Commands;

[Command(Names = ["dbg", "debug"],
    Description = "Does experimental things.",
    Usage = "<experiment_name>",
    RequiredPermissions = ["admin.debug"])]
public class TemplateCommand : ICommand
{
    public override Dictionary<int, string> ReturnCodeMap { get; } = [];

    public override int OnExecute(string args, Account.Account executor)
    {
        var arguments = CommandUtilities.SplitArgs(args).ToArray();

        if (arguments[0] == "battle")
        {
            var lineupInfo = new LineupInfo
            {
                ExtraLineupType = ExtraLineupType.LineupNone,
                Name = "Squad 1",
                Mp = 5,
                MaxMp = 5,
                LeaderSlot = 0
            };
            var characters = new List<uint> {
                Avatar.DefaultAvatarConst.Avatar1,
                Avatar.DefaultAvatarConst.Avatar2,
                Avatar.DefaultAvatarConst.Avatar3,
                Avatar.DefaultAvatarConst.Avatar4 }; // hardcode
            foreach (var id in characters.Where(id => id != 0))
            {
                lineupInfo.AvatarList.Add(new LineupAvatar
                {
                    Id = id,
                    Hp = 10000,
                    Satiety = 100,
                    SpBar = new SpBarInfo { CurSp = 10000, MaxSp = 10000 },
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

            sceneInfo.EntityLists.Add(new SceneEntityInfo
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
            });

            executor.Session?.Send(CmdId.CmdEnterSceneByServerScNotify, new EnterSceneByServerScNotify
            {
                Scene = sceneInfo,
                Lineup = lineupInfo
            });

            executor.Session?.Send(CmdId.CmdSceneEntityMoveScNotify, new SceneEntityMoveScNotify
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

        return 1;
    }
}
