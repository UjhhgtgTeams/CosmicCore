// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: PVEBattleResultCsReq.proto
// </auto-generated>

namespace CosmicCore.Protos;

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
[global::ProtoBuf.ProtoContract()]
public partial class PVEBattleResultCsReq : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(13, Name = @"turn_snapshot_hash")]
    public byte[] TurnSnapshotHash { get; set; }

    [global::ProtoBuf.ProtoMember(2, Name = @"client_res_version")]
    public uint ClientResVersion { get; set; }

    [global::ProtoBuf.ProtoMember(8, Name = @"stt")]
    public BattleStatistics Stt { get; set; }

    [global::ProtoBuf.ProtoMember(11, Name = @"stage_id")]
    public uint StageId { get; set; }

    [global::ProtoBuf.ProtoMember(3, Name = @"battle_id")]
    public uint BattleId { get; set; }

    [global::ProtoBuf.ProtoMember(12, Name = @"end_status")]
    public BattleEndStatus EndStatus { get; set; }

    [global::ProtoBuf.ProtoMember(15, Name = @"is_ai_consider_ultra_skill")]
    public bool IsAiConsiderUltraSkill { get; set; }

    [global::ProtoBuf.ProtoMember(14, Name = @"cost_time")]
    public uint CostTime { get; set; }

    [global::ProtoBuf.ProtoMember(1, Name = @"op_list")]
    public global::System.Collections.Generic.List<BattleOp> OpLists { get; } = new global::System.Collections.Generic.List<BattleOp>();

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
