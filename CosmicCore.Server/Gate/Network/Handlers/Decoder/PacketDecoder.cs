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
        var packet = new NetPacket();

        DeserializationResult result;
        if ((result = packet.Deserialize(message)) != DeserializationResult.Success)
        {
            context.CloseAsync();

            var errorMsg = result switch
            {
                DeserializationResult.FailedLengthInvalid => "length invalid",
                DeserializationResult.FailedMagicMismatch => "magic mismatch",
                _ => throw new ArgumentOutOfRangeException(nameof(message), "this exception will never be thrown")
            };
            Log.Warning("Closing a connection due to packet deserialization {0}!", errorMsg);
        }
        else
        {
            // Log.Debug(
            //     packet.Data is not null
            //         ? "{0}({1}): Deserialized"
            //         : "{0}({1}): Deserialized into null", (CmdId)packet.CmdId, packet.CmdId);

            output.Add(packet);
        }
    }
}
