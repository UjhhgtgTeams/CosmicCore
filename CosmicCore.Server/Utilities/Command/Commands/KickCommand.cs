using CosmicCore.Protos;
using CosmicCore.Server.Gate.Manager.Handlers;
using CosmicCore.Server.Gate.Network.Handlers.Manager;
using Serilog;

namespace CosmicCore.Server.Utilities.Command.Commands;

[Command(Names = ["kick"],
    Description = "Kicks the player.",
    Usage = "",
    RequiredPermissions = [])]
public class KickCommand : ICommand
{
    public Dictionary<int, string> ReturnCodeMap { get; } = [];

    public int OnExecute(string args)
    {
        if (PlayerReqGroup.PlayerSession is not null)
        {
            PlayerReqGroup.PlayerSession.Send(CmdId.CmdPlayerKickOutScNotify, new PacketHandler.DummyPacket());
            Log.Information("Kicked player.");
        }
        else
        {
            Log.Error("Cannot kick player due to player offline.");
        }

        return 0;
    }
}
