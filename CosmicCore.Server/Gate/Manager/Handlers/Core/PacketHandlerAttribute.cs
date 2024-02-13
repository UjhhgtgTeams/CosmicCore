using CosmicCore.Protos;
using CosmicCore.Server.Gate.Network;

namespace CosmicCore.Server.Gate.Manager.Handlers.Core;

[AttributeUsage(AttributeTargets.Method)]
public class PacketHandlerAttribute(CmdId cmdId) : Attribute
{
    public int CmdId { get; } = (int)cmdId;

    public delegate void HandlerDelegate(NetSession session, int cmdId, object? data);
}
