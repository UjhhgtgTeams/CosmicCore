// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: PVEBattleResultScRsp.proto
// </auto-generated>

namespace CosmicCore.Protos;

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
[global::ProtoBuf.ProtoContract()]
public partial class PVEBattleResultScRsp : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(8, Name = @"battle_avatar_list")]
    public global::System.Collections.Generic.List<BattleAvatar> BattleAvatarLists { get; } = new global::System.Collections.Generic.List<BattleAvatar>();

    [global::ProtoBuf.ProtoMember(4, Name = @"event_id")]
    public uint EventId { get; set; }

    [global::ProtoBuf.ProtoMember(12, Name = @"check_identical")]
    public bool CheckIdentical { get; set; }

    [global::ProtoBuf.ProtoMember(15, Name = @"mismatch_turn_count")]
    public uint MismatchTurnCount { get; set; }

    [global::ProtoBuf.ProtoMember(5, Name = @"retcode")]
    public uint Retcode { get; set; }

    [global::ProtoBuf.ProtoMember(6, Name = @"battle_id")]
    public uint BattleId { get; set; }

    [global::ProtoBuf.ProtoMember(14, Name = @"bin_version")]
    [global::System.ComponentModel.DefaultValue("")]
    public string BinVersion { get; set; } = "";

    [global::ProtoBuf.ProtoMember(3, Name = @"res_version")]
    [global::System.ComponentModel.DefaultValue("")]
    public string ResVersion { get; set; } = "";

    [global::ProtoBuf.ProtoMember(7, Name = @"end_status")]
    public BattleEndStatus EndStatus { get; set; }

    [global::ProtoBuf.ProtoMember(1, Name = @"stage_id")]
    public uint StageId { get; set; }

    [global::ProtoBuf.ProtoMember(2, Name = @"drop_data")]
    public ItemList DropData { get; set; }

    [global::ProtoBuf.ProtoMember(9, Name = @"unk1")]
    public ItemList Unk1 { get; set; }

    [global::ProtoBuf.ProtoMember(13, Name = @"unk2")]
    public ItemList Unk2 { get; set; }

    [global::ProtoBuf.ProtoMember(524, Name = @"unk3")]
    public ItemList Unk3 { get; set; }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
