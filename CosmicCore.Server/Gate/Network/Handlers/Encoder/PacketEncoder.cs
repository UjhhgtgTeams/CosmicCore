using CosmicCore.Protos;
using CosmicCore.Server.Gate.Network.Packet;
using DotNetty.Buffers;
using DotNetty.Codecs;
using DotNetty.Transport.Channels;
using Serilog;

namespace CosmicCore.Server.Gate.Network.Handlers.Encoder;

public class PacketEncoder : MessageToByteEncoder<NetPacket>
{
    protected override void Encode(IChannelHandlerContext context, NetPacket message, IByteBuffer output)
    {
        output.WriteBytes(message.Buffer);
        Log.Information("Sent packet with cmd id {0}({1})", (CmdId)message.CmdId, message.CmdId);
    }
}
