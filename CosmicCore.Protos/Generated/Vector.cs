// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: Vector.proto
// </auto-generated>

namespace CosmicCore.Protos;

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
[global::ProtoBuf.ProtoContract()]
public partial class Vector : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(2, Name = @"y", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int Y { get; set; }

    [global::ProtoBuf.ProtoMember(12, Name = @"x", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int X { get; set; }

    [global::ProtoBuf.ProtoMember(11, Name = @"z", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    public int Z { get; set; }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion