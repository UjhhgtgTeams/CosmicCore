using CosmicCore.Protos;

namespace CosmicCore.Server.Gate.Manager.Handlers.Core;

using Network;
using Protos;

[AttributeUsage(AttributeTargets.Method)]
internal class HandlerAttribute : Attribute
{
    public int CmdId { get; }

    public HandlerAttribute(CmdId cmdId)
    {
        CmdId = (int)cmdId;
    }

    public delegate void HandlerDelegate(NetSession session, int cmdId, object? data);
}
