// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: SceneInfo.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
[global::ProtoBuf.ProtoContract()]
public partial class SceneInfo : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(3, Name = @"floor_id")]
    public uint FloorId { get; set; }

    [global::ProtoBuf.ProtoMember(15, Name = @"game_mode_type")]
    public uint GameModeType { get; set; }

    [global::ProtoBuf.ProtoMember(347, Name = @"group_state_list")]
    public global::System.Collections.Generic.List<SceneGroupState> GroupStateLists { get; } = new global::System.Collections.Generic.List<SceneGroupState>();

    [global::ProtoBuf.ProtoMember(4, Name = @"group_id_list", IsPacked = true)]
    public uint[] GroupIdLists { get; set; }

    [global::ProtoBuf.ProtoMember(11, Name = @"entry_id")]
    public uint EntryId { get; set; }

    [global::ProtoBuf.ProtoMember(9, Name = @"lighten_section_list", IsPacked = true)]
    public uint[] LightenSectionLists { get; set; }

    [global::ProtoBuf.ProtoMember(1, Name = @"entity_list")]
    public global::System.Collections.Generic.List<SceneEntityInfo> EntityLists { get; } = new global::System.Collections.Generic.List<SceneEntityInfo>();

    [global::ProtoBuf.ProtoMember(7, Name = @"client_pos_version")]
    public uint ClientPosVersion { get; set; }

    [global::ProtoBuf.ProtoMember(1538, Name = @"entity_group_list")]
    public global::System.Collections.Generic.List<SceneEntityGroupInfo> EntityGroupLists { get; } = new global::System.Collections.Generic.List<SceneEntityGroupInfo>();

    [global::ProtoBuf.ProtoMember(5, Name = @"world_id")]
    public uint WorldId { get; set; }

    [global::ProtoBuf.ProtoMember(13, Name = @"plane_id")]
    public uint PlaneId { get; set; }

    [global::ProtoBuf.ProtoMember(2, Name = @"leader_entity_id")]
    public uint LeaderEntityId { get; set; }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
