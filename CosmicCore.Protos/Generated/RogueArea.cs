// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: RogueArea.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
[global::ProtoBuf.ProtoContract()]
public partial class RogueArea : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(8, Name = @"rogue_area_status")]
    public uint RogueAreaStatus { get; set; }

    [global::ProtoBuf.ProtoMember(2, Name = @"cur_reach_room_num")]
    public uint CurReachRoomNum { get; set; }

    [global::ProtoBuf.ProtoMember(14, Name = @"CMJFDLMBIOK")]
    public bool Cmjfdlmbiok { get; set; }

    [global::ProtoBuf.ProtoMember(5, Name = @"map_id")]
    public uint MapId { get; set; }

    [global::ProtoBuf.ProtoMember(7, Name = @"area_id")]
    public uint AreaId { get; set; }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
