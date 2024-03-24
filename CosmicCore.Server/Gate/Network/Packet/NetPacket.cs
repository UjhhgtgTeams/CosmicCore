using CosmicCore.Server.Gate.Network.Factory;
using DotNetty.Buffers;
using ProtoBuf;

namespace CosmicCore.Server.Gate.Network.Packet;

public class NetPacket
{
    private const uint HeadMagicConst = 0x9d74c714;
    private const uint TailMagicConst = 0xd7a152c8;

    public int CmdId { get; set; }
    public int HeadLen { get; set; }
    public uint HeadMagic { get; set; }
    public int PacketLen { get; set; }
    public byte[] RawData { get; set; }
    public uint TailMagic { get; set; }
    public object? Data { get; set; }
    public IByteBuffer Buffer { get; set; }

    public DeserializationResult Deserialize(IByteBuffer buffer)
    {
        HeadMagic = buffer.ReadUnsignedInt();
        if (HeadMagic != HeadMagicConst)
            return DeserializationResult.CmdFailedMagicMismatch;

        CmdId = buffer.ReadShort();
        HeadLen = buffer.ReadShort();
        PacketLen = buffer.ReadInt();

        if (buffer.ReadableBytes < HeadLen + PacketLen + 4)
            return DeserializationResult.CmdFailedLengthInvalid;

        RawData = new byte[PacketLen];

        _ = buffer.ReadBytes(HeadLen);
        buffer.ReadBytes(RawData);

        TailMagic = buffer.ReadUnsignedInt();
        if (TailMagic != TailMagicConst)
            return DeserializationResult.CmdFailedMagicMismatch;

        Data = ProtoFactory.Deserialize(CmdId, RawData);

        return DeserializationResult.CmdSuccess;
    }

    public void Serialize<T>(IByteBuffer buf) where T : class
    {
        var stream = new MemoryStream();
        Serializer.Serialize(stream, Data as T);
        RawData = stream.ToArray();
        PacketLen = RawData.Length;

        buf.WriteUnsignedShort((ushort)(HeadMagicConst >> 16));
        buf.WriteUnsignedShort(0xc714);
        buf.WriteShort(CmdId);
        buf.WriteShort(HeadLen);
        buf.WriteInt(PacketLen);
        buf.WriteBytes(RawData);
        buf.WriteUnsignedShort((ushort)(TailMagicConst >> 16));
        buf.WriteUnsignedShort(0x52c8);
    }
}

public enum DeserializationResult
{
    CmdSuccess = 1,
    CmdFailedLengthInvalid = 2,
    CmdFailedMagicMismatch = 3
}
