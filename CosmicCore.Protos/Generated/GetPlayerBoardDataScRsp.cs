// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: GetPlayerBoardDataScRsp.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
[global::ProtoBuf.ProtoContract()]
public partial class GetPlayerBoardDataScRsp : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(15, Name = @"signature")]
    [global::System.ComponentModel.DefaultValue("")]
    public string Signature { get; set; } = "";

    [global::ProtoBuf.ProtoMember(3, Name = @"unlocked_head_icon_list")]
    public global::System.Collections.Generic.List<HeadIcon> UnlockedHeadIconLists { get; } = new global::System.Collections.Generic.List<HeadIcon>();

    [global::ProtoBuf.ProtoMember(2, Name = @"current_head_icon_id")]
    public uint CurrentHeadIconId { get; set; }

    [global::ProtoBuf.ProtoMember(13, Name = @"display_avatar_vec")]
    public DisplayAvatarVec DisplayAvatarVec { get; set; }

    [global::ProtoBuf.ProtoMember(9, Name = @"retcode")]
    public uint Retcode { get; set; }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
