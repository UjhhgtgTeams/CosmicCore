// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: RogueFinishInfo.proto
// </auto-generated>

namespace CosmicCore.Protos;

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
[global::ProtoBuf.ProtoContract()]
public partial class RogueFinishInfo : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(12, Name = @"pass_room_count")]
    public uint PassRoomCount { get; set; }

    [global::ProtoBuf.ProtoMember(2, Name = @"BFCBHPCPAOI")]
    public bool Bfcbhpcpaoi { get; set; }

    [global::ProtoBuf.ProtoMember(10, Name = @"cur_score_reward_info")]
    public RogueScoreRewardInfo CurScoreRewardInfo { get; set; }

    [global::ProtoBuf.ProtoMember(260, Name = @"area_id")]
    public uint AreaId { get; set; }

    [global::ProtoBuf.ProtoMember(15, Name = @"record_info")]
    public RogueRecordInfo RecordInfo { get; set; }

    [global::ProtoBuf.ProtoMember(6, Name = @"taken_score")]
    public uint TakenScore { get; set; }

    [global::ProtoBuf.ProtoMember(13, Name = @"LBLELCPPLCI")]
    public ItemList Lblelcpplci { get; set; }

    [global::ProtoBuf.ProtoMember(4, Name = @"ANBFGOKNEIA")]
    public uint Anbfgokneia { get; set; }

    [global::ProtoBuf.ProtoMember(5, Name = @"score_reward_info")]
    public RogueScoreRewardInfo ScoreRewardInfo { get; set; }

    [global::ProtoBuf.ProtoMember(9, Name = @"is_win")]
    public bool IsWin { get; set; }

    [global::ProtoBuf.ProtoMember(14, Name = @"IPNGMMIOJJB")]
    public ItemList Ipngmmiojjb { get; set; }

    [global::ProtoBuf.ProtoMember(271, Name = @"reach_room_count")]
    public uint ReachRoomCount { get; set; }

    [global::ProtoBuf.ProtoMember(8, Name = @"BCKPHBOPCCN")]
    public uint Bckphbopccn { get; set; }

    [global::ProtoBuf.ProtoMember(3, Name = @"ICOCLPBLFNN")]
    public ItemList Icoclpblfnn { get; set; }

    [global::ProtoBuf.ProtoMember(1, Name = @"total_score")]
    public uint TotalScore { get; set; }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
