// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: UnlockSkilltreeCsReq.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
[global::ProtoBuf.ProtoContract()]
public partial class UnlockSkilltreeCsReq : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(5, Name = @"level")]
    public uint Level { get; set; }

    [global::ProtoBuf.ProtoMember(13, Name = @"point_id")]
    public uint PointId { get; set; }

    [global::ProtoBuf.ProtoMember(14, Name = @"item_list")]
    public global::System.Collections.Generic.List<ItemCost> ItemLists { get; } = new global::System.Collections.Generic.List<ItemCost>();

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
