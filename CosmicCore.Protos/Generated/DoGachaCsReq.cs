// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: DoGachaCsReq.proto
// </auto-generated>

namespace CosmicCore.Protos;

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
[global::ProtoBuf.ProtoContract()]
public partial class DoGachaCsReq : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(5, Name = @"gacha_id")]
    public uint GachaId { get; set; }

    [global::ProtoBuf.ProtoMember(6, Name = @"gacha_num")]
    public uint GachaNum { get; set; }

    [global::ProtoBuf.ProtoMember(15, Name = @"simulate_magic")]
    public uint SimulateMagic { get; set; }

    [global::ProtoBuf.ProtoMember(3, Name = @"gacha_random")]
    public uint GachaRandom { get; set; }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion