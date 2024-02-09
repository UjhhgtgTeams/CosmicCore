namespace CosmicCore.Server.Gate.Network.Handlers.Encoder;

using DotNetty.Buffers;
using DotNetty.Codecs;
using DotNetty.Transport.Channels;
using Packet;
using Serilog;

internal class PacketEncoder : MessageToByteEncoder<NetPacket>
{
    protected override void Encode(IChannelHandlerContext context, NetPacket message, IByteBuffer output)
    {
        output.WriteBytes(message.Buffer);
        Log.Information($"Sent packet with cmdId {message.CmdId}");
    }
}
