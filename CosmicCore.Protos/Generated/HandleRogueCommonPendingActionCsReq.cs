// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: HandleRogueCommonPendingActionCsReq.proto
// </auto-generated>

namespace CosmicCore.Protos;

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
[global::ProtoBuf.ProtoContract()]
public partial class HandleRogueCommonPendingActionCsReq : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(1139, Name = @"buff_select_result")]
    public RogueCommonBuffSelectResult BuffSelectResult { get; set; }

    [global::ProtoBuf.ProtoMember(689, Name = @"roll_buff")]
    public RogueBuffRollInfo RollBuff { get; set; }

    [global::ProtoBuf.ProtoMember(194, Name = @"miracle_select_result")]
    public RogueMiracleSelectResult MiracleSelectResult { get; set; }

    [global::ProtoBuf.ProtoMember(136, Name = @"bonus_select_result")]
    public RogueBonusSelectResult BonusSelectResult { get; set; }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion