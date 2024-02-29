using CosmicCore.Protos;
using CosmicCore.Server.Gate.Network.Packet;
using CosmicCore.Server.Utilities.Logger;
using DotNetty.Buffers;
using DotNetty.Transport.Channels;
using Serilog;

namespace CosmicCore.Server.Gate.Network;

public class NetSession(IChannel channel)
{
    public async void Send<T>(CmdId cmdId, T data) where T : class
    {
        var packet = new NetPacket
        {
            CmdId = (int)cmdId,
            Data = data
        };

        var buffer = Unpooled.Buffer();
        packet.Serialize<T>(buffer);
        packet.Buf = buffer;

        if (LoggerManager.IsCmdIdLogged((int)cmdId))
            Log.Debug("{0}({1}): Sent", cmdId, (int)cmdId);

        await channel.WriteAndFlushAsync(packet);
    }

    public async void Close()
    {
        await channel.DisconnectAsync();
    }
}
