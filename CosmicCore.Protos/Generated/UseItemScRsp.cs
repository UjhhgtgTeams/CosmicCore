// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: UseItemScRsp.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
[global::ProtoBuf.ProtoContract()]
public partial class UseItemScRsp : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(9, Name = @"return_data")]
    public ItemList ReturnData { get; set; }

    [global::ProtoBuf.ProtoMember(11, Name = @"retcode")]
    public uint Retcode { get; set; }

    [global::ProtoBuf.ProtoMember(15, Name = @"use_item_count")]
    public uint UseItemCount { get; set; }

    [global::ProtoBuf.ProtoMember(8, Name = @"use_item_id")]
    public uint UseItemId { get; set; }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
