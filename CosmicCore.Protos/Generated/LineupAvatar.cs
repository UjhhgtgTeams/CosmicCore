// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: LineupAvatar.proto
// </auto-generated>

namespace CosmicCore.Protos;

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
[global::ProtoBuf.ProtoContract()]
public partial class LineupAvatar : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(12, Name = @"avatar_type")]
    public AvatarType AvatarType { get; set; }

    [global::ProtoBuf.ProtoMember(6, Name = @"slot")]
    public uint Slot { get; set; }

    [global::ProtoBuf.ProtoMember(7, Name = @"satiety")]
    public uint Satiety { get; set; }

    [global::ProtoBuf.ProtoMember(15, Name = @"hp")]
    public uint Hp { get; set; }

    [global::ProtoBuf.ProtoMember(3, Name = @"id")]
    public uint Id { get; set; }

    [global::ProtoBuf.ProtoMember(9, Name = @"sp_bar")]
    public SpBarInfo SpBar { get; set; }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
