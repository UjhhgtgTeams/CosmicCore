using CosmicCore.Protos;
using CosmicCore.Server.Gate.Network.Packet;
using DotNetty.Buffers;
using DotNetty.Transport.Channels;

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
        packet.Buffer = buffer;

        await channel.WriteAndFlushAsync(packet);
    }
}
