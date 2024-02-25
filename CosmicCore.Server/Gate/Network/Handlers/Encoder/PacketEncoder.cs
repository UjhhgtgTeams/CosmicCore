using CosmicCore.Server.Gate.Network.Packet;
using DotNetty.Buffers;
using DotNetty.Codecs;
using DotNetty.Transport.Channels;

namespace CosmicCore.Server.Gate.Network.Handlers.Encoder;

public class PacketEncoder : MessageToByteEncoder<NetPacket>
{
    protected override void Encode(IChannelHandlerContext context, NetPacket message, IByteBuffer output)
    {
        output.WriteBytes(message.Buf);
    }
}
