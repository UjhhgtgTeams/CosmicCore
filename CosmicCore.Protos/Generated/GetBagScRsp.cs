// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: GetBagScRsp.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
[global::ProtoBuf.ProtoContract()]
public partial class GetBagScRsp : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(1, Name = @"relic_list")]
    public global::System.Collections.Generic.List<Relic> RelicLists { get; } = new global::System.Collections.Generic.List<Relic>();

    [global::ProtoBuf.ProtoMember(14, Name = @"material_list")]
    public global::System.Collections.Generic.List<Material> MaterialLists { get; } = new global::System.Collections.Generic.List<Material>();

    [global::ProtoBuf.ProtoMember(10, Name = @"equipment_list")]
    public global::System.Collections.Generic.List<Equipment> EquipmentLists { get; } = new global::System.Collections.Generic.List<Equipment>();

    [global::ProtoBuf.ProtoMember(2, Name = @"retcode")]
    public uint Retcode { get; set; }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
