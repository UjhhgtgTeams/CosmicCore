// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: SceneSummonUnitInfo.proto
// </auto-generated>

namespace CosmicCore.Protos;

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
[global::ProtoBuf.ProtoContract()]
public partial class SceneSummonUnitInfo : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(4, Name = @"attach_entity_id")]
    public uint AttachEntityId { get; set; }

    [global::ProtoBuf.ProtoMember(6, Name = @"life_time_ms", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int LifeTimeMs { get; set; }

    [global::ProtoBuf.ProtoMember(14, Name = @"caster_entity_id")]
    public uint CasterEntityId { get; set; }

    [global::ProtoBuf.ProtoMember(12, Name = @"trigger_name_list")]
    public global::System.Collections.Generic.List<string> TriggerNameLists { get; } = new global::System.Collections.Generic.List<string>();

    [global::ProtoBuf.ProtoMember(7, Name = @"create_time_ms")]
    public ulong CreateTimeMs { get; set; }

    [global::ProtoBuf.ProtoMember(3, Name = @"summon_unit_id")]
    public uint SummonUnitId { get; set; }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
