// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: QuitLineupCsReq.proto
// </auto-generated>

namespace CosmicCore.Protos;

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
[global::ProtoBuf.ProtoContract()]
public partial class QuitLineupCsReq : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(14, Name = @"extra_lineup_type")]
    public ExtraLineupType ExtraLineupType { get; set; }

    [global::ProtoBuf.ProtoMember(13, Name = @"index")]
    public uint Index { get; set; }

    [global::ProtoBuf.ProtoMember(8, Name = @"avatar_type")]
    public AvatarType AvatarType { get; set; }

    [global::ProtoBuf.ProtoMember(5, Name = @"is_virtual")]
    public bool IsVirtual { get; set; }

    [global::ProtoBuf.ProtoMember(7, Name = @"plane_id")]
    public uint PlaneId { get; set; }

    [global::ProtoBuf.ProtoMember(2, Name = @"base_avatar_id")]
    public uint BaseAvatarId { get; set; }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
