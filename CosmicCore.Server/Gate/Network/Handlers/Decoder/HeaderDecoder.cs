using DotNetty.Buffers;
using DotNetty.Codecs;
using DotNetty.Transport.Channels;

namespace CosmicCore.Server.Gate.Network.Handlers.Decoder;

internal class HeaderDecoder : ByteToMessageDecoder
{
    private IByteBuffer _current = Unpooled.Buffer();

    protected override void Decode(IChannelHandlerContext context, IByteBuffer input, List<object> output)
    {
        var allocated = Unpooled.Buffer();
        allocated.WriteBytes(_current);
        allocated.WriteBytes(input);
        _current = allocated;

        var lands = new byte[_current.ReadableBytes];
        _current.ReadBytes(lands);
        _current.ResetReaderIndex();

        IByteBuffer? packet;
        while ((packet = Process()) != null)
            output.Add(packet);
    }

    private IByteBuffer? Process()
    {
        if (_current.ReadableBytes < 12)
            return null;

        _current.ReadInt(); // headMagic
        _current.ReadShort(); // CmdID
        int headerLength = _current.ReadShort();
        var payloadLength = _current.ReadInt();

        var totalLength = 12 + headerLength + payloadLength + 4;
        _current.ResetReaderIndex();
        if (_current.ReadableBytes < totalLength)
            return null;

        var result = _current.ReadBytes(totalLength);
        _current = _current.ReadBytes(_current.ReadableBytes);

        return result;
    }
}
