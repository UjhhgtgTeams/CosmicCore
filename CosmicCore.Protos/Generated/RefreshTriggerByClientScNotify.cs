// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: RefreshTriggerByClientScNotify.proto
// </auto-generated>

namespace CosmicCore.Protos;

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
[global::ProtoBuf.ProtoContract()]
public partial class RefreshTriggerByClientScNotify : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(1, Name = @"trigger_name")]
    [global::System.ComponentModel.DefaultValue("")]
    public string TriggerName { get; set; } = "";

    [global::ProtoBuf.ProtoMember(5, Name = @"trigger_target_id_list", IsPacked = true)]
    public uint[] TriggerTargetIdLists { get; set; }

    [global::ProtoBuf.ProtoMember(7, Name = @"trigger_entity_id")]
    public uint TriggerEntityId { get; set; }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion