// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: RogueMapInfo.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
[global::ProtoBuf.ProtoContract()]
public partial class RogueMapInfo : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(11, Name = @"cur_room_id")]
    public uint CurRoomId { get; set; }

    [global::ProtoBuf.ProtoMember(6, Name = @"map_id")]
    public uint MapId { get; set; }

    [global::ProtoBuf.ProtoMember(2, Name = @"area_id")]
    public uint AreaId { get; set; }

    [global::ProtoBuf.ProtoMember(14, Name = @"room_list")]
    public global::System.Collections.Generic.List<RogueRoom> RoomLists { get; } = new global::System.Collections.Generic.List<RogueRoom>();

    [global::ProtoBuf.ProtoMember(12, Name = @"cur_site_id")]
    public uint CurSiteId { get; set; }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
