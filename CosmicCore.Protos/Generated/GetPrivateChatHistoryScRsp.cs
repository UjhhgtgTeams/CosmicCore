// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: GetPrivateChatHistoryScRsp.proto
// </auto-generated>

namespace CosmicCore.Protos;

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
[global::ProtoBuf.ProtoContract()]
public partial class GetPrivateChatHistoryScRsp : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(13, Name = @"sender_uid")]
    public uint SenderUid { get; set; }

    [global::ProtoBuf.ProtoMember(8, Name = @"to_uid")]
    public uint ToUid { get; set; }

    [global::ProtoBuf.ProtoMember(10, Name = @"retcode")]
    public uint Retcode { get; set; }

    [global::ProtoBuf.ProtoMember(5, Name = @"chat_list")]
    public global::System.Collections.Generic.List<Chat> ChatLists { get; } = new global::System.Collections.Generic.List<Chat>();

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion