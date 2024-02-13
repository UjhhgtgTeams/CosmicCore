using ProtoBuf;

namespace CosmicCore.Server.Dispatch.Utils;

public class ProtobufUtil
{
    public static byte[] Serialize<T>(T obj) where T : class
    {
        var stream = new MemoryStream();
        Serializer.Serialize(stream, obj);

        return stream.ToArray();
    }
}
