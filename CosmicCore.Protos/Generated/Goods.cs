// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: Goods.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
[global::ProtoBuf.ProtoContract()]
public partial class Goods : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(13, Name = @"end_time")]
    public long EndTime { get; set; }

    [global::ProtoBuf.ProtoMember(8, Name = @"buy_times")]
    public uint BuyTimes { get; set; }

    [global::ProtoBuf.ProtoMember(3, Name = @"begin_time")]
    public long BeginTime { get; set; }

    [global::ProtoBuf.ProtoMember(4, Name = @"goods_id")]
    public uint GoodsId { get; set; }

    [global::ProtoBuf.ProtoMember(14, Name = @"item_id")]
    public uint ItemId { get; set; }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
