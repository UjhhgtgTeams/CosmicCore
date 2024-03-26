// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: SceneBattleInfo.proto
// </auto-generated>

namespace CosmicCore.Protos;

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
[global::ProtoBuf.ProtoContract()]
public partial class SceneBattleInfo : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(136, Name = @"battle_target_info")]
    [global::ProtoBuf.ProtoMap]
    public global::System.Collections.Generic.Dictionary<uint, BattleTargetList> BattleTargetInfoes { get; } = new global::System.Collections.Generic.Dictionary<uint, BattleTargetList>();

    [global::ProtoBuf.ProtoMember(9, Name = @"battle_id")]
    public uint BattleId { get; set; }

    [global::ProtoBuf.ProtoMember(1367, Name = @"event_battle_info_list")]
    public global::System.Collections.Generic.List<BattleEventBattleInfo> EventBattleInfoLists { get; } = new global::System.Collections.Generic.List<BattleEventBattleInfo>();

    [global::ProtoBuf.ProtoMember(7, Name = @"battle_avatar_list")]
    public global::System.Collections.Generic.List<BattleAvatar> BattleAvatarLists { get; } = new global::System.Collections.Generic.List<BattleAvatar>();

    [global::ProtoBuf.ProtoMember(1, Name = @"monster_wave_list")]
    public global::System.Collections.Generic.List<SceneMonsterWave> MonsterWaveLists { get; } = new global::System.Collections.Generic.List<SceneMonsterWave>();

    [global::ProtoBuf.ProtoMember(8, Name = @"world_level")]
    public uint WorldLevel { get; set; }

    [global::ProtoBuf.ProtoMember(3, Name = @"rounds_limit")]
    public uint RoundsLimit { get; set; }

    [global::ProtoBuf.ProtoMember(12, Name = @"logic_random_seed")]
    public uint LogicRandomSeed { get; set; }

    [global::ProtoBuf.ProtoMember(11, Name = @"buff_list")]
    public global::System.Collections.Generic.List<BattleBuff> BuffLists { get; } = new global::System.Collections.Generic.List<BattleBuff>();

    [global::ProtoBuf.ProtoMember(15, Name = @"stage_id")]
    public uint StageId { get; set; }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion