using CosmicCore.Server.Gate.Network.Packet;
using DotNetty.Buffers;
using DotNetty.Codecs;
using DotNetty.Transport.Channels;
using Serilog;

namespace CosmicCore.Server.Gate.Network.Handlers.Decoder;

public class PacketDecoder : MessageToMessageDecoder<IByteBuffer>
{
    protected override void Decode(IChannelHandlerContext context, IByteBuffer message, List<object> output)
    {
        var netPacket = new NetPacket();

        DeserializationResult result;
        if ((result = netPacket.Deserialize(message)) != DeserializationResult.Success)
        {
            context.CloseAsync();

            var errMessage = result switch
            {
                DeserializationResult.FailedLengthInvalid => "length invalid",
                DeserializationResult.FailedMagicMismatch => "magic mismatch",
                _ => throw new ArgumentOutOfRangeException(nameof(result), "this exception will never be thrown")
            };
            Log.Warning("Closing a connection due to packet {0}!", errMessage);

            return;
        }

        output.Add(netPacket);
    }
}
