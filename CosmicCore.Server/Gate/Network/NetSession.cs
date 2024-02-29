using CosmicCore.Protos;
using CosmicCore.Server.Gate.Network.Packet;
using CosmicCore.Server.Utilities.Account;
using DotNetty.Buffers;
using DotNetty.Transport.Channels;

namespace CosmicCore.Server.Gate.Network;

public class NetSession(IChannel channel) : AccountManager(null)
{
    public NetSessionState State { get; set; } = NetSessionState.WaitingForToken;

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

    public async void Send(byte[] data)
    {
        var buffer = Unpooled.WrappedBuffer(data);
        await channel.WriteAndFlushAsync(buffer);
        buffer.Release();
    }

    public async void Disconnect()
    {
        await channel.DisconnectAsync();
    }
}

public enum NetSessionState
{
    Inactive,
    WaitingForToken,
    WaitingForLogin,
    Active
}
