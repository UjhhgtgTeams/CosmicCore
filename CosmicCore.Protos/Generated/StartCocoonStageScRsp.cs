// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: StartCocoonStageScRsp.proto
// </auto-generated>

namespace CosmicCore.Protos;

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
[global::ProtoBuf.ProtoContract()]
public partial class StartCocoonStageScRsp : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(8, Name = @"prop_entity_id")]
    public uint PropEntityId { get; set; }

    [global::ProtoBuf.ProtoMember(6, Name = @"battle_info")]
    public SceneBattleInfo BattleInfo { get; set; }

    [global::ProtoBuf.ProtoMember(1, Name = @"cocoon_id")]
    public uint CocoonId { get; set; }

    [global::ProtoBuf.ProtoMember(15, Name = @"retcode")]
    public uint Retcode { get; set; }

    [global::ProtoBuf.ProtoMember(4, Name = @"wave")]
    public uint Wave { get; set; }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
