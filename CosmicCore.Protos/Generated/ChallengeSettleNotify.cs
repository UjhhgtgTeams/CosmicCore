// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: ChallengeSettleNotify.proto
// </auto-generated>

namespace CosmicCore.Protos;

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
[global::ProtoBuf.ProtoContract()]
public partial class ChallengeSettleNotify : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(13, Name = @"stars")]
    public uint Stars { get; set; }

    [global::ProtoBuf.ProtoMember(12, Name = @"reward")]
    public ItemList Reward { get; set; }

    [global::ProtoBuf.ProtoMember(14, Name = @"challenge_id")]
    public uint ChallengeId { get; set; }

    [global::ProtoBuf.ProtoMember(15, Name = @"is_win")]
    public bool IsWin { get; set; }

    [global::ProtoBuf.ProtoMember(10, Name = @"score_two")]
    public uint ScoreTwo { get; set; }

    [global::ProtoBuf.ProtoMember(9, Name = @"challenge_score")]
    public uint ChallengeScore { get; set; }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
