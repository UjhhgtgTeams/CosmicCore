// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: StartCocoonStageCsReq.proto
// </auto-generated>

namespace CosmicCore.Protos;

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
[global::ProtoBuf.ProtoContract()]
public partial class StartCocoonStageCsReq : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(5, Name = @"cocoon_id")]
    public uint CocoonId { get; set; }

    [global::ProtoBuf.ProtoMember(7, Name = @"world_level")]
    public uint WorldLevel { get; set; }

    [global::ProtoBuf.ProtoMember(14, Name = @"wave")]
    public uint Wave { get; set; }

    [global::ProtoBuf.ProtoMember(6, Name = @"prop_entity_id")]
    public uint PropEntityId { get; set; }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
