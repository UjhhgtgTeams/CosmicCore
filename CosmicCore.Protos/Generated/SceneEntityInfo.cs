// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: SceneEntityInfo.proto
// </auto-generated>

namespace CosmicCore.Protos;

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
[global::ProtoBuf.ProtoContract()]
public partial class SceneEntityInfo : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(6, Name = @"entity_id")]
    public uint EntityId { get; set; }

    [global::ProtoBuf.ProtoMember(11, Name = @"group_id")]
    public uint GroupId { get; set; }

    [global::ProtoBuf.ProtoMember(8, Name = @"motion")]
    public MotionInfo Motion { get; set; }

    [global::ProtoBuf.ProtoMember(4, Name = @"inst_id")]
    public uint InstId { get; set; }

    [global::ProtoBuf.ProtoMember(13, Name = @"actor")]
    public SceneActorInfo Actor { get; set; }

    [global::ProtoBuf.ProtoMember(9, Name = @"npc_monster")]
    public SceneNpcMonsterInfo NpcMonster { get; set; }

    [global::ProtoBuf.ProtoMember(14, Name = @"npc")]
    public SceneNpcInfo Npc { get; set; }

    [global::ProtoBuf.ProtoMember(5, Name = @"prop")]
    public ScenePropInfo Prop { get; set; }

    [global::ProtoBuf.ProtoMember(12, Name = @"summon_unit")]
    public SceneSummonUnitInfo SummonUnit { get; set; }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
