// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: AvatarBattleInfo.proto
// </auto-generated>

namespace CosmicCore.Protos;

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
[global::ProtoBuf.ProtoContract()]
public partial class AvatarBattleInfo : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(1, Name = @"avatar_type")]
    public AvatarType AvatarType { get; set; }

    [global::ProtoBuf.ProtoMember(2, Name = @"id")]
    public uint Id { get; set; }

    [global::ProtoBuf.ProtoMember(3, Name = @"avatar_level")]
    public uint AvatarLevel { get; set; }

    [global::ProtoBuf.ProtoMember(4, Name = @"avatar_rank")]
    public uint AvatarRank { get; set; }

    [global::ProtoBuf.ProtoMember(5, Name = @"avatar_promotion")]
    public uint AvatarPromotion { get; set; }

    [global::ProtoBuf.ProtoMember(6, Name = @"avatar_status")]
    public AvatarProperty AvatarStatus { get; set; }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
