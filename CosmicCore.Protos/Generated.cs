namespace CosmicCore.Protos;

// ReSharper disable InconsistentNaming

#region Designer generated code

#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
[ProtoBuf.ProtoContract]
public class PlayerBasicInfo : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"nickname")]
    [System.ComponentModel.DefaultValue("")]
    public string Nickname { get; set; } = "";

    [ProtoBuf.ProtoMember(2, Name = @"level")]
    public uint Level { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"exp")]
    public uint Exp { get; set; }

    [ProtoBuf.ProtoMember(4, Name = @"stamina")]
    public uint Stamina { get; set; }

    [ProtoBuf.ProtoMember(5, Name = @"mcoin")]
    public uint MCoin { get; set; }

    [ProtoBuf.ProtoMember(6, Name = @"hcoin")]
    public uint HCoin { get; set; }

    [ProtoBuf.ProtoMember(7, Name = @"scoin")]
    public uint SCoin { get; set; }

    [ProtoBuf.ProtoMember(8, Name = @"world_level")]
    public uint WorldLevel { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class AmountInfo : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"cur_amount")]
    public uint CurrentAmount { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"max_amount")]
    public uint MaxAmount { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class BlackInfo : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"begin_time")]
    public long BeginTime { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"end_time")]
    public long EndTime { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"limit_level")]
    public uint LimitLevel { get; set; }

    [ProtoBuf.ProtoMember(4, Name = @"ban_type")]
    public uint BanType { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract(Name = @"NGKBJMDOJGP")]
public class Ngkbjmdojgp : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"avatar_type")]
    public AvatarType AvatarType { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"id")]
    public uint Id { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class VersionCount : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"version")]
    public uint Version { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"count")]
    public uint Count { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class ClientDownloadData : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"version")]
    public uint Version { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"time")]
    public long Time { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"data")]
    public byte[] Data { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class ClientObjDownloadData : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"obj")]
    public byte[] Obj { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"obj_data")]
    public ClientDownloadData ObjData { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class ClientUploadData : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"tag")]
    [System.ComponentModel.DefaultValue("")]
    public string Tag { get; set; } = "";

    [ProtoBuf.ProtoMember(2, Name = @"value")]
    [System.ComponentModel.DefaultValue("")]
    public string Value { get; set; } = "";

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class FeatureSwitchParam : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"switch_list", IsPacked = true)]
    public uint[] SwitchList { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class FeatureSwitchInfo : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"type")]
    public FeatureSwitchType Type { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"switch_list")]
    public List<FeatureSwitchParam> SwitchList { get; } = [];

    [ProtoBuf.ProtoMember(3, Name = @"is_all_closed")]
    public bool IsAllClosed { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class ExtraDeviceInfo : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"device_id")]
    [System.ComponentModel.DefaultValue("")]
    public string DeviceId { get; set; } = "";

    [ProtoBuf.ProtoMember(2, Name = @"device_type")]
    [System.ComponentModel.DefaultValue("")]
    public string DeviceType { get; set; } = "";

    [ProtoBuf.ProtoMember(3, Name = @"idfa")]
    [System.ComponentModel.DefaultValue("")]
    public string Idfa { get; set; } = "";

    [ProtoBuf.ProtoMember(4, Name = @"imei")]
    [System.ComponentModel.DefaultValue("")]
    public string Imei { get; set; } = "";

    [ProtoBuf.ProtoMember(5, Name = @"androidid")]
    [System.ComponentModel.DefaultValue("")]
    public string AndroidId { get; set; } = "";

    [ProtoBuf.ProtoMember(6, Name = @"oaid")]
    [System.ComponentModel.DefaultValue("")]
    public string Oaid { get; set; } = "";

    [ProtoBuf.ProtoMember(7, Name = @"mac")]
    [System.ComponentModel.DefaultValue("")]
    public string Mac { get; set; } = "";

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class ReplayInfo : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"NHEEADIPEOI")]
    public ulong Nheeadipeoi { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"replay_type")]
    public ReplayType ReplayType { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"stage_id")]
    public uint StageId { get; set; }

    [ProtoBuf.ProtoMember(4, Name = @"uid")]
    public uint UId { get; set; }

    [ProtoBuf.ProtoMember(5, Name = @"nickname")]
    [System.ComponentModel.DefaultValue("")]
    public string Nickname { get; set; } = "";

    [ProtoBuf.ProtoMember(6, Name = @"head_icon")]
    public uint HeadIcon { get; set; }

    [ProtoBuf.ProtoMember(7, Name = @"DIDPBHNLCEL")]
    [System.ComponentModel.DefaultValue("")]
    public string Didpbhnlcel { get; set; } = "";

    [ProtoBuf.ProtoMember(8, Name = @"timestamp")]
    public ulong Timestamp { get; set; }

    [ProtoBuf.ProtoMember(9, Name = @"KAOIFIFBIJG")]
    public uint Kaoififbijg { get; set; }

    [ProtoBuf.ProtoMember(10, Name = @"KAKGGNHJOKN")]
    public uint Kakggnhjokn { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class PunkLordBattleAvatar : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"avatar_id")]
    public uint AvatarId { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"avatar_level")]
    public uint AvatarLevel { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class PunkLordBattleRecord : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"uid")]
    public uint Uid { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"damage_hp")]
    public uint DamageHp { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"is_final_hit")]
    public bool IsFinalHit { get; set; }

    [ProtoBuf.ProtoMember(4, Name = @"over_kill_damage_hp")]
    public uint OverKillDamageHp { get; set; }

    [ProtoBuf.ProtoMember(5, Name = @"battle_replay_key")]
    [System.ComponentModel.DefaultValue("")]
    public string BattleReplayKey { get; set; } = "";

    [ProtoBuf.ProtoMember(6, Name = @"avatar_list")]
    public List<PunkLordBattleAvatar> AvatarList { get; } = [];

    [ProtoBuf.ProtoMember(7, Name = @"assist_score")]
    public uint AssistScore { get; set; }

    [ProtoBuf.ProtoMember(8, Name = @"damage_score")]
    public uint DamageScore { get; set; }

    [ProtoBuf.ProtoMember(9, Name = @"final_hit_score")]
    public uint FinalHitScore { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class PunkLordBattleRecordList : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"MNPMIKFGLIO")]
    public List<PunkLordBattleRecord> PunkLordBattleRecords { get; } = [];

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class PunkLordMonsterKey : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"uid")]
    public uint UId { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"monster_id")]
    public uint MonsterId { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class PunkLordMonsterBasicInfo : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"uid")]
    public uint UId { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"monster_id")]
    public uint MonsterId { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"config_id")]
    public uint ConfigId { get; set; }

    [ProtoBuf.ProtoMember(4, Name = @"world_level")]
    public uint WorldLevel { get; set; }

    [ProtoBuf.ProtoMember(5, Name = @"timestamp")]
    public long Timestamp { get; set; }

    [ProtoBuf.ProtoMember(6, Name = @"left_hp")]
    public uint LeftHp { get; set; }

    [ProtoBuf.ProtoMember(7, Name = @"AFIDGJPJBII")]
    public uint Afidgjpjbii { get; set; }

    [ProtoBuf.ProtoMember(8, Name = @"MCANBFMGPDD")]
    public PunkLordShareType ShareType { get; set; }

    [ProtoBuf.ProtoMember(9, Name = @"GLGJLJHDLCP")]
    public bool Glgjljhdlcp { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class PunkLordBattleReplay : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"battle_replay_key")]
    [System.ComponentModel.DefaultValue("")]
    public string BattleReplayKey { get; set; } = "";

    [ProtoBuf.ProtoMember(2, Name = @"replay_info")]
    public ReplayInfo ReplayInfo { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class RegionInfo : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"name")]
    [System.ComponentModel.DefaultValue("")]
    public string Name { get; set; } = "";

    [ProtoBuf.ProtoMember(2, Name = @"title")]
    [System.ComponentModel.DefaultValue("")]
    public string Title { get; set; } = "";

    [ProtoBuf.ProtoMember(3, Name = @"dispatch_url")]
    [System.ComponentModel.DefaultValue("")]
    public string DispatchUrl { get; set; } = "";

    [ProtoBuf.ProtoMember(4, Name = @"env_type")]
    [System.ComponentModel.DefaultValue("")]
    public string EnvType { get; set; } = "";

    [ProtoBuf.ProtoMember(5, Name = @"display_name")]
    [System.ComponentModel.DefaultValue("")]
    public string DisplayName { get; set; } = "";

    [ProtoBuf.ProtoMember(6, Name = @"msg")]
    [System.ComponentModel.DefaultValue("")]
    public string Message { get; set; } = "";

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class RegionData : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"retcode")]
    public uint Retcode { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"msg")]
    [System.ComponentModel.DefaultValue("")]
    public string Message { get; set; } = "";

    [ProtoBuf.ProtoMember(3, Name = @"stop_desc")]
    [System.ComponentModel.DefaultValue("")]
    public string StopDesc { get; set; } = "";

    [ProtoBuf.ProtoMember(4, Name = @"region_info_list")]
    public List<RegionInfo> RegionInfoList { get; } = [];

    [ProtoBuf.ProtoMember(5, Name = @"top_server_region_name")]
    [System.ComponentModel.DefaultValue("")]
    public string TopServerRegionName { get; set; } = "";

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class BattleOp : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"turn_counter")]
    public uint TurnCounter { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"state")]
    public uint State { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"action_entity_id")]
    public uint ActionEntityId { get; set; }

    [ProtoBuf.ProtoMember(4, Name = @"target_entity_id")]
    public uint TargetEntityId { get; set; }

    [ProtoBuf.ProtoMember(5, Name = @"op_type")]
    public uint OpType { get; set; }

    [ProtoBuf.ProtoMember(6, Name = @"skill_index")]
    public uint SkillIndex { get; set; }

    [ProtoBuf.ProtoMember(7, Name = @"operation_counter")]
    public uint OperationCounter { get; set; }

    [ProtoBuf.ProtoMember(8, Name = @"FKKFGLEOMIA")]
    [System.ComponentModel.DefaultValue("")]
    public string Fkkfgleomia { get; set; } = "";

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class BattleEquipment : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"id")]
    public uint Id { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"level")]
    public uint Level { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"promotion")]
    public uint Promotion { get; set; }

    [ProtoBuf.ProtoMember(4, Name = @"rank")]
    public uint Rank { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class BattleRelic : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    public BattleRelic()
    {
    }

    public BattleRelic(uint id, uint level, uint mainAffixId)
    {
        Id = id;
        Level = level;
        MainAffixId = mainAffixId;
    }

    [ProtoBuf.ProtoMember(1, Name = @"id")]
    public uint Id { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"level")]
    public uint Level { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"main_affix_id")]
    public uint MainAffixId { get; set; }

    [ProtoBuf.ProtoMember(4, Name = @"sub_affix_list")]
    public List<RelicAffix> SubAffixList { get; } = [];

    [ProtoBuf.ProtoMember(5, Name = @"unique_id")]
    public uint UniqueId { get; set; }

    [ProtoBuf.ProtoMember(6, Name = @"set_id")]
    public uint SetId { get; set; }

    [ProtoBuf.ProtoMember(7, Name = @"type")]
    public uint Type { get; set; }

    [ProtoBuf.ProtoMember(8, Name = @"OBCJNCCMLEA")]
    public uint Obcjnccmlea { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class AvatarSkillTree : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"point_id")]
    public uint PointId { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"level")]
    public uint Level { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class RelicAffix : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    public RelicAffix()
    {
    }

    public RelicAffix(uint affixId, uint step)
    {
        AffixId = affixId;
        Step = step;
    }

    [ProtoBuf.ProtoMember(1, Name = @"affix_id")]
    public uint AffixId { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"cnt")]
    public uint Cnt { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"step")]
    public uint Step { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract(Name = @"FKIAJNMJPDM")]
public class Fkiajnmjpdm : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"HDONMHMLKEN")]
    public bool Hdonmhmlken { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"MGDLDADHIDJ", IsPacked = true)]
    public uint[] Mgdldadhidjs { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"BMCIAGINOOB")]
    public uint Bmciaginoob { get; set; }

    [ProtoBuf.ProtoMember(4, Name = @"OJHFGPLMHFB")]
    public uint Ojhfgplmhfb { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class BattleAvatar : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"avatar_type")]
    public AvatarType AvatarType { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"id")]
    public uint Id { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"level")]
    public uint Level { get; set; }

    [ProtoBuf.ProtoMember(4, Name = @"rank")]
    public uint Rank { get; set; }

    [ProtoBuf.ProtoMember(5, Name = @"index")]
    public uint Index { get; set; }

    [ProtoBuf.ProtoMember(6, Name = @"skilltree_list")]
    public List<AvatarSkillTree> SkilltreeList { get; } = [];

    [ProtoBuf.ProtoMember(7, Name = @"equipment_list")]
    public List<BattleEquipment> EquipmentList { get; } = [];

    [ProtoBuf.ProtoMember(8, Name = @"hp")]
    public uint Hp { get; set; }

    [ProtoBuf.ProtoMember(10, Name = @"promotion")]
    public uint Promotion { get; set; }

    [ProtoBuf.ProtoMember(11, Name = @"relic_list")]
    public List<BattleRelic> RelicList { get; } = [];

    [ProtoBuf.ProtoMember(12, Name = @"world_level")]
    public uint WorldLevel { get; set; }

    [ProtoBuf.ProtoMember(13, Name = @"assist_uid")]
    public uint AssistUId { get; set; }

    [ProtoBuf.ProtoMember(15, Name = @"GLOIEMCJBHE")]
    public Fkiajnmjpdm Gloiemcjbhe { get; set; }

    [ProtoBuf.ProtoMember(16, Name = @"sp")]
    public AmountInfo Sp { get; set; }

    [ProtoBuf.ProtoMember(17, Name = @"OFLJKBEBMAE")]
    public uint Ofljkbebmae { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class BattleMonsterParam : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"NKLFOILJMIH")]
    public uint Nklfoiljmih { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"level")]
    public uint Level { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"FELEMAKHCPH")]
    public uint Felemakhcph { get; set; }

    [ProtoBuf.ProtoMember(4, Name = @"JLILIHGMPPM")]
    public uint Jlilihgmppm { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class BattleMonster : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"monster_id")]
    public uint MonsterId { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"KFKAAJADNJL")]
    public uint Kfkaajadnjl { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"max_hp")]
    public uint MaxHp { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class BattleMonsterWave : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"monster_list")]
    public List<BattleMonster> MonsterList { get; } = [];

    [ProtoBuf.ProtoMember(2, Name = @"monster_param")]
    public BattleMonsterParam MonsterParam { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"HKFBHHKNBDG")]
    public uint Hkfbhhknbdg { get; set; }

    [ProtoBuf.ProtoMember(4, Name = @"PKGENFBHOFI")]
    public uint Pkgenfbhofi { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class BattleBuff : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"id")]
    public uint Id { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"level")]
    public uint Level { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"ELEPLPPDJBO")]
    public uint Eleplppdjbo { get; set; }

    [ProtoBuf.ProtoMember(4, Name = @"BBBEJILFDHI")]
    public uint Bbbejilfdhi { get; set; }

    [ProtoBuf.ProtoMember(5, Name = @"DFCJFLHMKCH", IsPacked = true)]
    public uint[] Dfcjflhmkchs { get; set; }

    [ProtoBuf.ProtoMember(6, Name = @"GPIJNFKGGND")]
    [ProtoBuf.ProtoMap]
    public Dictionary<string, float> Gpijnfkggnds { get; } = new();

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract(Name = @"KKAGIMFLMBB")]
public class Kkagimflmbb : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"id")]
    public uint Id { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"OIMNDJGCKDM")]
    public uint Oimndjgckdm { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"BIACCEHFGLH")]
    public uint Biaccehfglh { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract(Name = @"KFEMKCOFOFA")]
public class Kfemkcofofa : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"MFHEHDHGKEC")]
    public uint Mfhehdhgkec { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract(Name = @"LEFNJGKGCLK")]
public class Lefnjgkgclk : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"id")]
    public uint Id { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"OIMNDJGCKDM")]
    public uint Oimndjgckdm { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract(Name = @"CHPFLAGEJDK")]
public class Chpflagejdk : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"id")]
    public uint Id { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"progress")]
    public uint Progress { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class BattleTargetInfo : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"id")]
    public uint Id { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"progress")]
    public uint Progress { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"BIACCEHFGLH")]
    public uint Biaccehfglh { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class BattleTargeList : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"AKHBFOMJEIB")]
    public List<BattleTargetInfo> Akhbfomjeibs { get; } = [];

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class BattleLineup : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"avatar_list")]
    public List<BattleAvatar> AvatarList { get; } = [];

    [ProtoBuf.ProtoMember(2, Name = @"monster_wave_list")]
    public List<BattleMonsterWave> MonsterWaveList { get; } = [];

    [ProtoBuf.ProtoMember(3, Name = @"buff_list")]
    public List<BattleBuff> BuffList { get; } = [];

    [ProtoBuf.ProtoMember(7, Name = @"world_level")]
    public uint WorldLevel { get; set; }

    [ProtoBuf.ProtoMember(9, Name = @"battle_targe_info")]
    [ProtoBuf.ProtoMap]
    public Dictionary<uint, BattleTargeList> BattleTargeInfoes { get; } = new();

    [ProtoBuf.ProtoMember(10, Name = @"DPMFDAJGOAF")]
    public Kfemkcofofa Dpmfdajgoaf { get; set; }

    [ProtoBuf.ProtoMember(11, Name = @"BHPBFPNLDJB")]
    public List<BattleAvatar> Bhpbfpnldjbs { get; } = [];

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class BattleMechanismBar : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"mechainsm_bar_id")]
    public uint MechanismBarId { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"value")]
    public uint Value { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class AetherBattleAvatar : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"id")]
    public uint Id { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"index")]
    public uint Index { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"promotion")]
    public uint Promotion { get; set; }

    [ProtoBuf.ProtoMember(4, Name = @"passive_skill_item_list", IsPacked = true)]
    public uint[] PassiveSkillItemList { get; set; }

    [ProtoBuf.ProtoMember(5, Name = @"ACFEACOBHNN")]
    public AetherDivideSpiritLineupType Acfeacobhnn { get; set; }

    [ProtoBuf.ProtoMember(6, Name = @"sp")]
    public AmountInfo Sp { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract(Name = @"AOICDHNIAEL")]
public class Aoicdhniael : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"avatar_list")]
    public List<AetherBattleAvatar> AvatarList { get; } = [];

    [ProtoBuf.ProtoMember(2, Name = @"monster_wave_list")]
    public List<BattleMonsterWave> MonsterWaveList { get; } = [];

    [ProtoBuf.ProtoMember(3, Name = @"buff_list")]
    public List<BattleBuff> BuffList { get; } = [];

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class ClientTurnSnapshot : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"MIEPIMPPPGN")]
    public uint Miepimpppgn { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"EGMJAMJICEK")]
    public uint Egmjamjicek { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"CAHBJCDJOGN")]
    public uint Cahbjcdjogn { get; set; }

    [ProtoBuf.ProtoMember(4, Name = @"OPMMPFGFFPP")]
    public List<CharacterSnapshot> Opmmpfgffpps { get; } = [];

    [ProtoBuf.ProtoMember(5, Name = @"MACDBHPGLMF")]
    public List<AnimEventSnapshot> Macdbhpglmfs { get; } = [];

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class GamecoreConfig : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"MPLKPAPHIGL")]
    public bool Mplkpaphigl { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"KCAMPDAAGID")]
    public uint Kcampdaagid { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"is_auto_fight")]
    public bool IsAutoFight { get; set; }

    [ProtoBuf.ProtoMember(4, Name = @"OBMJAFIFFCM")]
    [System.ComponentModel.DefaultValue("")]
    public string Obmjafiffcm { get; set; } = "";

    [ProtoBuf.ProtoMember(5, Name = @"PIDHLPMBDCA")]
    public bool Pidhlpmbdca { get; set; }

    [ProtoBuf.ProtoMember(6, Name = @"BAFLAHJLFKA")]
    public bool Baflahjlfka { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class BattleBuffMsg : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"DDGDLCAGDPL", IsPacked = true)]
    public uint[] Ddgdlcagdpls { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"KBKDAHBAKKD", IsPacked = true)]
    public uint[] Kbkdahbakkds { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"EGMKNBHIHDH", IsPacked = true)]
    public uint[] Egmknbhihdhs { get; set; }

    [ProtoBuf.ProtoMember(4, Name = @"LGKNFHGDMPL", IsPacked = true)]
    public uint[] Lgknfhgdmpls { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract(Name = @"BKAKLLBMJEC")]
public class Bkakllbmjec : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"CDDEJFHOFIG")]
    public uint Cddejfhofig { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"IEIDKCNMFGI")]
    public uint Ieidkcnmfgi { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract(Name = @"CBHANGPOLFO")]
public class Cbhangpolfo : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"FJDLCBPCGLP")]
    public bool Fjdlcbpcglp { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"LDMOHHALNLD")]
    [ProtoBuf.ProtoMap]
    public Dictionary<string, Bkakllbmjec> Ldmohhalnlds { get; } = new();

    [ProtoBuf.ProtoMember(3, Name = @"NCLLJNOAOJL")]
    public byte[] Nclljnoaojl { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract(Name = @"DNLFPAFMDAG")]
public class Dnlfpafmdag : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"AOJHLEENMBC")]
    public List<ClientTurnSnapshot> Aojhleenmbcs { get; } = [];

    [ProtoBuf.ProtoMember(2, Name = @"BNIPCLEIKAN")]
    [System.ComponentModel.DefaultValue("")]
    public string Bnipcleikan { get; set; } = "";

    [ProtoBuf.ProtoMember(3, Name = @"CIFGHFCPCCP")]
    [System.ComponentModel.DefaultValue("")]
    public string Cifghfcpccp { get; set; } = "";

    [ProtoBuf.ProtoMember(4, Name = @"KPNMIIGLFBE")]
    public List<BattleReplayStringHash> Kpnmiiglfbes { get; } = [];

    [ProtoBuf.ProtoMember(5, Name = @"plane_id")]
    public uint PlaneId { get; set; }

    [ProtoBuf.ProtoMember(6, Name = @"floor_id")]
    public uint FloorId { get; set; }

    [ProtoBuf.ProtoMember(7, Name = @"FPGPHCMIPNG")]
    public uint Fpgphcmipng { get; set; }

    [ProtoBuf.ProtoMember(8, Name = @"IBCPPFGDPNJ")]
    public uint Ibcppfgdpnj { get; set; }

    [ProtoBuf.ProtoMember(9, Name = @"HEHEOEIIFIE")]
    public Cbhangpolfo Heheoeiifie { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class BattleReplay : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"version")]
    public uint Version { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"logic_random_seed")]
    public uint LogicRandomSeed { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"stage_id")]
    public uint StageId { get; set; }

    [ProtoBuf.ProtoMember(4, Name = @"lineup")]
    public BattleLineup Lineup { get; set; }

    [ProtoBuf.ProtoMember(5, Name = @"IINFFJLGCDP")]
    public List<BattleOp> BattleOpList { get; } = [];

    [ProtoBuf.ProtoMember(6, Name = @"turn_snapshot_hash")]
    public byte[] TurnSnapshotHash { get; set; }

    [ProtoBuf.ProtoMember(7, Name = @"maze_plane_id")]
    public uint MazePlaneId { get; set; }

    [ProtoBuf.ProtoMember(8, Name = @"extra_ability_list", IsPacked = true)]
    public uint[] ExtraAbilityList { get; set; }

    [ProtoBuf.ProtoMember(9, Name = @"is_ai_consider_ultra_skill")]
    public bool IsAiConsiderUltraSkill { get; set; }

    [ProtoBuf.ProtoMember(10, Name = @"check_strategy")]
    public BattleCheckStrategyType CheckStrategy { get; set; }

    [ProtoBuf.ProtoMember(11, Name = @"battle_module_type")]
    public BattleModuleType BattleModuleType { get; set; }

    [ProtoBuf.ProtoMember(12, Name = @"event_battle_info_list")]
    public List<BattleEventBattleInfo> EventBattleInfoList { get; } = [];

    [ProtoBuf.ProtoMember(13, Name = @"mechanism_bar_info")]
    public BattleMechanismBar MechanismBarInfo { get; set; }

    [ProtoBuf.ProtoMember(14, Name = @"JLMIBPCGFGB")]
    public uint Jlmibpcgfgb { get; set; }

    [ProtoBuf.ProtoMember(15, Name = @"config")]
    public GamecoreConfig Config { get; set; }

    [ProtoBuf.ProtoMember(16, Name = @"game_core_log_encode")]
    public byte[] GameCoreLogEncode { get; set; }

    [ProtoBuf.ProtoMember(17, Name = @"client_version")]
    public uint ClientVersion { get; set; }

    [ProtoBuf.ProtoMember(18, Name = @"BJELOIJJFPO")]
    public uint Bjeloijjfpo { get; set; }

    [ProtoBuf.ProtoMember(19, Name = @"NJKLPMEJJOO")]
    public Aoicdhniael Njklpmejjoo { get; set; }

    [ProtoBuf.ProtoMember(100, Name = @"HGOFHFNNOAB")]
    public Dnlfpafmdag Hgofhfnnoab { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class BattleReplayStringHash : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"hash")]
    public int Hash { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"value")]
    [System.ComponentModel.DefaultValue("")]
    public string Value { get; set; } = "";

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class AvatarProperty : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"max_hp")]
    public double MaxHp { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"attack")]
    public double Attack { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"defence")]
    public double Defence { get; set; }

    [ProtoBuf.ProtoMember(4, Name = @"speed")]
    public double Speed { get; set; }

    [ProtoBuf.ProtoMember(5, Name = @"left_hp")]
    public double LeftHp { get; set; }

    [ProtoBuf.ProtoMember(6, Name = @"left_sp")]
    public double LeftSp { get; set; }

    [ProtoBuf.ProtoMember(7, Name = @"max_sp")]
    public double MaxSp { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class EquipmentProperty : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"id")]
    public uint Id { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"rank")]
    public uint Rank { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"promotion")]
    public uint Promotion { get; set; }

    [ProtoBuf.ProtoMember(4, Name = @"level")]
    public uint Level { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class AttackDamageProperty : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"attack_type")]
    [System.ComponentModel.DefaultValue("")]
    public string AttackType { get; set; } = "";

    [ProtoBuf.ProtoMember(2, Name = @"damage")]
    public double Damage { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class SkillUseProperty : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"skill_id")]
    public uint SkillId { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"skill_type")]
    [System.ComponentModel.DefaultValue("")]
    public string SkillType { get; set; } = "";

    [ProtoBuf.ProtoMember(3, Name = @"skill_level")]
    public uint SkillLevel { get; set; }

    [ProtoBuf.ProtoMember(4, Name = @"skill_use_count")]
    public uint SkillUseCount { get; set; }

    [ProtoBuf.ProtoMember(5, Name = @"GJAIHJLFGJM")]
    public uint Gjaihjlfgjm { get; set; }

    [ProtoBuf.ProtoMember(6, Name = @"DNAMEJHAJKJ")]
    public uint Dnamejhajkj { get; set; }

    [ProtoBuf.ProtoMember(7, Name = @"KCBFDOADDND")]
    public uint Kcbfdoaddnd { get; set; }

    [ProtoBuf.ProtoMember(8, Name = @"AKMGMCBDEEI")]
    public uint Akmgmcbdeei { get; set; }

    [ProtoBuf.ProtoMember(9, Name = @"PMMKAKKGIKN")]
    public uint Pmmkakkgikn { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract(Name = @"DPBHOILPEPM")]
public class SkillInfo : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"skill_id")]
    public uint SkillId { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"LOHNNCKGMLK")]
    public double Lohnnckgmlk { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"AKHBFOMJEIB", IsPacked = true)]
    public uint[] Akhbfomjeibs { get; set; }

    [ProtoBuf.ProtoMember(4, Name = @"damage")]
    public double Damage { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class SpAddSource : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"source")]
    [System.ComponentModel.DefaultValue("")]
    public string Source { get; set; } = "";

    [ProtoBuf.ProtoMember(2, Name = @"sp_add")]
    public uint SpAdd { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class AbilityUseStt : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"DIMDKGKIJAP")]
    [System.ComponentModel.DefaultValue("")]
    public string Dimdkgkijap { get; set; } = "";

    [ProtoBuf.ProtoMember(2, Name = @"count")]
    public uint Count { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"total_damage")]
    public double TotalDamage { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class AvatarBattleInfo : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"avatar_type")]
    public AvatarType AvatarType { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"id")]
    public uint Id { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"avatar_level")]
    public uint AvatarLevel { get; set; }

    [ProtoBuf.ProtoMember(4, Name = @"avatar_rank")]
    public uint AvatarRank { get; set; }

    [ProtoBuf.ProtoMember(5, Name = @"avatar_promotion")]
    public uint AvatarPromotion { get; set; }

    [ProtoBuf.ProtoMember(6, Name = @"avatar_status")]
    public AvatarProperty AvatarStatus { get; set; }

    [ProtoBuf.ProtoMember(7, Name = @"avatar_skill")]
    public List<AvatarSkillTree> AvatarSkills { get; } = [];

    [ProtoBuf.ProtoMember(8, Name = @"avatar_equipment")]
    public List<EquipmentProperty> AvatarEquipments { get; } = [];

    [ProtoBuf.ProtoMember(9, Name = @"total_turns")]
    public uint TotalTurns { get; set; }

    [ProtoBuf.ProtoMember(10, Name = @"total_damage")]
    public double TotalDamage { get; set; }

    [ProtoBuf.ProtoMember(11, Name = @"total_heal")]
    public double TotalHeal { get; set; }

    [ProtoBuf.ProtoMember(12, Name = @"total_damage_taken")]
    public double TotalDamageTaken { get; set; }

    [ProtoBuf.ProtoMember(13, Name = @"total_hp_recover")]
    public double TotalHpRecover { get; set; }

    [ProtoBuf.ProtoMember(14, Name = @"total_sp_cost")]
    public double TotalSpCost { get; set; }

    [ProtoBuf.ProtoMember(15, Name = @"stage_id")]
    public uint StageId { get; set; }

    [ProtoBuf.ProtoMember(16, Name = @"stage_type")]
    public uint StageType { get; set; }

    [ProtoBuf.ProtoMember(17, Name = @"total_break_damage")]
    public double TotalBreakDamage { get; set; }

    [ProtoBuf.ProtoMember(18, Name = @"attack_type_damage")]
    public List<AttackDamageProperty> AttackTypeDamages { get; } = [];

    [ProtoBuf.ProtoMember(19, Name = @"attack_type_break_damage")]
    public List<AttackDamageProperty> AttackTypeBreakDamages { get; } = [];

    [ProtoBuf.ProtoMember(20, Name = @"attack_type_max_damage")]
    public List<AttackDamageProperty> AttackTypeMaxDamages { get; } = [];

    [ProtoBuf.ProtoMember(21, Name = @"skill_times")]
    public List<SkillUseProperty> SkillTimes { get; } = [];

    [ProtoBuf.ProtoMember(22, Name = @"delay_cumulate")]
    public double DelayCumulate { get; set; }

    [ProtoBuf.ProtoMember(23, Name = @"total_sp_add")]
    public uint TotalSpAdd { get; set; }

    [ProtoBuf.ProtoMember(24, Name = @"sp_add_source")]
    public List<SpAddSource> SpAddSources { get; } = [];

    [ProtoBuf.ProtoMember(25, Name = @"total_bp_cost")]
    public uint TotalBpCost { get; set; }

    [ProtoBuf.ProtoMember(26, Name = @"die_times")]
    public uint DieTimes { get; set; }

    [ProtoBuf.ProtoMember(27, Name = @"revive_times")]
    public uint ReviveTimes { get; set; }

    [ProtoBuf.ProtoMember(28, Name = @"break_times")]
    public uint BreakTimes { get; set; }

    [ProtoBuf.ProtoMember(29, Name = @"extra_turns")]
    public uint ExtraTurns { get; set; }

    [ProtoBuf.ProtoMember(30, Name = @"total_shield")]
    public double TotalShield { get; set; }

    [ProtoBuf.ProtoMember(31, Name = @"total_shield_taken")]
    public double TotalShieldTaken { get; set; }

    [ProtoBuf.ProtoMember(32, Name = @"total_shield_damage")]
    public double TotalShieldDamage { get; set; }

    [ProtoBuf.ProtoMember(33, Name = @"initial_status")]
    public AvatarProperty InitialStatus { get; set; }

    [ProtoBuf.ProtoMember(34, Name = @"relics")]
    public List<BattleRelic> Relics { get; } = [];

    [ProtoBuf.ProtoMember(35, Name = @"assist_uid")]
    public uint AssistUid { get; set; }

    [ProtoBuf.ProtoMember(36, Name = @"ACJFANCIOBD")]
    public List<AttackDamageProperty> Acjfanciobds { get; } = [];

    [ProtoBuf.ProtoMember(37, Name = @"FCOAKKCAGAD")]
    public double Fcoakkcagad { get; set; }

    [ProtoBuf.ProtoMember(38, Name = @"NOAMNPJHDBF")]
    public double Noamnpjhdbf { get; set; }

    [ProtoBuf.ProtoMember(39, Name = @"FLBCBOHMGKK")]
    public double Flbcbohmgkk { get; set; }

    [ProtoBuf.ProtoMember(40, Name = @"IABIBPCGLON")]
    public double Iabibpcglon { get; set; }

    [ProtoBuf.ProtoMember(41, Name = @"IHNHNCEFFEK")]
    public List<AbilityUseStt> Ihnhnceffeks { get; } = [];

    [ProtoBuf.ProtoMember(42, Name = @"DDPCGFJFEBJ")]
    public uint Ddpcgfjfebj { get; set; }

    [ProtoBuf.ProtoMember(43, Name = @"EPCBEIGABOF")]
    public uint Epcbeigabof { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class MonsterProperty : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"max_hp")]
    public double MaxHp { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"attack")]
    public double Attack { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"defence")]
    public double Defence { get; set; }

    [ProtoBuf.ProtoMember(4, Name = @"shield")]
    public double Shield { get; set; }

    [ProtoBuf.ProtoMember(5, Name = @"speed")]
    public double Speed { get; set; }

    [ProtoBuf.ProtoMember(6, Name = @"left_hp")]
    public double LeftHp { get; set; }

    [ProtoBuf.ProtoMember(7, Name = @"enter_battle_hp")]
    public double EnterBattleHp { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract(Name = @"JHIHOGOLFKH")]
public class Jhihogolfkh : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"MNGAAOINKCL")]
    public uint Mngaaoinkcl { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"FAPNIMLBAKN")]
    public double Fapnimlbakn { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"BPNMOAFLDJB")]
    public uint Bpnmoafldjb { get; set; }

    [ProtoBuf.ProtoMember(4, Name = @"break_times")]
    public uint BreakTimes { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class MonsterBattleInfo : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"entity_id")]
    public uint EntityId { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"monster_id")]
    public uint MonsterId { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"monster_template_id")]
    public uint MonsterTemplateId { get; set; }

    [ProtoBuf.ProtoMember(4, Name = @"monster_level")]
    public uint MonsterLevel { get; set; }

    [ProtoBuf.ProtoMember(5, Name = @"monster_status")]
    public MonsterProperty MonsterStatus { get; set; }

    [ProtoBuf.ProtoMember(6, Name = @"total_turns")]
    public uint TotalTurns { get; set; }

    [ProtoBuf.ProtoMember(7, Name = @"total_damage")]
    public double TotalDamage { get; set; }

    [ProtoBuf.ProtoMember(8, Name = @"total_heal")]
    public double TotalHeal { get; set; }

    [ProtoBuf.ProtoMember(9, Name = @"total_damage_taken")]
    public double TotalDamageTaken { get; set; }

    [ProtoBuf.ProtoMember(10, Name = @"total_stance_damage_taken")]
    public double TotalStanceDamageTaken { get; set; }

    [ProtoBuf.ProtoMember(11, Name = @"total_hp_recover")]
    public double TotalHpRecover { get; set; }

    [ProtoBuf.ProtoMember(12, Name = @"stage_id")]
    public uint StageId { get; set; }

    [ProtoBuf.ProtoMember(13, Name = @"battle_id")]
    public uint BattleId { get; set; }

    [ProtoBuf.ProtoMember(14, Name = @"monster_type")]
    public uint MonsterType { get; set; }

    [ProtoBuf.ProtoMember(15, Name = @"attack_type_damage")]
    public List<AttackDamageProperty> AttackTypeDamages { get; } = [];

    [ProtoBuf.ProtoMember(16, Name = @"skill_times")]
    public List<SkillUseProperty> SkillTimes { get; } = [];

    [ProtoBuf.ProtoMember(17, Name = @"stage_type")]
    public uint StageType { get; set; }

    [ProtoBuf.ProtoMember(18, Name = @"total_break_damage_taken")]
    public double TotalBreakDamageTaken { get; set; }

    [ProtoBuf.ProtoMember(19, Name = @"delay_cumulate")]
    public double DelayCumulate { get; set; }

    [ProtoBuf.ProtoMember(20, Name = @"death_source")]
    public DeathSourceType DeathSource { get; set; }

    [ProtoBuf.ProtoMember(21, Name = @"wave")]
    public uint Wave { get; set; }

    [ProtoBuf.ProtoMember(22, Name = @"index_in_wave")]
    public int IndexInWave { get; set; }

    [ProtoBuf.ProtoMember(23, Name = @"phase")]
    public uint Phase { get; set; }

    [ProtoBuf.ProtoMember(24, Name = @"max_phase")]
    public uint MaxPhase { get; set; }

    [ProtoBuf.ProtoMember(25, Name = @"battle_tag")]
    public TagType BattleTag { get; set; }

    [ProtoBuf.ProtoMember(26, Name = @"skill_info")]
    public List<SkillInfo> SkillInfoList { get; } = [];

    [ProtoBuf.ProtoMember(27, Name = @"OAPMJGLCOBD")]
    public uint Oapmjglcobd { get; set; }

    [ProtoBuf.ProtoMember(28, Name = @"EJGGMABHEGC")]
    public List<Jhihogolfkh> Ejggmabhegcs { get; } = [];

    [ProtoBuf.ProtoMember(29, Name = @"AIFCAOCMCEO")]
    public uint Aifcaocmceo { get; set; }

    [ProtoBuf.ProtoMember(30, Name = @"NHFFJEDKFKD")]
    public uint Nhffjedkfkd { get; set; }

    [ProtoBuf.ProtoMember(31, Name = @"LHLKKKODKBH")]
    public Ccblmjclpal Lhlkkkodkbh { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class BattleEventProperty : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(2, Name = @"sp")]
    public AmountInfo Sp { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class BattleEventBattleInfo : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"BEOAGDLCFIN")]
    public uint Beoagdlcfin { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"status")]
    public BattleEventProperty Status { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"skill_info")]
    public List<SkillInfo> SkillInfoList { get; } = [];

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class ScoreInfo : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"score")]
    public uint Score { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"score_id")]
    public uint ScoreId { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract(Name = @"HBBJCGIACBE")]
public class Hbbjcgiacbe : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"avatar_id")]
    public uint AvatarId { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"HJOMCJGGHLG", IsPacked = true)]
    public uint[] Hjomcjgghlgs { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"source")]
    public uint Source { get; set; }

    [ProtoBuf.ProtoMember(4, Name = @"damage")]
    public double Damage { get; set; }

    [ProtoBuf.ProtoMember(5, Name = @"DABOPBOFIBL", IsPacked = true)]
    public uint[] Dabopbofibls { get; set; }

    [ProtoBuf.ProtoMember(6, Name = @"MIPBAHKLDKD")]
    public int Mipbahkldkd { get; set; }

    [ProtoBuf.ProtoMember(7, Name = @"AHOAPFNIJNH")]
    public double Ahoapfnijnh { get; set; }

    [ProtoBuf.ProtoMember(8, Name = @"NGOPCAHLLID")]
    public uint Ngopcahllid { get; set; }

    [ProtoBuf.ProtoMember(9, Name = @"wave")]
    public uint Wave { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract(Name = @"BNPNAONEGFI")]
public class Bnpnaonegfi : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"avatar_id")]
    public uint AvatarId { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"FOMDPJFNAPD")]
    public int Fomdpjfnapd { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract(Name = @"DHPGMCHPPAO")]
public class Dhpgmchppao : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"MNGAAOINKCL")]
    public uint Mngaaoinkcl { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"monster_id")]
    public uint MonsterId { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"DCJEHOMLMLG")]
    public List<Bnpnaonegfi> Dcjehomlmlgs { get; } = [];

    [ProtoBuf.ProtoMember(4, Name = @"LOHNNCKGMLK")]
    public uint Lohnnckgmlk { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract(Name = @"KHNCINIALPP")]
public class Khncinialpp : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"type")]
    public BattleStaticticEventType Type { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"DIOCGBGNEML")]
    public uint Diocgbgneml { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"JDHGPNIGEEG")]
    public uint Jdhgpnigeeg { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract(Name = @"JDABOLFIGEK")]
public class Jdabolfigek : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"phase")]
    [System.ComponentModel.DefaultValue("")]
    public string Phase { get; set; } = "";

    [ProtoBuf.ProtoMember(2, Name = @"EIFLJNIDJAP")]
    public float Eifljnidjap { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"GEOKBHIBLCH")]
    public float Geokbhiblch { get; set; }

    [ProtoBuf.ProtoMember(4, Name = @"PLCAIDJFCBP")]
    public uint Plcaidjfcbp { get; set; }

    [ProtoBuf.ProtoMember(5, Name = @"GHNHDBEONHI")]
    public uint Ghnhdbeonhi { get; set; }

    [ProtoBuf.ProtoMember(6, Name = @"JMMBIBDMEPH")]
    public uint Jmmbibdmeph { get; set; }

    [ProtoBuf.ProtoMember(7, Name = @"OINEJMJHGIO")]
    public uint Oinejmjhgio { get; set; }

    [ProtoBuf.ProtoMember(8, Name = @"DCMJEJNCKCO")]
    public uint Dcmjejnckco { get; set; }

    [ProtoBuf.ProtoMember(9, Name = @"IDAFHEANHBE", IsPacked = true)]
    public uint[] Idafheanhbes { get; set; }

    [ProtoBuf.ProtoMember(10, Name = @"ODLCBPPPJCA", IsPacked = true)]
    public uint[] Odlcbpppjcas { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract(Name = @"LMGNIFGCAFN")]
public class Lmgnifgcafn : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"NDLNKOEDPJG")]
    public uint Ndlnkoedpjg { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"PJPMPLOGGGA")]
    public uint Pjpmploggga { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"OONFHGOMDHL")]
    public uint Oonfhgomdhl { get; set; }

    [ProtoBuf.ProtoMember(4, Name = @"IAMBPHCENIG")]
    public uint Iambphcenig { get; set; }

    [ProtoBuf.ProtoMember(5, Name = @"DELFOCGEHDM")]
    public uint Delfocgehdm { get; set; }

    [ProtoBuf.ProtoMember(6, Name = @"HJMPGIHOLFJ")]
    public uint Hjmpgiholfj { get; set; }

    [ProtoBuf.ProtoMember(7, Name = @"ECDPBGBCPHJ", IsPacked = true)]
    public uint[] Ecdpbgbcphjs { get; set; }

    [ProtoBuf.ProtoMember(8, Name = @"CKAJDLKGEEC")]
    public List<Jdabolfigek> Ckajdlkgeecs { get; } = [];

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class BattleStatistics : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"total_battle_turns")]
    public uint TotalBattleTurns { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"total_auto_turns")]
    public uint TotalAutoTurns { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"avatar_id_list", IsPacked = true)]
    public uint[] AvatarIdList { get; set; }

    [ProtoBuf.ProtoMember(4, Name = @"ultra_cnt")]
    public uint UltraCount { get; set; }

    [ProtoBuf.ProtoMember(5, Name = @"cost_time")]
    public double CostTime { get; set; }

    [ProtoBuf.ProtoMember(6, Name = @"total_delay_cumulate")]
    public double TotalDelayCumulate { get; set; }

    [ProtoBuf.ProtoMember(7, Name = @"avatar_battle_list")]
    public List<AvatarBattleInfo> AvatarBattleList { get; } = [];

    [ProtoBuf.ProtoMember(8, Name = @"monster_battle_list")]
    public List<MonsterBattleInfo> MonsterBattleList { get; } = [];

    [ProtoBuf.ProtoMember(9, Name = @"round_cnt")]
    public uint RoundCount { get; set; }

    [ProtoBuf.ProtoMember(10, Name = @"cocoon_dead_wave")]
    public uint CocoonDeadWave { get; set; }

    [ProtoBuf.ProtoMember(11, Name = @"avatar_battle_turns")]
    public uint AvatarBattleTurns { get; set; }

    [ProtoBuf.ProtoMember(12, Name = @"monster_battle_turns")]
    public uint MonsterBattleTurns { get; set; }

    [ProtoBuf.ProtoMember(13, Name = @"CEBDIBDDKNM")]
    [ProtoBuf.ProtoMap]
    public Dictionary<string, float> CustomValues { get; } = new();

    [ProtoBuf.ProtoMember(14, Name = @"challenge_score")]
    public uint ChallengeScore { get; set; }

    [ProtoBuf.ProtoMember(16, Name = @"PJLEHIPDHLB")]
    public List<BattleEventBattleInfo> BattleAvatarList { get; } = [];

    [ProtoBuf.ProtoMember(17, Name = @"mechanism_bar_info")]
    public BattleMechanismBar MechanismBarInfo { get; set; }

    [ProtoBuf.ProtoMember(19, Name = @"HBMFKMHDDDC")]
    public BattleEndReasonType Hbmfkmhdddc { get; set; }

    [ProtoBuf.ProtoMember(21, Name = @"PDMBHMLIEMP")]
    public List<Hbbjcgiacbe> Pdmbhmliemps { get; } = [];

    [ProtoBuf.ProtoMember(22, Name = @"NEOMONBIDOM", IsPacked = true)]
    public int[] Neomonbidoms { get; set; }

    [ProtoBuf.ProtoMember(23, Name = @"GGKCGAPMBMM")]
    public List<Dhpgmchppao> Ggkcgapmbmms { get; } = [];

    [ProtoBuf.ProtoMember(26, Name = @"MCCPLHFPCMP")]
    public List<Khncinialpp> Mccplhfpcmps { get; } = [];

    [ProtoBuf.ProtoMember(27, Name = @"CMHPFPLLKLE")]
    public List<Lnobabnnpmf> Cmhpfpllkles { get; } = [];

    [ProtoBuf.ProtoMember(28, Name = @"battle_targe_info")]
    [ProtoBuf.ProtoMap]
    public Dictionary<uint, BattleTargeList> BattleTargeInfoes { get; } = new();

    [ProtoBuf.ProtoMember(29, Name = @"IMMBPGPEGNG")]
    public List<Oaadpohkbjc> Immbpgpegngs { get; } = [];

    [ProtoBuf.ProtoMember(31, Name = @"JMHFFFNGDEL")]
    public Lmgnifgcafn Jmhfffngdel { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract(Name = @"OAADPOHKBJC")]
public class Oaadpohkbjc : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"BOEEOCIPNEB")]
    public uint Boeeocipneb { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"FIFKIHEEOBG")]
    public uint Fifkiheeobg { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract(Name = @"LNOBABNNPMF")]
public class Lnobabnnpmf : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"type")]
    public AetherDivideSpiritLineupType Type { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"id")]
    public uint Id { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"sp")]
    public AmountInfo Sp { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class HeroPath : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"hero_path_type")]
    public uint HeroPathType { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"level")]
    public uint Level { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"exp")]
    public uint Exp { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class BattleResult : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"retcode")]
    public BattleCheckResultType Retcode { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"end_status")]
    public BattleEndStatus EndStatus { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"stt")]
    public BattleStatistics Stt { get; set; }

    [ProtoBuf.ProtoMember(4, Name = @"game_core_log_encode")]
    public byte[] GameCoreLogEncode { get; set; }

    [ProtoBuf.ProtoMember(5, Name = @"HEFNOOKLPNO")]
    [ProtoBuf.ProtoMap]
    public Dictionary<string, uint> Hefnooklpnoes { get; } = new();

    [ProtoBuf.ProtoMember(6, Name = @"mismatch_turn_count")]
    public uint MismatchTurnCount { get; set; }

    [ProtoBuf.ProtoMember(7, Name = @"GOFMIHJJIBE")]
    public uint Gofmihjjibe { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class CharacterSnapshot : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"runtime_id")]
    public uint RuntimeId { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"properties", IsPacked = true)]
    public ulong[] Properties { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class AnimEventSnapshot : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"event_name")]
    [System.ComponentModel.DefaultValue("")]
    public string EventName { get; set; } = "";

    [ProtoBuf.ProtoMember(2, Name = @"count")]
    public uint Count { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class PlayerGetTokenCsReq : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(2, Name = @"KCNPGDGEMDB")]
    public uint Kcnpgdgemdb { get; set; }

    [ProtoBuf.ProtoMember(7, Name = @"JAIFBOOIDAE")]
    public uint Jaifbooidae { get; set; }

    [ProtoBuf.ProtoMember(11, Name = @"HJMCDOINJBI")]
    [System.ComponentModel.DefaultValue("")]
    public string Hjmcdoinjbi { get; set; } = "";

    [ProtoBuf.ProtoMember(12, Name = @"NAFOGOKMMEI")]
    public uint Nafogokmmei { get; set; }

    [ProtoBuf.ProtoMember(13, Name = @"KBLMDMMCNON")]
    public uint Kblmdmmcnon { get; set; }

    [ProtoBuf.ProtoMember(8, Name = @"EKPNNGIOHFD")]
    [System.ComponentModel.DefaultValue("")]
    public string Ekpnngiohfd { get; set; } = "";

    [ProtoBuf.ProtoMember(15, Name = @"MJNLKEOOOEB")]
    [System.ComponentModel.DefaultValue("")]
    public string Mjnlkeoooeb { get; set; } = "";

    [ProtoBuf.ProtoMember(14, Name = @"uid")]
    public uint Uid { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class PlayerGetTokenScRsp : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(7, Name = @"retcode")]
    public uint Retcode { get; set; }

    [ProtoBuf.ProtoMember(11, Name = @"secret_key_seed")]
    public ulong SecretKeySeed { get; set; }

    [ProtoBuf.ProtoMember(5, Name = @"msg")]
    [System.ComponentModel.DefaultValue("")]
    public string Msg { get; set; } = "";

    [ProtoBuf.ProtoMember(15, Name = @"black_info")]
    public BlackInfo BlackInfo { get; set; }

    [ProtoBuf.ProtoMember(1, Name = @"uid")]
    public uint Uid { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class PlayerLoginCsReq : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(9, Name = @"login_random")]
    public ulong LoginRandom { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class PlayerLoginScRsp : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(15, Name = @"login_random")]
    public ulong LoginRandom { get; set; }

    [ProtoBuf.ProtoMember(1, Name = @"server_timestamp_ms")]
    public ulong ServerTimestampMs { get; set; }

    [ProtoBuf.ProtoMember(6, Name = @"stamina")]
    public uint Stamina { get; set; }

    [ProtoBuf.ProtoMember(10, Name = @"basic_info")]
    public PlayerBasicInfo BasicInfo { get; set; }

    [ProtoBuf.ProtoMember(13, Name = @"retcode")]
    public uint Retcode { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class EquipRelic : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(15, Name = @"relic_unique_id")]
    public uint RelicUniqueId { get; set; }

    [ProtoBuf.ProtoMember(8, Name = @"type")]
    public uint Slot { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class Avatar : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"promotion")]
    public uint Promotion { get; set; }

    [ProtoBuf.ProtoMember(8, Name = @"skilltree_list")]
    public List<AvatarSkillTree> SkilltreeList { get; } = [];

    [ProtoBuf.ProtoMember(3, Name = @"level")]
    public uint Level { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"rank")]
    public uint Rank { get; set; }

    [ProtoBuf.ProtoMember(12, Name = @"exp")]
    public uint Exp { get; set; }

    [ProtoBuf.ProtoMember(10, Name = @"equipment_unique_id")]
    public uint EquipmentUniqueId { get; set; }

    [ProtoBuf.ProtoMember(9, Name = @"base_avatar_id")]
    public uint BaseAvatarId { get; set; }

    [ProtoBuf.ProtoMember(6, Name = @"equip_relic_list")]
    public List<EquipRelic> EquipRelicList { get; } = [];

    [ProtoBuf.ProtoMember(4, Name = @"has_taken_promotion_reward_list", IsPacked = true)]
    public uint[] HasTakenPromotionRewardList { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class GetAvatarDataCsReq : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(7, Name = @"base_avatar_id_list", IsPacked = true)]
    public uint[] BaseAvatarIdList { get; set; }

    [ProtoBuf.ProtoMember(1, Name = @"is_get_all")]
    public bool IsGetAll { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class GetAvatarDataScRsp : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(6, Name = @"is_all")]
    public bool IsAll { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"retcode")]
    public uint Retcode { get; set; }

    [ProtoBuf.ProtoMember(15, Name = @"avatar_list")]
    public List<Avatar> AvatarList { get; } = [];

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class LineupAvatar : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(14, Name = @"slot")]
    public uint Slot { get; set; }

    [ProtoBuf.ProtoMember(13, Name = @"sp")]
    public AmountInfo Sp { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"id")]
    public uint Id { get; set; }

    [ProtoBuf.ProtoMember(7, Name = @"satiety")]
    public uint Satiety { get; set; }

    [ProtoBuf.ProtoMember(6, Name = @"hp")]
    public uint Hp { get; set; }

    [ProtoBuf.ProtoMember(12, Name = @"avatar_type")]
    public AvatarType AvatarType { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class LineupInfo : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(12, Name = @"leader_slot")]
    public uint LeaderSlot { get; set; }

    [ProtoBuf.ProtoMember(3)] public uint DressedSkinId { get; set; }

    [ProtoBuf.ProtoMember(1, Name = @"plane_id")]
    public uint PlaneId { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"is_virtual")]
    public bool IsVirtual { get; set; }

    [ProtoBuf.ProtoMember(9)] public uint Mp { get; set; }

    [ProtoBuf.ProtoMember(11, Name = @"avatar_list")]
    public List<LineupAvatar> AvatarList { get; } = [];

    [ProtoBuf.ProtoMember(6, Name = @"extra_lineup_type")]
    public ExtraLineupType ExtraLineupType { get; set; }

    [ProtoBuf.ProtoMember(7, Name = @"index")]
    public uint Index { get; set; }

    [ProtoBuf.ProtoMember(8, Name = @"Max_Mp")]
    public uint MaxMp { get; set; }

    [ProtoBuf.ProtoMember(15, Name = @"name")]
    [System.ComponentModel.DefaultValue("")]
    public string Name { get; set; } = "";

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class GetAllLineupDataCsReq : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class GetAllLineupDataScRsp : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"cur_index")]
    public uint CurIndex { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"lineup_list")]
    public List<LineupInfo> LineupList { get; } = [];

    [ProtoBuf.ProtoMember(4, Name = @"retcode")]
    public uint Retcode { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class ChangeLineupLeaderCsReq : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"slot")]
    public uint Slot { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class ChangeLineupLeaderScRsp : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(8, Name = @"slot")]
    public uint Slot { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"retcode")]
    public uint Retcode { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class JoinLineupCsReq : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(8, Name = @"plane_id")]
    public uint PlaneId { get; set; }

    [ProtoBuf.ProtoMember(12, Name = @"base_avatar_id")]
    public uint BaseAvatarId { get; set; }

    [ProtoBuf.ProtoMember(9, Name = @"extra_lineup_type")]
    public ExtraLineupType ExtraLineupType { get; set; }

    [ProtoBuf.ProtoMember(4, Name = @"is_virtual")]
    public bool IsVirtual { get; set; }

    [ProtoBuf.ProtoMember(11, Name = @"index")]
    public uint Index { get; set; }

    [ProtoBuf.ProtoMember(13, Name = @"avatar_type")]
    public AvatarType AvatarType { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"slot")]
    public uint Slot { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class JoinLineupScRsp : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"retcode")]
    public uint Retcode { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class LineupSlotData : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(4, Name = @"id")]
    public uint Id { get; set; }

    [ProtoBuf.ProtoMember(1, Name = @"avatar_type")]
    public AvatarType AvatarType { get; set; }

    [ProtoBuf.ProtoMember(11, Name = @"slot")]
    public uint Slot { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class ReplaceLineupCsReq : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(3, Name = @"lineup_slot_list")]
    public List<LineupSlotData> LineupSlotList { get; } = [];

    [ProtoBuf.ProtoMember(8, Name = @"plane_id")]
    public uint PlaneId { get; set; }

    [ProtoBuf.ProtoMember(14, Name = @"leader_slot")]
    public uint LeaderSlot { get; set; }

    [ProtoBuf.ProtoMember(5, Name = @"index")]
    public uint Index { get; set; }

    [ProtoBuf.ProtoMember(7, Name = @"is_virtual")]
    public bool IsVirtual { get; set; }

    [ProtoBuf.ProtoMember(13)] public uint DressedSkinId { get; set; }

    [ProtoBuf.ProtoMember(12, Name = @"extra_lineup_type")]
    public ExtraLineupType ExtraLineupType { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class ReplaceLineupScRsp : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(3, Name = @"retcode")]
    public uint Retcode { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class QuitLineupCsReq : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(13, Name = @"plane_id")]
    public uint PlaneId { get; set; }

    [ProtoBuf.ProtoMember(15, Name = @"base_avatar_id")]
    public uint BaseAvatarId { get; set; }

    [ProtoBuf.ProtoMember(12, Name = @"index")]
    public uint Index { get; set; }

    [ProtoBuf.ProtoMember(5, Name = @"avatar_type")]
    public AvatarType AvatarType { get; set; }

    [ProtoBuf.ProtoMember(8, Name = @"extra_lineup_type")]
    public ExtraLineupType ExtraLineupType { get; set; }

    [ProtoBuf.ProtoMember(7, Name = @"is_virtual")]
    public bool IsVirtual { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class QuitLineupScRsp : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(4, Name = @"is_virtual")]
    public bool IsVirtual { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"retcode")]
    public uint Retcode { get; set; }

    [ProtoBuf.ProtoMember(15, Name = @"plane_id")]
    public uint PlaneId { get; set; }

    [ProtoBuf.ProtoMember(8, Name = @"base_avatar_id")]
    public uint BaseAvatarId { get; set; }

    [ProtoBuf.ProtoMember(6, Name = @"is_mainline")]
    public bool IsMainline { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class SyncLineupNotify : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(6, Name = @"lineup")]
    public LineupInfo Lineup { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class GetCurLineupDataCsReq : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class GetCurLineupDataScRsp : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(2, Name = @"retcode")]
    public uint Retcode { get; set; }

    [ProtoBuf.ProtoMember(1, Name = @"lineup")]
    public LineupInfo Lineup { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class GetMissionStatusCsReq : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(13, Name = @"main_mission_id_list", IsPacked = true)]
    public uint[] MainMissionIdList { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"sub_mission_id_list", IsPacked = true)]
    public uint[] SubMissionIdList { get; set; }

    [ProtoBuf.ProtoMember(8, Name = @"mission_event_id_list", IsPacked = true)]
    public uint[] MissionEventIdList { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class Mission : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(3, Name = @"progress")]
    public uint Progress { get; set; }

    [ProtoBuf.ProtoMember(4, Name = @"id")]
    public uint Id { get; set; }

    [ProtoBuf.ProtoMember(1, Name = @"status")]
    public MissionStatus Status { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class GetMissionStatusScRsp : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(5, Name = @"sub_mission_status_list")]
    public List<Mission> SubMissionStatusList { get; } = [];

    [ProtoBuf.ProtoMember(6, Name = @"mission_event_status_list")]
    public List<Mission> MissionEventStatusList { get; } = [];

    [ProtoBuf.ProtoMember(9, Name = @"unfinished_main_mission_id_list", IsPacked = true)]
    public uint[] UnfinishedMainMissionIdList { get; set; }

    [ProtoBuf.ProtoMember(14, Name = @"finished_main_mission_id_list", IsPacked = true)]
    public uint[] FinishedMainMissionIdList { get; set; }

    [ProtoBuf.ProtoMember(13, Name = @"disabled_main_mission_id_list", IsPacked = true)]
    public uint[] DisabledMainMissionIdList { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"retcode")]
    public uint Retcode { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class GetCurSceneInfoCsReq : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class Vector : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(7, Name = @"y", DataFormat = ProtoBuf.DataFormat.ZigZag)]
    public int Y { get; set; }

    [ProtoBuf.ProtoMember(9, Name = @"z", DataFormat = ProtoBuf.DataFormat.ZigZag)]
    public int Z { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"x", DataFormat = ProtoBuf.DataFormat.ZigZag)]
    public int X { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class MotionInfo : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(6)] public Vector Pos { get; set; }

    [ProtoBuf.ProtoMember(2)] public Vector Rot { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class SceneActorInfo : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(2, Name = @"uid")]
    public uint Uid { get; set; }

    [ProtoBuf.ProtoMember(6, Name = @"base_avatar_id")]
    public uint BaseAvatarId { get; set; }

    [ProtoBuf.ProtoMember(12, Name = @"avatar_type")]
    public AvatarType AvatarType { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class SceneNpcMonsterInfo : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(14, Name = @"event_id")]
    public uint EventId { get; set; }

    [ProtoBuf.ProtoMember(11, Name = @"monster_id")]
    public uint MonsterId { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"world_level")]
    public uint WorldLevel { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class SceneNpcInfo : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(6, Name = @"npc_id")]
    public uint NpcId { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class ScenePropInfo : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(3, Name = @"prop_state")]
    public uint PropState { get; set; }

    [ProtoBuf.ProtoMember(5, Name = @"create_time_ms")]
    public ulong CreateTimeMs { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"life_time_ms")]
    public uint LifeTimeMs { get; set; }

    [ProtoBuf.ProtoMember(10, Name = @"prop_id")]
    public uint PropId { get; set; }

    [ProtoBuf.ProtoMember(14, Name = @"trigger_name_list")]
    public List<string> TriggerNameList { get; } = [];

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class SceneEntityInfo : ProtoBuf.IExtensible
{
    private ProtoBuf.DiscriminatedUnionObject __pbn__EntityOneofCase;
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(4, Name = @"motion")]
    public MotionInfo Motion { get; set; }

    [ProtoBuf.ProtoMember(13, Name = @"entity_id")]
    public uint EntityId { get; set; }

    [ProtoBuf.ProtoMember(5, Name = @"group_id")]
    public uint GroupId { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"inst_id")]
    public uint InstId { get; set; }

    [ProtoBuf.ProtoMember(11, Name = @"actor")]
    public SceneActorInfo Actor
    {
        get => __pbn__EntityOneofCase.Is(11) ? ((SceneActorInfo)__pbn__EntityOneofCase.Object) : default;
        set => __pbn__EntityOneofCase = new(11, value);
    }

    [ProtoBuf.ProtoMember(12, Name = @"npc_monster")]
    public SceneNpcMonsterInfo NpcMonster
    {
        get => __pbn__EntityOneofCase.Is(12) ? ((SceneNpcMonsterInfo)__pbn__EntityOneofCase.Object) : default;
        set => __pbn__EntityOneofCase = new(12, value);
    }

    [ProtoBuf.ProtoMember(8, Name = @"npc")]
    public SceneNpcInfo Npc
    {
        get => __pbn__EntityOneofCase.Is(8) ? ((SceneNpcInfo)__pbn__EntityOneofCase.Object) : default;
        set => __pbn__EntityOneofCase = new(8, value);
    }

    [ProtoBuf.ProtoMember(10, Name = @"prop")]
    public ScenePropInfo Prop
    {
        get => __pbn__EntityOneofCase.Is(10) ? ((ScenePropInfo)__pbn__EntityOneofCase.Object) : default;
        set => __pbn__EntityOneofCase = new(10, value);
    }

    [ProtoBuf.ProtoMember(9, Name = @"summon_unit")]
    public SceneSummonUnitInfo SummonUnit
    {
        get => __pbn__EntityOneofCase.Is(9) ? ((SceneSummonUnitInfo)__pbn__EntityOneofCase.Object) : default;
        set => __pbn__EntityOneofCase = new(9, value);
    }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    public bool ShouldSerializeActor() => __pbn__EntityOneofCase.Is(11);
    public void ResetActor() => ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__EntityOneofCase, 11);
    public bool ShouldSerializeNpcMonster() => __pbn__EntityOneofCase.Is(12);
    public void ResetNpcMonster() => ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__EntityOneofCase, 12);
    public bool ShouldSerializeNpc() => __pbn__EntityOneofCase.Is(8);
    public void ResetNpc() => ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__EntityOneofCase, 8);
    public bool ShouldSerializeProp() => __pbn__EntityOneofCase.Is(10);
    public void ResetProp() => ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__EntityOneofCase, 10);
    public bool ShouldSerializeSummonUnit() => __pbn__EntityOneofCase.Is(9);
    public void ResetSummonUnit() => ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__EntityOneofCase, 9);
}

[ProtoBuf.ProtoContract]
public class SceneSummonUnitInfo : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(13, Name = @"create_time_ms")]
    public ulong CreateTimeMs { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"life_time_ms")]
    public int LifeTimeMs { get; set; }

    [ProtoBuf.ProtoMember(4, Name = @"trigger_name_list")]
    public List<string> TriggerNameList { get; } = [];

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class SceneGroupEntityInfo : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(8, Name = @"group_id")]
    public uint GroupId { get; set; }

    [ProtoBuf.ProtoMember(7, Name = @"state")]
    public uint State { get; set; }

    [ProtoBuf.ProtoMember(12, Name = @"entity_list")]
    public List<SceneEntityInfo> EntityList { get; } = [];

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class MechanismBarInfo : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(8, Name = @"mechainsm_bar_id")]
    public uint MechainsmBarId { get; set; }

    [ProtoBuf.ProtoMember(13, Name = @"value")]
    public uint Value { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract(Name = @"LNLDBAOAEEP")]
public class Lnldbaoaeep : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(8, Name = @"buff_id")]
    public uint BuffId { get; set; }

    [ProtoBuf.ProtoMember(4, Name = @"base_avatar_id")]
    public uint BaseAvatarId { get; set; }

    [ProtoBuf.ProtoMember(5, Name = @"LIPPLLMGIJA")]
    public ulong Lippllmgija { get; set; }

    [ProtoBuf.ProtoMember(10, Name = @"NEJLECBKHJG")]
    public float Nejlecbkhjg { get; set; }

    [ProtoBuf.ProtoMember(1, Name = @"GPIJNFKGGND")]
    [ProtoBuf.ProtoMap]
    public Dictionary<string, float> Gpijnfkggnds { get; } = new();

    [ProtoBuf.ProtoMember(11, Name = @"count")]
    public uint Count { get; set; }

    [ProtoBuf.ProtoMember(6, Name = @"KDILKAPMIOI")]
    public uint Kdilkapmioi { get; set; }

    [ProtoBuf.ProtoMember(13, Name = @"level")]
    public uint Level { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class EntityBuffInfo : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(6, Name = @"entity_id")]
    public uint EntityId { get; set; }

    [ProtoBuf.ProtoMember(11, Name = @"buff_list")]
    public List<Lnldbaoaeep> BuffList { get; } = [];

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class ClientGroupInfo : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(10, Name = @"group_id")]
    public uint GroupId { get; set; }

    [ProtoBuf.ProtoMember(5, Name = @"AKEBFHAGNDH")]
    public bool Akebfhagndh { get; set; }

    [ProtoBuf.ProtoMember(4, Name = @"state")]
    public uint State { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class SceneInfo : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1649, Name = @"scene_group_entity_list")]
    public List<SceneGroupEntityInfo> SceneGroupEntityList { get; } = [];

    [ProtoBuf.ProtoMember(7, Name = @"client_pos_version")]
    public uint ClientPosVersion { get; set; }

    [ProtoBuf.ProtoMember(13, Name = @"group_id_list", IsPacked = true)]
    public uint[] GroupIdList { get; set; }

    [ProtoBuf.ProtoMember(8, Name = @"plane_id")]
    public uint PlaneId { get; set; }

    [ProtoBuf.ProtoMember(11, Name = @"world_id")]
    public uint WorldId { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"lighten_section_list", IsPacked = true)]
    public uint[] LightenSectionList { get; set; }

    [ProtoBuf.ProtoMember(10, Name = @"floor_id")]
    public uint FloorId { get; set; }

    [ProtoBuf.ProtoMember(5, Name = @"entry_id")]
    public uint EntryId { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"game_mode_type")]
    public uint GameModeType { get; set; }

    [ProtoBuf.ProtoMember(9, Name = @"mechanism_bar_info")]
    public MechanismBarInfo MechanismBarInfo { get; set; }

    [ProtoBuf.ProtoMember(6, Name = @"entity_list")]
    public List<SceneEntityInfo> EntityList { get; } = [];

    [ProtoBuf.ProtoMember(1, Name = @"entity_buff_list")]
    public List<EntityBuffInfo> EntityBuffList { get; } = [];

    [ProtoBuf.ProtoMember(1244, Name = @"client_group_list")]
    public List<ClientGroupInfo> ClientGroupList { get; } = [];

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class GetCurSceneInfoScRsp : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(8, Name = @"retcode")]
    public uint Retcode { get; set; }

    [ProtoBuf.ProtoMember(9, Name = @"scene")]
    public SceneInfo Scene { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class GetHeroBasicTypeInfoCsReq : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class PlayerHeroBasicTypeInfo : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(15, Name = @"KNHAECBAFBA")]
    public List<AvatarSkillTree> AvatarSkillTreeList { get; } = [];

    [ProtoBuf.ProtoMember(2, Name = @"basic_type")]
    public HeroBasicType BasicType { get; set; }

    [ProtoBuf.ProtoMember(14, Name = @"rank")]
    public uint Rank { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class GetHeroBasicTypeInfoScRsp : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(2, Name = @"basic_type_info_list")]
    public List<PlayerHeroBasicTypeInfo> BasicTypeInfoList { get; } = [];

    [ProtoBuf.ProtoMember(6, Name = @"retcode")]
    public uint Retcode { get; set; }

    [ProtoBuf.ProtoMember(13, Name = @"gender")]
    public Gender Gender { get; set; }

    [ProtoBuf.ProtoMember(5, Name = @"cur_basic_type")]
    public HeroBasicType CurBasicType { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class PlayerHeartBeatCsReq : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(9, Name = @"client_time_ms")]
    public ulong ClientTimeMs { get; set; }

    [ProtoBuf.ProtoMember(10, Name = @"upload_data")]
    public ClientUploadData UploadData { get; set; }

    [ProtoBuf.ProtoMember(5, Name = @"FDHDLKJDEIM")]
    public uint Fdhdlkjdeim { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class PlayerHeartBeatScRsp : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(5, Name = @"server_time_ms")]
    public ulong ServerTimeMs { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"download_data")]
    public ClientDownloadData DownloadData { get; set; }

    [ProtoBuf.ProtoMember(1, Name = @"retcode")]
    public uint Retcode { get; set; }

    [ProtoBuf.ProtoMember(12, Name = @"client_time_ms")]
    public ulong ClientTimeMs { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class GetNpcTakenRewardCsReq : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(3, Name = @"npc_id")]
    public uint NpcId { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class GetNpcTakenRewardScRsp : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(5, Name = @"npc_id")]
    public uint NpcId { get; set; }

    [ProtoBuf.ProtoMember(7, Name = @"GGJBDJJGNIG", IsPacked = true)]
    public uint[] Ggjbdjjgnigs { get; set; }

    [ProtoBuf.ProtoMember(8, Name = @"retcode")]
    public uint Retcode { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class GetFirstTalkByPerformanceNpcCsReq : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(3, Name = @"first_talk_id_list", IsPacked = true)]
    public uint[] FirstTalkIdList { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class NpcMeetStatusInfo : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(15, Name = @"meet_id")]
    public uint MeetId { get; set; }

    [ProtoBuf.ProtoMember(9, Name = @"is_meet")]
    public bool IsMeet { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class GetFirstTalkByPerformanceNpcScRsp : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(12, Name = @"npc_meet_status_list")]
    public List<NpcMeetStatusInfo> NpcMeetStatusList { get; } = [];

    [ProtoBuf.ProtoMember(3, Name = @"retcode")]
    public uint Retcode { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class EntityMotion : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(13, Name = @"IGOFMADGFIK")]
    public bool Igofmadgfik { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"entity_id")]
    public uint EntityId { get; set; }

    [ProtoBuf.ProtoMember(1, Name = @"BMAILHLLAFM")]
    public uint MapLayerId { get; set; }

    [ProtoBuf.ProtoMember(6, Name = @"motion")]
    public MotionInfo Motion { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class SceneEntityMoveCsReq : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(3, Name = @"LIEMICMHIPI")]
    public ulong Liemicmhipi { get; set; }

    [ProtoBuf.ProtoMember(5, Name = @"entry_id")]
    public uint EntryId { get; set; }

    [ProtoBuf.ProtoMember(1, Name = @"EBMIIDMOMLM")]
    public List<EntityMotion> EntityMotionList { get; } = [];

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class SceneEntityMoveScRsp : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(3, Name = @"retcode")]
    public uint Retcode { get; set; }

    [ProtoBuf.ProtoMember(9, Name = @"EBMIIDMOMLM")]
    public List<EntityMotion> EntityMotionList { get; } = [];

    [ProtoBuf.ProtoMember(1, Name = @"download_data")]
    public ClientDownloadData DownloadData { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class SceneEntityMoveScNotify : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"entity_id")]
    public uint EntityId { get; set; }

    [ProtoBuf.ProtoMember(10, Name = @"motion")]
    public MotionInfo Motion { get; set; }

    [ProtoBuf.ProtoMember(8, Name = @"entry_id")]
    public uint EntryId { get; set; }

    [ProtoBuf.ProtoMember(6, Name = @"client_pos_version")]
    public uint ClientPosVersion { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class SwapLineupCsReq : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(5, Name = @"index")]
    public uint Index { get; set; }

    [ProtoBuf.ProtoMember(14, Name = @"is_virtual")]
    public bool IsVirtual { get; set; }

    [ProtoBuf.ProtoMember(12, Name = @"OGPANJFALDJ")]
    public uint Ogpanjfaldj { get; set; }

    [ProtoBuf.ProtoMember(1, Name = @"extra_lineup_type")]
    public ExtraLineupType ExtraLineupType { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"OHHFKOGEEGC")]
    public uint Ohhfkogeegc { get; set; }

    [ProtoBuf.ProtoMember(4, Name = @"plane_id")]
    public uint PlaneId { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class SetLineupNameCsReq : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(7, Name = @"index")]
    public uint Index { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"name")]
    [System.ComponentModel.DefaultValue("")]
    public string Name { get; set; } = "";

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class SetLineupNameScRsp : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(9, Name = @"name")]
    [System.ComponentModel.DefaultValue("")]
    public string Name { get; set; } = "";

    [ProtoBuf.ProtoMember(5, Name = @"index")]
    public uint Index { get; set; }

    [ProtoBuf.ProtoMember(13, Name = @"retcode")]
    public uint Retcode { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class StartCocoonStageCsReq : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(3, Name = @"prop_entity_id")]
    public uint PropEntityId { get; set; }

    [ProtoBuf.ProtoMember(12, Name = @"world_level")]
    public uint WorldLevel { get; set; }

    [ProtoBuf.ProtoMember(10, Name = @"wave")]
    public uint Wave { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"cocoon_id")]
    public uint CocoonId { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class SceneMonsterParam : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(4, Name = @"NKLFOILJMIH")]
    public uint Nklfoiljmih { get; set; }

    [ProtoBuf.ProtoMember(6, Name = @"level")]
    public uint Level { get; set; }

    [ProtoBuf.ProtoMember(10, Name = @"JLILIHGMPPM")]
    public uint Jlilihgmppm { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"FELEMAKHCPH")]
    public uint Felemakhcph { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class SceneMonsterInfo : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(5, Name = @"monster_id")]
    public uint MonsterId { get; set; }

    [ProtoBuf.ProtoMember(6, Name = @"cur_hp")]
    public uint CurrentHp { get; set; }

    [ProtoBuf.ProtoMember(10, Name = @"max_hp")]
    public uint MaxHp { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class Item : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(7, Name = @"level")]
    public uint Level { get; set; }

    [ProtoBuf.ProtoMember(14, Name = @"unique_id")]
    public uint UniqueId { get; set; }

    [ProtoBuf.ProtoMember(9, Name = @"num")]
    public uint Num { get; set; }

    [ProtoBuf.ProtoMember(12, Name = @"item_id")]
    public uint ItemId { get; set; }

    [ProtoBuf.ProtoMember(10, Name = @"main_affix_id")]
    public uint MainAffixId { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"rank")]
    public uint Rank { get; set; }

    [ProtoBuf.ProtoMember(1, Name = @"promotion")]
    public uint Promotion { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class ItemList : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(3, Name = @"item_list")]
    public List<Item> Items { get; } = [];

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class SceneMonsterWave : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(5, Name = @"monster_param")]
    public SceneMonsterParam MonsterParam { get; set; }

    [ProtoBuf.ProtoMember(6, Name = @"drop_list")]
    public List<ItemList> DropList { get; } = [];

    [ProtoBuf.ProtoMember(8, Name = @"monster_list")]
    public List<SceneMonsterInfo> MonsterList { get; } = [];

    [ProtoBuf.ProtoMember(9, Name = @"HKFBHHKNBDG")]
    public uint Hkfbhhknbdg { get; set; }

    [ProtoBuf.ProtoMember(11, Name = @"PKGENFBHOFI")]
    public uint WaveId { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class SceneBattleInfo : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(8, Name = @"monster_wave_list")]
    public List<SceneMonsterWave> MonsterWaveList { get; } = [];

    [ProtoBuf.ProtoMember(9, Name = @"stage_id")]
    public uint StageId { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"mechanism_bar_info")]
    public BattleMechanismBar MechanismBarInfo { get; set; }

    [ProtoBuf.ProtoMember(13, Name = @"JLMIBPCGFGB")]
    public uint Jlmibpcgfgb { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"MOLNFNBLKBL")]
    public bool Molnfnblkbl { get; set; }

    [ProtoBuf.ProtoMember(1395, Name = @"event_battle_info_list")]
    public List<BattleEventBattleInfo> EventBattleInfoList { get; } = [];

    [ProtoBuf.ProtoMember(7, Name = @"logic_random_seed")]
    public uint LogicRandomSeed { get; set; }

    [ProtoBuf.ProtoMember(14, Name = @"battle_id")]
    public uint BattleId { get; set; }

    [ProtoBuf.ProtoMember(12, Name = @"buff_list")]
    public List<BattleBuff> BuffList { get; } = [];

    [ProtoBuf.ProtoMember(10, Name = @"BJELOIJJFPO")]
    public uint Bjeloijjfpo { get; set; }

    [ProtoBuf.ProtoMember(5, Name = @"battle_avatar_list")]
    public List<BattleAvatar> BattleAvatarList { get; } = [];

    [ProtoBuf.ProtoMember(1498, Name = @"battle_targe_info")]
    [ProtoBuf.ProtoMap]
    public Dictionary<uint, BattleTargeList> BattleTargeInfoes { get; } = new();

    [ProtoBuf.ProtoMember(1, Name = @"world_level")]
    public uint WorldLevel { get; set; }

    [ProtoBuf.ProtoMember(1790, Name = @"DPMFDAJGOAF")]
    public Kfemkcofofa Dpmfdajgoaf { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class StartCocoonStageScRsp : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"prop_entity_id")]
    public uint PropEntityId { get; set; }

    [ProtoBuf.ProtoMember(12, Name = @"battle_info")]
    public SceneBattleInfo BattleInfo { get; set; }

    [ProtoBuf.ProtoMember(13, Name = @"wave")]
    public uint Wave { get; set; }

    [ProtoBuf.ProtoMember(6, Name = @"retcode")]
    public uint Retcode { get; set; }

    [ProtoBuf.ProtoMember(8, Name = @"cocoon_id")]
    public uint CocoonId { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class PVEBattleResultCsReq : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(6, Name = @"end_status")]
    public BattleEndStatus EndStatus { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class PVEBattleResultScRsp : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(10, Name = @"retcode")]
    public uint Retcode { get; set; }

    [ProtoBuf.ProtoMember(8, Name = @"end_status")]
    public BattleEndStatus EndStatus { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class EnterSceneByServerScNotify : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(4, Name = @"scene")]
    public SceneInfo Scene { get; set; }

    [ProtoBuf.ProtoMember(11, Name = @"lineup")]
    public LineupInfo Lineup { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class Gateserver : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(457, Name = @"IONODFKBGFM")]
    [System.ComponentModel.DefaultValue("")]
    public string Ionodfkbgfm { get; set; } = "";

    [ProtoBuf.ProtoMember(10, Name = @"ip")]
    [System.ComponentModel.DefaultValue("")]
    public string Ip { get; set; } = "";

    [ProtoBuf.ProtoMember(684, Name = @"OANGAEHFOFH")]
    [System.ComponentModel.DefaultValue("")]
    public string Oangaehfofh { get; set; } = "";

    [ProtoBuf.ProtoMember(576, Name = @"b4")]
    public bool Unk4 { get; set; }

    [ProtoBuf.ProtoMember(1129, Name = @"JNDGFEIJEEN")]
    [System.ComponentModel.DefaultValue("")]
    public string Jndgfeijeen { get; set; } = "";

    [ProtoBuf.ProtoMember(191, Name = @"MAKLPMCHNHB")]
    public List<string> Maklpmchnhbs { get; } = [];

    [ProtoBuf.ProtoMember(658, Name = @"NEEGKPPFDPN")]
    [System.ComponentModel.DefaultValue("")]
    public string Neegkppfdpn { get; set; } = "";

    [ProtoBuf.ProtoMember(274, Name = @"PILDDEJGNCP")]
    [System.ComponentModel.DefaultValue("")]
    public string Pilddejgncp { get; set; } = "";

    [ProtoBuf.ProtoMember(1512, Name = @"HPLMFKPLOGG")]
    [System.ComponentModel.DefaultValue("")]
    public string Hplmfkplogg { get; set; } = "";

    [ProtoBuf.ProtoMember(986, Name = @"CECKJIPODLM")]
    [System.ComponentModel.DefaultValue("")]
    public string Ceckjipodlm { get; set; } = "";

    [ProtoBuf.ProtoMember(4, Name = @"LOKLPPKGKOJ")]
    public long Loklppkgkoj { get; set; }

    [ProtoBuf.ProtoMember(1387, Name = @"LDKMEELPODC")]
    [System.ComponentModel.DefaultValue("")]
    public string Ldkmeelpodc { get; set; } = "";

    [ProtoBuf.ProtoMember(6, Name = @"ex_resource_url")]
    [System.ComponentModel.DefaultValue("")]
    public string ExResourceUrl { get; set; } = "";

    [ProtoBuf.ProtoMember(687, Name = @"mdk_res_version")]
    [System.ComponentModel.DefaultValue("")]
    public string MdkResVersion { get; set; } = "";

    [ProtoBuf.ProtoMember(2044)] public bool UseTcp { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"FOEILDGCCHC")]
    [System.ComponentModel.DefaultValue("")]
    public string Foeildgcchc { get; set; } = "";

    [ProtoBuf.ProtoMember(1584, Name = @"DFMFBHIMLBK")]
    [System.ComponentModel.DefaultValue("")]
    public string Dfmfbhimlbk { get; set; } = "";

    [ProtoBuf.ProtoMember(9, Name = @"FHNIFAFNCOF")]
    public uint Fhnifafncof { get; set; }

    [ProtoBuf.ProtoMember(150, Name = @"ifix_version")]
    [System.ComponentModel.DefaultValue("")]
    public string IfixVersion { get; set; } = "";

    [ProtoBuf.ProtoMember(358, Name = @"b3")]
    public bool Unk3 { get; set; }

    [ProtoBuf.ProtoMember(89, Name = @"HPLPAONDKDL")]
    public bool Hplpaondkdl { get; set; }

    [ProtoBuf.ProtoMember(13, Name = @"JKJJBKFEIPN")]
    public long Jkjjbkfeipn { get; set; }

    [ProtoBuf.ProtoMember(301, Name = @"HOKKCNJNDJM")]
    [System.ComponentModel.DefaultValue("")]
    public string Hokkcnjndjm { get; set; } = "";

    [ProtoBuf.ProtoMember(1120, Name = @"b6")]
    public bool Unk6 { get; set; }

    [ProtoBuf.ProtoMember(960, Name = @"b5")]
    public bool Unk5 { get; set; }

    [ProtoBuf.ProtoMember(1799, Name = @"JAKOHGHLOKL")]
    public bool Jakohghlokl { get; set; }

    [ProtoBuf.ProtoMember(8, Name = @"msg")]
    [System.ComponentModel.DefaultValue("")]
    public string Msg { get; set; } = "";

    [ProtoBuf.ProtoMember(1019, Name = @"LPOJHLNMLCK")]
    [System.ComponentModel.DefaultValue("")]
    public string Lpojhlnmlck { get; set; } = "";

    [ProtoBuf.ProtoMember(2010, Name = @"KINAEHOBDPH")]
    [System.ComponentModel.DefaultValue("")]
    public string Kinaehobdph { get; set; } = "";

    [ProtoBuf.ProtoMember(774, Name = @"AAAIFNHPHJK")]
    [System.ComponentModel.DefaultValue("")]
    public string Aaaifnhphjk { get; set; } = "";

    [ProtoBuf.ProtoMember(1090, Name = @"BMMHKKFNHGK")]
    public bool Bmmhkkfnhgk { get; set; }

    [ProtoBuf.ProtoMember(942, Name = @"ALNDNCAMIEI")]
    [System.ComponentModel.DefaultValue("")]
    public string Alndncamiei { get; set; } = "";

    [ProtoBuf.ProtoMember(1482, Name = @"DHKIOKIKEDE")]
    [System.ComponentModel.DefaultValue("")]
    public string Dhkiokikede { get; set; } = "";

    [ProtoBuf.ProtoMember(529, Name = @"ACPKKKIFCCP")]
    public bool Acpkkkifccp { get; set; }

    [ProtoBuf.ProtoMember(729, Name = @"DEPJFJOGGMK")]
    [System.ComponentModel.DefaultValue("")]
    public string Depjfjoggmk { get; set; } = "";

    [ProtoBuf.ProtoMember(1143, Name = @"PIONMIOFOIC")]
    [System.ComponentModel.DefaultValue("")]
    public string Pionmiofoic { get; set; } = "";

    [ProtoBuf.ProtoMember(873, Name = @"OEPBFPFAACC")]
    [System.ComponentModel.DefaultValue("")]
    public string Oepbfpfaacc { get; set; } = "";

    [ProtoBuf.ProtoMember(1444, Name = @"MMNPCLPCDCK")]
    [System.ComponentModel.DefaultValue("")]
    public string Mmnpclpcdck { get; set; } = "";

    [ProtoBuf.ProtoMember(717, Name = @"IBAKDLKDOPG")]
    [System.ComponentModel.DefaultValue("")]
    public string Ibakdlkdopg { get; set; } = "";

    [ProtoBuf.ProtoMember(792, Name = @"POAHMMAJEOB")]
    [System.ComponentModel.DefaultValue("")]
    public string Poahmmajeob { get; set; } = "";

    [ProtoBuf.ProtoMember(5, Name = @"region_name")]
    [System.ComponentModel.DefaultValue("")]
    public string RegionName { get; set; } = "";

    [ProtoBuf.ProtoMember(1836, Name = @"msg0")]
    [System.ComponentModel.DefaultValue("")]
    public string Msg0 { get; set; } = "";

    [ProtoBuf.ProtoMember(1906, Name = @"b8")]
    public bool Unk8 { get; set; }

    [ProtoBuf.ProtoMember(14, Name = @"retcode")]
    public uint Retcode { get; set; }

    [ProtoBuf.ProtoMember(7, Name = @"b1")]
    public bool Unk1 { get; set; }

    [ProtoBuf.ProtoMember(15, Name = @"PJHBPOLDPPN")]
    public uint Pjhbpoldppn { get; set; }

    [ProtoBuf.ProtoMember(1115, Name = @"BBFPMKLCOIP")]
    [System.ComponentModel.DefaultValue("")]
    public string Bbfpmklcoip { get; set; } = "";

    [ProtoBuf.ProtoMember(12, Name = @"asset_bundle_url")]
    [System.ComponentModel.DefaultValue("")]
    public string AssetBundleUrl { get; set; } = "";

    [ProtoBuf.ProtoMember(605, Name = @"client_secret_key")]
    [System.ComponentModel.DefaultValue("")]
    public string ClientSecretKey { get; set; } = "";

    [ProtoBuf.ProtoMember(1362, Name = @"b7")]
    public bool Unk7 { get; set; }

    [ProtoBuf.ProtoMember(11, Name = @"b2")]
    public bool Unk2 { get; set; }

    [ProtoBuf.ProtoMember(1, Name = @"port")]
    public uint Port { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"lua_url")]
    [System.ComponentModel.DefaultValue("")]
    public string LuaUrl { get; set; } = "";

    [ProtoBuf.ProtoMember(1894, Name = @"IKEGKBJBEBB")]
    public bool Ikegkbjbebb { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class GetBasicInfoCsReq : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class PlayerSettingInfo : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(9, Name = @"GMFEKOIFNHG")]
    public bool Gmfekoifnhg { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"ACDICLFKMKK")]
    public bool Acdiclfkmkk { get; set; }

    [ProtoBuf.ProtoMember(10, Name = @"LINMJEHCEAB")]
    public bool Linmjehceab { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class GetBasicInfoScRsp : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(14, Name = @"exchange_times")]
    public uint ExchangeTimes { get; set; }

    [ProtoBuf.ProtoMember(7, Name = @"last_set_nickname_time")]
    public long LastSetNicknameTime { get; set; }

    [ProtoBuf.ProtoMember(4, Name = @"cur_day")]
    public uint CurDay { get; set; }

    [ProtoBuf.ProtoMember(6, Name = @"next_recover_time")]
    public long NextRecoverTime { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"week_cocoon_finished_count")]
    public uint WeekCocoonFinishedCount { get; set; }

    [ProtoBuf.ProtoMember(11, Name = @"retcode")]
    public uint Retcode { get; set; }

    [ProtoBuf.ProtoMember(5, Name = @"gameplay_birthday")]
    public uint GameplayBirthday { get; set; }

    [ProtoBuf.ProtoMember(15, Name = @"player_setting_info")]
    public PlayerSettingInfo PlayerSettingInfo { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class Tutorial : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(8, Name = @"status")]
    public TutorialStatus Status { get; set; }

    [ProtoBuf.ProtoMember(15, Name = @"id")]
    public uint Id { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class TutorialGuide : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(4, Name = @"status")]
    public TutorialStatus Status { get; set; }

    [ProtoBuf.ProtoMember(14, Name = @"id")]
    public uint Id { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract(Name = @"NOBIHFCKCMF")]
public class Nobihfckcmf : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class GetTutorialScRsp : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(5, Name = @"tutorial_list")]
    public List<Tutorial> TutorialList { get; } = [];

    [ProtoBuf.ProtoMember(6, Name = @"retcode")]
    public uint Retcode { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract(Name = @"PJOIEGMNEPK")]
public class Pjoiegmnepk : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class GetTutorialGuideScRsp : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(2, Name = @"tutorial_guide_list")]
    public List<TutorialGuide> TutorialGuideList { get; } = [];

    [ProtoBuf.ProtoMember(10, Name = @"retcode")]
    public uint Retcode { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class GetSceneMapInfoCsReq : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(13, Name = @"HNOHLAFHIAE")]
    public uint Hnohlafhiae { get; set; }

    [ProtoBuf.ProtoMember(4, Name = @"entry_id")]
    public uint EntryId { get; set; }

    [ProtoBuf.ProtoMember(14, Name = @"DEOJKHFMBHK")]
    public bool Deojkhfmbhk { get; set; }

    [ProtoBuf.ProtoMember(9, Name = @"entry_id_list", IsPacked = true)]
    public uint[] EntryIdList { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class MazePropState : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(4, Name = @"config_id")]
    public uint ConfigId { get; set; }

    [ProtoBuf.ProtoMember(1, Name = @"group_id")]
    public uint GroupId { get; set; }

    [ProtoBuf.ProtoMember(7, Name = @"state")]
    public uint State { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class MazeGroup : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(3, Name = @"NDACJGMMEAD")]
    public long Ndacjgmmead { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"IAPDBFMCKNF")]
    public bool Iapdbfmcknf { get; set; }

    [ProtoBuf.ProtoMember(8, Name = @"group_id")]
    public uint GroupId { get; set; }

    [ProtoBuf.ProtoMember(9, Name = @"CABGFJPHADE", IsPacked = true)]
    public uint[] Cabgfjphades { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class ChestInfo : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"chest_type")]
    public ChestType ChestType { get; set; }

    [ProtoBuf.ProtoMember(7, Name = @"CCBLHBCKOLF")]
    public uint Ccblhbckolf { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"IOLPGHABNNI")]
    public uint Iolpghabnni { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract(Name = @"AJKFBCLNMLC")]
public class Ajkfbclnmlc : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(11, Name = @"type")]
    public uint Type { get; set; }

    [ProtoBuf.ProtoMember(3, Name = @"NEENHEOIBEE")]
    public uint Neenheoibee { get; set; }

    [ProtoBuf.ProtoMember(9, Name = @"IECJJOBEDOF")]
    public uint Iecjjobedof { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class SceneMapInfo : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(1, Name = @"maze_group_list")]
    public List<MazeGroup> MazeGroupList { get; } = [];

    [ProtoBuf.ProtoMember(10, Name = @"maze_prop_list")]
    public List<MazePropState> MazePropList { get; } = [];

    [ProtoBuf.ProtoMember(9, Name = @"lighten_section_list", IsPacked = true)]
    public uint[] LightenSectionList { get; set; }

    [ProtoBuf.ProtoMember(14, Name = @"cur_map_entry_id")]
    public uint CurMapEntryId { get; set; }

    [ProtoBuf.ProtoMember(15, Name = @"entry_id")]
    public uint EntryId { get; set; }

    [ProtoBuf.ProtoMember(11, Name = @"retcode")]
    public uint Retcode { get; set; }

    [ProtoBuf.ProtoMember(8, Name = @"IKBKPJCANEA")]
    public List<Ajkfbclnmlc> Ikbkpjcaneas { get; } = [];

    [ProtoBuf.ProtoMember(4, Name = @"KIGLLKIBNLI")]
    public uint Kigllkibnli { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"unlock_teleport_list", IsPacked = true)]
    public uint[] UnlockTeleportList { get; set; }

    [ProtoBuf.ProtoMember(13, Name = @"chest_list")]
    public List<ChestInfo> ChestList { get; } = [];

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public class GetSceneMapInfoScRsp : ProtoBuf.IExtensible
{
    private ProtoBuf.IExtension __pbn__extensionData;

    [ProtoBuf.ProtoMember(15, Name = @"entry_id")]
    public uint EntryId { get; set; }

    [ProtoBuf.ProtoMember(5, Name = @"HNOHLAFHIAE")]
    public uint Hnohlafhiae { get; set; }

    [ProtoBuf.ProtoMember(1, Name = @"lighten_section_list", IsPacked = true)]
    public uint[] LightenSectionList { get; set; }

    [ProtoBuf.ProtoMember(4, Name = @"maze_prop_list")]
    public List<MazePropState> MazePropList { get; } = [];

    [ProtoBuf.ProtoMember(10, Name = @"chest_list")]
    public List<ChestInfo> ChestList { get; } = [];

    [ProtoBuf.ProtoMember(14, Name = @"unlock_teleport_list", IsPacked = true)]
    public uint[] UnlockTeleportList { get; set; }

    [ProtoBuf.ProtoMember(11, Name = @"DEOJKHFMBHK")]
    public bool Deojkhfmbhk { get; set; }

    [ProtoBuf.ProtoMember(2, Name = @"maze_group_list")]
    public List<MazeGroup> MazeGroupList { get; } = [];

    [ProtoBuf.ProtoMember(7, Name = @"cur_map_entry_id")]
    public uint CurrentMapEntryId { get; set; }

    [ProtoBuf.ProtoMember(12, Name = @"scene_map_info")]
    public List<SceneMapInfo> SceneMapInfoList { get; } = [];

    [ProtoBuf.ProtoMember(8, Name = @"retcode")]
    public uint Retcode { get; set; }

    ProtoBuf.IExtension ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
}

[ProtoBuf.ProtoContract]
public enum AvatarSlot
{
    [ProtoBuf.ProtoEnum(Name = @"AVATAR_SLOT_1")]
    AvatarSlot1 = 0,

    [ProtoBuf.ProtoEnum(Name = @"AVATAR_SLOT_2")]
    AvatarSlot2 = 1,

    [ProtoBuf.ProtoEnum(Name = @"AVATAR_SLOT_3")]
    AvatarSlot3 = 2
}

[ProtoBuf.ProtoContract]
public enum ItemType
{
    [ProtoBuf.ProtoEnum(Name = @"ITEM_TYPE_NONE")]
    ItemTypeNone = 0,

    [ProtoBuf.ProtoEnum(Name = @"ITEM_AVATAR_CARD")]
    ItemAvatarCard = 1,

    [ProtoBuf.ProtoEnum(Name = @"ITEM_EQUIPMENT")]
    ItemEquipment = 2,

    [ProtoBuf.ProtoEnum(Name = @"ITEM_MATERIAL")]
    ItemMaterial = 3,

    [ProtoBuf.ProtoEnum(Name = @"ITEM_AVATAR_EXP")]
    ItemAvatarExp = 4,

    [ProtoBuf.ProtoEnum(Name = @"ITEM_RELIC")]
    ItemRelic = 5
}

[ProtoBuf.ProtoContract]
public enum VirtualItemType
{
    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_NONE")]
    VirtualItemNone = 0,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_HCOIN")]
    VirtualItemHCoin = 1,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_SCOIN")]
    VirtualItemSCoin = 2,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_MCOIN")]
    VirtualItemMCoin = 3,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_STAMINA")]
    VirtualItemStamina = 11,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_RESERVE_STAMINA")]
    VirtualItemReserveStamina = 12,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_AVATAR_EXP")]
    VirtualItemAvatarExp = 21,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_EXP")]
    VirtualItemExp = 22,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_DAILY_ACTIVE_POINT")]
    VirtualItemDailyActivePoint = 23,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_MP_MAX")]
    VirtualItemMpMax = 24,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_PLAYER_RETURN_POINT")]
    VirtualItemPlayerReturnPoint = 25,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_BATTLE_COLLEGE_POINT")]
    VirtualItemBattleCollegePoint = 26,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_ROGUE_COIN")]
    VirtualItemRogueCoin = 31,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_ROGUE_TALENT_COIN")]
    VirtualItemRogueTalentCoin = 32,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_ROGUE_REWARD_KEY")]
    VirtualItemRogueRewardKey = 33,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_ACHIEVEMENT_EXP")]
    VirtualItemAchievementExp = 41,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_BP_EXP")]
    VirtualItemBpExp = 51,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_BP_REAL_EXP")]
    VirtualItemBpRealExp = 52,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_MUSEUM_FUNDS")]
    VirtualItemMuseumFunds = 53,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_WARRIOR_EXP")]
    VirtualItemWarriorExp = 190,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_ROGUE_EXP")]
    VirtualItemRogueExp = 191,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_MAGE_EXP")]
    VirtualItemMageExp = 192,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_SHAMAN_EXP")]
    VirtualItemShamanExp = 193,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_WARLOCK_EXP")]
    VirtualItemWarlockExp = 194,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_KNIGHT_EXP")]
    VirtualItemKnightExp = 195,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_PRIEST_EXP")]
    VirtualItemPriestExp = 196,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_PUNK_LORD_POINT")]
    VirtualItemPunkLordPoint = 100000,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_GAMEPLAY_COUNTER_MONSTER_SNEAK_VISION")]
    VirtualItemGameplayCounterMonsterSneakVision = 280001,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_GAMEPLAY_COUNTER_WOLF_BRO_BULLET")]
    VirtualItemGameplayCounterWolfBroBullet = 280002,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_ALLEY_FUNDS")]
    VirtualItemAlleyFunds = 281001,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_ROGUE_PUMAN_COUPON")]
    VirtualItemRoguePumanCoupon = 281012,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_MONTH_CARD")]
    VirtualItemMonthCard = 300101,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_BP_NORMAL")]
    VirtualItemBpNormal = 300102,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_BP_DELUXE")]
    VirtualItemBpDeluxe = 300103,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_BP_UPGRADE")]
    VirtualItemBpUpgrade = 300104,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_HELIOBUS_FANS")]
    VirtualItemHeliobusFans = 281002,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_SPACE_ZOO_HYBRID_ITEM")]
    VirtualItemSpaceZooHybridItem = 281003,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_SPACE_ZOO_EXP_POINT")]
    VirtualItemSpaceZooExpPoint = 281004,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_ROGUE_NOUS_TALENT_COIN")]
    VirtualItemRogueNousTalentCoin = 281013,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_DRINK_MAKER_TIP")]
    VirtualItemDrinkMakerTip = 281005,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_MONOPOLY_DICE")]
    VirtualItemMonopolyDice = 281014,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_MONOPOLY_COIN")]
    VirtualItemMonopolyCoin = 281015,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_MONOPOLY_CHEATDICE")]
    VirtualItemMonopolyCheatdice = 281016,

    [ProtoBuf.ProtoEnum(Name = @"VIRTUAL_ITEM_MONOPOLY_REROLL")]
    VirtualItemMonopolyReroll = 281017
}

[ProtoBuf.ProtoContract(Name = @"JNILDIIFFLP")]
public enum GameplayCounterType
{
    [ProtoBuf.ProtoEnum(Name = @"GAMEPLAY_COUNTER_NONE")]
    GameplayCounterNone = 0,

    [ProtoBuf.ProtoEnum(Name = @"GAMEPLAY_COUNTER_MONSTER_SNEAK_VISION")]
    GameplayCounterMonsterSneakVision = 280001
}

[ProtoBuf.ProtoContract(Name = @"PGNDLDIDFKA")]
public enum BlackLimitLevelType
{
    [ProtoBuf.ProtoEnum(Name = @"BLACK_LIMIT_LEVEL_ALL")]
    BlackLimitLevelAll = 0
}

[ProtoBuf.ProtoContract]
public enum AreaType
{
    [ProtoBuf.ProtoEnum(Name = @"AREA_NONE")]
    AreaNone = 0,

    [ProtoBuf.ProtoEnum(Name = @"AREA_CN")]
    AreaCn = 1,

    [ProtoBuf.ProtoEnum(Name = @"AREA_JP")]
    AreaJp = 2,

    [ProtoBuf.ProtoEnum(Name = @"AREA_ASIA")]
    AreaAsia = 3,

    [ProtoBuf.ProtoEnum(Name = @"AREA_WEST")]
    AreaWest = 4,

    [ProtoBuf.ProtoEnum(Name = @"AREA_KR")]
    AreaKr = 5,

    [ProtoBuf.ProtoEnum(Name = @"AREA_OVERSEAS")]
    AreaOverseas = 6
}

[ProtoBuf.ProtoContract]
public enum EntityType
{
    [ProtoBuf.ProtoEnum(Name = @"ENTITY_NONE")]
    EntityNone = 0,

    [ProtoBuf.ProtoEnum(Name = @"ENTITY_AVATAR")]
    EntityAvatar = 1,

    [ProtoBuf.ProtoEnum(Name = @"ENTITY_MONSTER")]
    EntityMonster = 2,

    [ProtoBuf.ProtoEnum(Name = @"ENTITY_NPC")]
    EntityNpc = 3,

    [ProtoBuf.ProtoEnum(Name = @"ENTITY_PROP")]
    EntityProp = 4,

    [ProtoBuf.ProtoEnum(Name = @"ENTITY_TRIGGER")]
    EntityTrigger = 5,

    [ProtoBuf.ProtoEnum(Name = @"ENTITY_ENV")]
    EntityEnv = 6,

    [ProtoBuf.ProtoEnum(Name = @"ENTITY_SUMMON_UNIT")]
    EntitySummonUnit = 7
}

[ProtoBuf.ProtoContract]
public enum LanguageType
{
    [ProtoBuf.ProtoEnum(Name = @"LANGUAGE_NONE")]
    LanguageNone = 0,

    [ProtoBuf.ProtoEnum(Name = @"LANGUAGE_SC")]
    LanguageSc = 1,

    [ProtoBuf.ProtoEnum(Name = @"LANGUAGE_TC")]
    LanguageTc = 2,

    [ProtoBuf.ProtoEnum(Name = @"LANGUAGE_EN")]
    LanguageEn = 3,

    [ProtoBuf.ProtoEnum(Name = @"LANGUAGE_KR")]
    LanguageKr = 4,

    [ProtoBuf.ProtoEnum(Name = @"LANGUAGE_JP")]
    LanguageJp = 5,

    [ProtoBuf.ProtoEnum(Name = @"LANGUAGE_FR")]
    LanguageFr = 6,

    [ProtoBuf.ProtoEnum(Name = @"LANGUAGE_DE")]
    LanguageDe = 7,

    [ProtoBuf.ProtoEnum(Name = @"LANGUAGE_ES")]
    LanguageEs = 8,

    [ProtoBuf.ProtoEnum(Name = @"LANGUAGE_PT")]
    LanguagePt = 9,

    [ProtoBuf.ProtoEnum(Name = @"LANGUAGE_RU")]
    LanguageRu = 10,

    [ProtoBuf.ProtoEnum(Name = @"LANGUAGE_TH")]
    LanguageTh = 11,

    [ProtoBuf.ProtoEnum(Name = @"LANGUAGE_VI")]
    LanguageVi = 12,

    [ProtoBuf.ProtoEnum(Name = @"LANGUAGE_ID")]
    LanguageId = 13
}

[ProtoBuf.ProtoContract]
public enum PlatformType
{
    [ProtoBuf.ProtoEnum(Name = @"EDITOR")] Editor = 0,
    [ProtoBuf.ProtoEnum(Name = @"IOS")] Ios = 1,

    [ProtoBuf.ProtoEnum(Name = @"ANDROID")]
    Android = 2,
    [ProtoBuf.ProtoEnum(Name = @"PC")] Pc = 3,
    [ProtoBuf.ProtoEnum(Name = @"WEB")] Web = 4,
    [ProtoBuf.ProtoEnum(Name = @"WAP")] Wap = 5,
    [ProtoBuf.ProtoEnum(Name = @"PS4")] Ps4 = 6,

    [ProtoBuf.ProtoEnum(Name = @"NINTENDO")]
    Nintendo = 7,

    [ProtoBuf.ProtoEnum(Name = @"CLOUD_ANDROID")]
    CloudAndroid = 8,

    [ProtoBuf.ProtoEnum(Name = @"CLOUD_PC")]
    CloudPc = 9,

    [ProtoBuf.ProtoEnum(Name = @"CLOUD_IOS")]
    CloudIos = 10,
    [ProtoBuf.ProtoEnum(Name = @"PS5")] Ps5 = 11,
    [ProtoBuf.ProtoEnum(Name = @"MAC")] Mac = 12,

    [ProtoBuf.ProtoEnum(Name = @"CLOUD_MAC")]
    CloudMac = 13,

    [ProtoBuf.ProtoEnum(Name = @"CLOUD_WEB_ANDROID")]
    CloudWebAndroid = 20,

    [ProtoBuf.ProtoEnum(Name = @"CLOUD_WEB_IOS")]
    CloudWebIos = 21,

    [ProtoBuf.ProtoEnum(Name = @"CLOUD_WEB_PC")]
    CloudWebPc = 22,

    [ProtoBuf.ProtoEnum(Name = @"CLOUD_WEB_MAC")]
    CloudWebMac = 23,

    [ProtoBuf.ProtoEnum(Name = @"CLOUD_WEB_TOUCH")]
    CloudWebTouch = 24,

    [ProtoBuf.ProtoEnum(Name = @"CLOUD_WEB_KEYBOARD")]
    CloudWebKeyboard = 25
}

[ProtoBuf.ProtoContract(Name = @"KGDDCEHMEIA")]
public enum KickType
{
    [ProtoBuf.ProtoEnum(Name = @"NO_KICK")]
    NoKick = 0,

    [ProtoBuf.ProtoEnum(Name = @"FORCE_KICK")]
    ForceKick = 1,

    [ProtoBuf.ProtoEnum(Name = @"IDLE_KICK")]
    IdleKick = 2,

    [ProtoBuf.ProtoEnum(Name = @"SILENCE")]
    Silence = 3
}

[ProtoBuf.ProtoContract]
public enum AvatarType
{
    [ProtoBuf.ProtoEnum(Name = @"AVATAR_TYPE_NONE")]
    AvatarTypeNone = 0,

    [ProtoBuf.ProtoEnum(Name = @"AVATAR_TRIAL_TYPE")]
    AvatarTrialType = 1,

    [ProtoBuf.ProtoEnum(Name = @"AVATAR_LIMIT_TYPE")]
    AvatarLimitType = 2,

    [ProtoBuf.ProtoEnum(Name = @"AVATAR_FORMAL_TYPE")]
    AvatarFormalType = 3,

    [ProtoBuf.ProtoEnum(Name = @"AVATAR_ASSIST_TYPE")]
    AvatarAssistType = 4,

    [ProtoBuf.ProtoEnum(Name = @"AVATAR_AETHER_DIVIDE_TYPE")]
    AvatarAetherDivideType = 5
}

[ProtoBuf.ProtoContract]
public enum HeroBasicType
{
    None = 0,
    BoyWarrior = 8001,
    GirlWarrior = 8002,
    BoyKnight = 8003,
    GirlKnight = 8004,
    BoyRogue = 8005,
    GirlRogue = 8006,
    BoyMage = 8007,
    GirlMage = 8008,
    BoyShaman = 8009,
    GirlShaman = 8010,
    BoyWarlock = 8011,
    GirlWarlock = 8012,
    BoyPriest = 8013,
    GirlPriest = 8014
}

[ProtoBuf.ProtoContract]
public enum Gender
{
    GenderNone = 0,
    GenderMan = 1,
    GenderWoman = 2
}

[ProtoBuf.ProtoContract(Name = @"CBHMODEMOED")]
public enum ProductType
{
    [ProtoBuf.ProtoEnum(Name = @"PRODUCT_NONE")]
    ProductNone = 0,

    [ProtoBuf.ProtoEnum(Name = @"PRODUCT_NORMAL")]
    ProductNormal = 1,

    [ProtoBuf.ProtoEnum(Name = @"PRODUCT_LIMIT")]
    ProductLimit = 2,

    [ProtoBuf.ProtoEnum(Name = @"PRODUCT_LIMIT_NO_PAY")]
    ProductLimitNoPay = 3,

    [ProtoBuf.ProtoEnum(Name = @"PRODUCT_NO_PROCESS_ORDER")]
    ProductNoProcessOrder = 4
}

[ProtoBuf.ProtoContract]
public enum ProductGiftType
{
    [ProtoBuf.ProtoEnum(Name = @"PRODUCT_GIFT_NONE")]
    ProductGiftNone = 0,

    [ProtoBuf.ProtoEnum(Name = @"PRODUCT_GIFT_COIN")]
    ProductGiftCoin = 1,

    [ProtoBuf.ProtoEnum(Name = @"PRODUCT_GIFT_MONTH_CARD")]
    ProductGiftMonthCard = 2,

    [ProtoBuf.ProtoEnum(Name = @"PRODUCT_GIFT_BP_68")]
    ProductGiftBp68 = 3,

    [ProtoBuf.ProtoEnum(Name = @"PRODUCT_GIFT_BP_128")]
    ProductGiftBp128 = 4,

    [ProtoBuf.ProtoEnum(Name = @"PRODUCT_GIFT_BP68_UPGRADE_128")]
    ProductGiftBp68Upgrade128 = 5,

    [ProtoBuf.ProtoEnum(Name = @"PRODUCT_GIFT_POINT_CARD")]
    ProductGiftPointCard = 6,

    [ProtoBuf.ProtoEnum(Name = @"PRODUCT_GIFT_PS_PRE_ORDER_1")]
    ProductGiftPsPreOrder1 = 7,

    [ProtoBuf.ProtoEnum(Name = @"PRODUCT_GIFT_PS_PRE_ORDER_2")]
    ProductGiftPsPreOrder2 = 8,

    [ProtoBuf.ProtoEnum(Name = @"PRODUCT_GIFT_GOOGLE_POINTS_100")]
    ProductGiftGooglePoints100 = 9,

    [ProtoBuf.ProtoEnum(Name = @"PRODUCT_GIFT_GOOGLE_POINTS_150")]
    ProductGiftGooglePoints150 = 10,

    [ProtoBuf.ProtoEnum(Name = @"PRODUCT_GIFT_PS_POINT_CARD_030")]
    ProductGiftPsPointCard030 = 11,

    [ProtoBuf.ProtoEnum(Name = @"PRODUCT_GIFT_PS_POINT_CARD_050")]
    ProductGiftPsPointCard050 = 12,

    [ProtoBuf.ProtoEnum(Name = @"PRODUCT_GIFT_PS_POINT_CARD_100")]
    ProductGiftPsPointCard100 = 13
}

[ProtoBuf.ProtoContract]
public enum FeatureSwitchType
{
    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_NONE")]
    FeatureSwitchNone = 0,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_SHOP")]
    FeatureSwitchShop = 1,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_LINEUP_NAME")]
    FeatureSwitchLineupName = 2,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_RECHARGE_SHOP")]
    FeatureSwitchRechargeShop = 3,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_NICKNAME")]
    FeatureSwitchNickname = 4,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_SIGNATURE")]
    FeatureSwitchSignature = 5,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_BATTLEPASS")]
    FeatureSwitchBattlepass = 6,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_PUNK_LORD")]
    FeatureSwitchPunkLord = 7,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_MONTHCARD_DAILY")]
    FeatureSwitchMonthcardDaily = 8,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_PICTURE_SHARE")]
    FeatureSwitchPictureShare = 9,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_ROGUE")]
    FeatureSwitchRogue = 10,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_CHALLENGE")]
    FeatureSwitchChallenge = 11,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_COCOON")]
    FeatureSwitchCocoon = 12,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_RAID")]
    FeatureSwitchRaid = 13,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_MAZE_PLANE_EVENT")]
    FeatureSwitchMazePlaneEvent = 14,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_ACTIVITY_PANEL")]
    FeatureSwitchActivityPanel = 15,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_MAILBOX")]
    FeatureSwitchMailbox = 16,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_QUEST")]
    FeatureSwitchQuest = 17,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_GACHA")]
    FeatureSwitchGacha = 18,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_CHAT")]
    FeatureSwitchChat = 19,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_MODIFY_FRIEND_ALIAS")]
    FeatureSwitchModifyFriendAlias = 20,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_USE_ITEM")]
    FeatureSwitchUseItem = 21,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_ACTIVITY_SCHEDULE")]
    FeatureSwitchActivitySchedule = 22,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_FARM_ELEMENT")]
    FeatureSwitchFarmElement = 23,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_ACHIEVEMENT_LEVEL")]
    FeatureSwitchAchievementLevel = 24,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_DAILY_ACTIVE_LEVEL")]
    FeatureSwitchDailyActiveLevel = 25,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_PLAYER_RETURN")]
    FeatureSwitchPlayerReturn = 26,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_FIRST_SET_NICKNAME")]
    FeatureSwitchFirstSetNickname = 27,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_MAIN_MISSION_REWARD")]
    FeatureSwitchMainMissionReward = 28,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_SUB_MISSION_REWARD")]
    FeatureSwitchSubMissionReward = 29,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_PAM_MISSION")]
    FeatureSwitchPamMission = 30,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_DAILY_MISSION")]
    FeatureSwitchDailyMission = 31,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_DESTROY_ITEM")]
    FeatureSwitchDestroyItem = 32,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_CONSUME_ITEM_TURN")]
    FeatureSwitchConsumeItemTurn = 33,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_ROGUE_MODIFIER")]
    FeatureSwitchRogueModifier = 34,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_CHESS_ROGUE")]
    FeatureSwitchChessRogue = 35,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_CHESS_ROGUE_BOARD")]
    FeatureSwitchChessRogueBoard = 36,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_ROLL_SHOP")]
    FeatureSwitchRollShop = 37,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_H5_RETURN")]
    FeatureSwitchH5Return = 38,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_OFFERING")]
    FeatureSwitchOffering = 39,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_SERVER_RED_POINT")]
    FeatureSwitchServerRedPoint = 40,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_MONOPOLY_OPTION_RATIO")]
    FeatureSwitchMonopolyOptionRatio = 41,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_MONOPOLY_GET_RAFFLE_TICKET")]
    FeatureSwitchMonopolyGetRaffleTicket = 42,

    [ProtoBuf.ProtoEnum(Name = @"FEATURE_SWITCH_MONOPOLY_TAKE_RAFFLE_REWARD")]
    FeatureSwitchMonopolyTakeRaffleReward = 43
}

[ProtoBuf.ProtoContract]
public enum SecretKeyType
{
    [ProtoBuf.ProtoEnum(Name = @"SECRET_KEY_NONE")]
    SecretKeyNone = 0,

    [ProtoBuf.ProtoEnum(Name = @"SECRET_KEY_SERVER_CHECK")]
    SecretKeyServerCheck = 1,

    [ProtoBuf.ProtoEnum(Name = @"SECRET_KEY_VIDEO")]
    SecretKeyVideo = 2,

    [ProtoBuf.ProtoEnum(Name = @"SECRET_KEY_BATTLE_TIME")]
    SecretKeyBattleTime = 3
}

[ProtoBuf.ProtoContract]
public enum ReplayType
{
    [ProtoBuf.ProtoEnum(Name = @"REPLAY_TYPE_NONE")]
    ReplayTypeNone = 0,

    [ProtoBuf.ProtoEnum(Name = @"REPLAY_TYPE_PUNK_LORD")]
    ReplayTypePunkLord = 1
}

[ProtoBuf.ProtoContract]
public enum PunkLordShareType
{
    [ProtoBuf.ProtoEnum(Name = @"PUNK_LORD_SHARE_TYPE_NONE")]
    PunkLordShareTypeNone = 0,

    [ProtoBuf.ProtoEnum(Name = @"PUNK_LORD_SHARE_TYPE_FRIEND")]
    PunkLordShareTypeFriend = 1,

    [ProtoBuf.ProtoEnum(Name = @"PUNK_LORD_SHARE_TYPE_ALL")]
    PunkLordShareTypeAll = 2
}

[ProtoBuf.ProtoContract]
public enum PunkLordAttackerStatus
{
    [ProtoBuf.ProtoEnum(Name = @"PUNK_LORD_ATTACKER_STATUS_NONE")]
    PunkLordAttackerStatusNone = 0,

    [ProtoBuf.ProtoEnum(Name = @"PUNK_LORD_ATTACKER_STATUS_ATTACKED")]
    PunkLordAttackerStatusAttacked = 1,

    [ProtoBuf.ProtoEnum(Name = @"PUNK_LORD_ATTACKER_STATUS_ATTACKING")]
    PunkLordAttackerStatusAttacking = 2,

    [ProtoBuf.ProtoEnum(Name = @"PUNK_LORD_ATTACKER_STATUS_ATTACKED_AND_ATTACKING")]
    PunkLordAttackerStatusAttackedAndAttacking = 3
}

[ProtoBuf.ProtoContract(Name = @"NFILBPDFCCP")]
public enum PunkLordMonsterInfoNotifyReasonType
{
    [ProtoBuf.ProtoEnum(Name = @"PUNK_LORD_MONSTER_INFO_NOTIFY_REASON_NONE")]
    PunkLordMonsterInfoNotifyReasonNone = 0,

    [ProtoBuf.ProtoEnum(Name = @"PUNK_LORD_MONSTER_INFO_NOTIFY_REASON_ENTER_RAID")]
    PunkLordMonsterInfoNotifyReasonEnterRaid = 1,

    [ProtoBuf.ProtoEnum(Name = @"PUNK_LORD_MONSTER_INFO_NOTIFY_REASON_BATTLE_END")]
    PunkLordMonsterInfoNotifyReasonBattleEnd = 2,

    [ProtoBuf.ProtoEnum(Name = @"PUNK_LORD_MONSTER_INFO_NOTIFY_REASON_LEAVE_RAID")]
    PunkLordMonsterInfoNotifyReasonLeaveRaid = 3
}

[ProtoBuf.ProtoContract(Name = @"LGFKOOJHLGK")]
public enum ChatType
{
    [ProtoBuf.ProtoEnum(Name = @"CHAT_TYPE_NONE")]
    ChatTypeNone = 0,

    [ProtoBuf.ProtoEnum(Name = @"CHAT_TYPE_PRIVATE")]
    ChatTypePrivate = 1,

    [ProtoBuf.ProtoEnum(Name = @"CHAT_TYPE_GROUP")]
    ChatTypeGroup = 2
}

[ProtoBuf.ProtoContract]
public enum MsgType
{
    [ProtoBuf.ProtoEnum(Name = @"MSG_TYPE_NONE")]
    MsgTypeNone = 0,

    [ProtoBuf.ProtoEnum(Name = @"MSG_TYPE_CUSTOM_TEXT")]
    MsgTypeCustomText = 1,

    [ProtoBuf.ProtoEnum(Name = @"MSG_TYPE_EMOJI")]
    MsgTypeEmoji = 2
}

[ProtoBuf.ProtoContract(Name = @"GGKPHEMBCCE")]
public enum ShieldType
{
    [ProtoBuf.ProtoEnum(Name = @"SHIELD_TYPE_NONE")]
    ShieldTypeNone = 0,

    [ProtoBuf.ProtoEnum(Name = @"SHIELD_TYPE_REPLACE")]
    ShieldTypeReplace = 1,

    [ProtoBuf.ProtoEnum(Name = @"SHIELD_TYPE_SHIED")]
    ShieldTypeShied = 2
}

[ProtoBuf.ProtoContract]
public enum FuncUnlockIdType
{
    [ProtoBuf.ProtoEnum(Name = @"FUNC_UNLOCK_ID_NONE")]
    FuncUnlockIdNone = 0,

    [ProtoBuf.ProtoEnum(Name = @"FUNC_UNLOCK_ID_RELIC")]
    FuncUnlockIdRelic = 403,

    [ProtoBuf.ProtoEnum(Name = @"FUNC_UNLOCK_ID_RELIC_NUM")]
    FuncUnlockIdRelicNum = 404,

    [ProtoBuf.ProtoEnum(Name = @"FUNC_UNLOCK_ID_EQUIPMENT")]
    FuncUnlockIdEquipment = 401,

    [ProtoBuf.ProtoEnum(Name = @"FUNC_UNLOCK_ID_SKILLTREE")]
    FuncUnlockIdSkilltree = 402,

    [ProtoBuf.ProtoEnum(Name = @"FUNC_UNLOCK_ID_GACHA")]
    FuncUnlockIdGacha = 2300,

    [ProtoBuf.ProtoEnum(Name = @"FUNC_UNLOCK_ID_EXPEDITION")]
    FuncUnlockIdExpedition = 3100,

    [ProtoBuf.ProtoEnum(Name = @"FUNC_UNLOCK_ID_COMPOSE")]
    FuncUnlockIdCompose = 4100,

    [ProtoBuf.ProtoEnum(Name = @"FUNC_UNLOCK_ID_FIGHTACTIVITY")]
    FuncUnlockIdFightactivity = 3700
}

[ProtoBuf.ProtoContract(Name = @"DCAPECMGLBH")]
public enum AssistAvatarType
{
    [ProtoBuf.ProtoEnum(Name = @"ASSIST_AVATAR_UNKNOW")]
    AssistAvatarUnknown = 0,

    [ProtoBuf.ProtoEnum(Name = @"ASSIST_AVATAR_LEVEL")]
    AssistAvatarLevel = 1,

    [ProtoBuf.ProtoEnum(Name = @"ASSIST_AVATAR_RANK")]
    AssistAvatarRank = 2
}

[ProtoBuf.ProtoContract(Name = @"JIFNDPEACNA")]
public enum BattleCheckStrategyType
{
    [ProtoBuf.ProtoEnum(Name = @"BATTLE_CHECK_STRATEGY_IDENTICAL")]
    BattleCheckStrategyIdentical = 0,

    [ProtoBuf.ProtoEnum(Name = @"BATTLE_CHECK_STRATEGY_SERVER")]
    BattleCheckStrategyServer = 1,

    [ProtoBuf.ProtoEnum(Name = @"BATTLE_CHECK_STRATEGY_CLIENT")]
    BattleCheckStrategyClient = 2
}

[ProtoBuf.ProtoContract]
public enum BattleCheckResultType
{
    [ProtoBuf.ProtoEnum(Name = @"BATTLE_CHECK_RESULT_SUCC")]
    BattleCheckResultSuccess = 0,

    [ProtoBuf.ProtoEnum(Name = @"BATTLE_CHECK_RESULT_FAIL")]
    BattleCheckResultFailed = 1,

    [ProtoBuf.ProtoEnum(Name = @"BATTLE_CHECK_RESULT_PASS")]
    BattleCheckResultPassed = 2
}

[ProtoBuf.ProtoContract(Name = @"NNHMNDEADHC")]
public enum BattleModuleType
{
    [ProtoBuf.ProtoEnum(Name = @"BATTLE_MODULE_MAZE")]
    BattleModuleMaze = 0,

    [ProtoBuf.ProtoEnum(Name = @"BATTLE_MODULE_CHALLENGE")]
    BattleModuleChallenge = 1,

    [ProtoBuf.ProtoEnum(Name = @"BATTLE_MODULE_COCOON")]
    BattleModuleCocoon = 2,

    [ProtoBuf.ProtoEnum(Name = @"BATTLE_MODULE_ROGUE")]
    BattleModuleRogue = 3,

    [ProtoBuf.ProtoEnum(Name = @"BATTLE_MODULE_CHALLENGE_ACTIVITY")]
    BattleModuleChallengeActivity = 4,

    [ProtoBuf.ProtoEnum(Name = @"BATTLE_MODULE_TRIAL_LEVEL")]
    BattleModuleTrialLevel = 5,

    [ProtoBuf.ProtoEnum(Name = @"BATTLE_MODULE_AETHER_DIVIDE")]
    BattleModuleAetherDivide = 6
}

[ProtoBuf.ProtoContract(Name = @"KFFDAGKJAAN")]
public enum AetherDivideSpiritLineupType
{
    [ProtoBuf.ProtoEnum(Name = @"AETHERDIVIDE_SPIRIT_LINEUP_NONE")]
    AetherDivideSpiritLineupNone = 0,

    [ProtoBuf.ProtoEnum(Name = @"AETHERDIVIDE_SPIRIT_LINEUP_NORMAL")]
    AetherDivideSpiritLineupNormal = 1,

    [ProtoBuf.ProtoEnum(Name = @"AETHERDIVIDE_SPIRIT_LINEUP_TRIAL")]
    AetherDivideSpiritLineupTrial = 2
}

[ProtoBuf.ProtoContract(Name = @"BAAHONPPLAJ")]
public enum BattleTargetType
{
    [ProtoBuf.ProtoEnum(Name = @"BATTLE_TARGET_TYPE_NONE")]
    BattleTargetTypeNone = 0,

    [ProtoBuf.ProtoEnum(Name = @"BATTLE_TARGET_TYPE_SCORE")]
    BattleTargetTypeScore = 1,

    [ProtoBuf.ProtoEnum(Name = @"BATTLE_TARGET_TYPE_ACHIEVEMENT")]
    BattleTargetTypeAchievement = 2,

    [ProtoBuf.ProtoEnum(Name = @"BATTLE_TARGET_TYPE_RAID")]
    BattleTargetTypeRaid = 3,

    [ProtoBuf.ProtoEnum(Name = @"BATTLE_TARGET_TYPE_CHALLENGE_SCORE")]
    BattleTargetTypeChallengeScore = 4,

    [ProtoBuf.ProtoEnum(Name = @"BATTLE_TARGET_TYPE_COMMON")]
    BattleTargetTypeCommon = 5
}

[ProtoBuf.ProtoContract(Name = @"GIECDPICNHJ")]
public enum DeathSourceType
{
    [ProtoBuf.ProtoEnum(Name = @"UNKNOWN")]
    Unknown = 0,

    [ProtoBuf.ProtoEnum(Name = @"KILLED_BY_OTHERS")]
    KilledByOthers = 1,

    [ProtoBuf.ProtoEnum(Name = @"KILLED_BY_SELF")]
    KilledBySelf = 2,
    [ProtoBuf.ProtoEnum(Name = @"ESCAPE")] Escape = 3
}

[ProtoBuf.ProtoContract(Name = @"GNHDKOFHFAI")]
public enum TagType
{
    [ProtoBuf.ProtoEnum(Name = @"TAG_NONE")]
    TagNone = 0,

    [ProtoBuf.ProtoEnum(Name = @"TAG_HIDE_NPC_MONSTER")]
    TagHideNpcMonster = 1
}

[ProtoBuf.ProtoContract(Name = @"CCBLMJCLPAL")]
public enum Ccblmjclpal
{
    [ProtoBuf.ProtoEnum(Name = @"NORMAL_CREATE")]
    NormalCreate = 0,

    [ProtoBuf.ProtoEnum(Name = @"FORM_CHANGE")]
    FormChange = 1
}

[ProtoBuf.ProtoContract(Name = @"OEDPADFJAHH")]
public enum BattleEndReasonType
{
    [ProtoBuf.ProtoEnum(Name = @"BATTLE_END_REASON_NONE")]
    BattleEndReasonNone = 0,

    [ProtoBuf.ProtoEnum(Name = @"BATTLE_END_REASON_ALL_DIE")]
    BattleEndReasonAllDie = 1,

    [ProtoBuf.ProtoEnum(Name = @"BATTLE_END_REASON_TURN_LIMIT")]
    BattleEndReasonTurnLimit = 2
}

[ProtoBuf.ProtoContract(Name = @"BEGPPBGODNA")]
public enum BattleStaticticEventType
{
    [ProtoBuf.ProtoEnum(Name = @"BATTLE_STATICTIC_EVENT_NONE")]
    BattleStaticticEventNone = 0,

    [ProtoBuf.ProtoEnum(Name = @"BATTLE_STATICTIC_EVENT_TREASURE_DUNGEON_ADD_EXPLORE")]
    BattleStaticticEventTreasureDungeonAddExplore = 1,

    [ProtoBuf.ProtoEnum(Name = @"BATTLE_STATICTIC_EVENT_TREASURE_DUNGEON_OPEN_GRID")]
    BattleStaticticEventTreasureDungeonOpenGrid = 2,

    [ProtoBuf.ProtoEnum(Name = @"BATTLE_STATICTIC_EVENT_TREASURE_DUNGEON_PICKUP_ITEM")]
    BattleStaticticEventTreasureDungeonPickupItem = 3,

    [ProtoBuf.ProtoEnum(Name = @"BATTLE_STATICTIC_EVENT_TREASURE_DUNGEON_USE_BUFF")]
    BattleStaticticEventTreasureDungeonUseBuff = 4,

    [ProtoBuf.ProtoEnum(Name = @"BATTLE_STATICTIC_EVENT_TELEVISION_ACTIVITY_UPDATE_MAZE_BUFF_LAYER")]
    BattleStaticticEventTelevisionActivityUpdateMazeBuffLayer = 5
}

[ProtoBuf.ProtoContract]
public enum BattleEndStatus
{
    [ProtoBuf.ProtoEnum(Name = @"BATTLE_END_NONE")]
    BattleEndNone = 0,

    [ProtoBuf.ProtoEnum(Name = @"BATTLE_END_WIN")]
    BattleEndWin = 1,

    [ProtoBuf.ProtoEnum(Name = @"BATTLE_END_LOSE")]
    BattleEndLose = 2,

    [ProtoBuf.ProtoEnum(Name = @"BATTLE_END_QUIT")]
    BattleEndQuit = 3
}

[ProtoBuf.ProtoContract]
public enum Retcode
{
    [ProtoBuf.ProtoEnum(Name = @"RET_SUCC")]
    RetSucc = 0,

    [ProtoBuf.ProtoEnum(Name = @"RET_FAIL")]
    RetFail = 1,

    [ProtoBuf.ProtoEnum(Name = @"RET_SERVER_INTERNAL_ERROR")]
    RetServerInternalError = 2,

    [ProtoBuf.ProtoEnum(Name = @"RET_TIMEOUT")]
    RetTimeout = 3,

    [ProtoBuf.ProtoEnum(Name = @"RET_REPEATED_REQ")]
    RetRepeatedReq = 4,

    [ProtoBuf.ProtoEnum(Name = @"RET_REQ_PARA_INVALID")]
    RetReqParaInvalid = 5,

    [ProtoBuf.ProtoEnum(Name = @"RET_PLAYER_DATA_ERROR")]
    RetPlayerDataError = 6,

    [ProtoBuf.ProtoEnum(Name = @"RET_PLAYER_CLIENT_PAUSED")]
    RetPlayerClientPaused = 7,

    [ProtoBuf.ProtoEnum(Name = @"RET_FUNC_CHECK_FAILED")]
    RetFuncCheckFailed = 8,

    [ProtoBuf.ProtoEnum(Name = @"RET_FEATURE_SWITCH_CLOSED")]
    RetFeatureSwitchClosed = 9,

    [ProtoBuf.ProtoEnum(Name = @"RET_FREQ_OVER_LIMIT")]
    RetFreqOverLimit = 10,

    [ProtoBuf.ProtoEnum(Name = @"RET_SYSTEM_BUSY")]
    RetSystemBusy = 11,

    [ProtoBuf.ProtoEnum(Name = @"RET_PLAYER_NOT_ONLINE")]
    RetPlayerNotOnline = 12,

    [ProtoBuf.ProtoEnum(Name = @"RET_REPEATE_LOGIN")]
    RetRepeateLogin = 1000,

    [ProtoBuf.ProtoEnum(Name = @"RET_RETRY_LOGIN")]
    RetRetryLogin = 1001,

    [ProtoBuf.ProtoEnum(Name = @"RET_WAIT_LOGIN")]
    RetWaitLogin = 1002,

    [ProtoBuf.ProtoEnum(Name = @"RET_NOT_IN_WHITE_LIST")]
    RetNotInWhiteList = 1003,

    [ProtoBuf.ProtoEnum(Name = @"RET_IN_BLACK_LIST")]
    RetInBlackList = 1004,

    [ProtoBuf.ProtoEnum(Name = @"RET_ACCOUNT_VERIFY_ERROR")]
    RetAccountVerifyError = 1005,

    [ProtoBuf.ProtoEnum(Name = @"RET_ACCOUNT_PARA_ERROR")]
    RetAccountParaError = 1006,

    [ProtoBuf.ProtoEnum(Name = @"RET_ANTI_ADDICT_LOGIN")]
    RetAntiAddictLogin = 1007,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHECK_SUM_ERROR")]
    RetCheckSumError = 1008,

    [ProtoBuf.ProtoEnum(Name = @"RET_REACH_MAX_PLAYER_NUM")]
    RetReachMaxPlayerNum = 1009,

    [ProtoBuf.ProtoEnum(Name = @"RET_ALREADY_REGISTERED")]
    RetAlreadyRegistered = 1010,

    [ProtoBuf.ProtoEnum(Name = @"RET_GENDER_ERROR")]
    RetGenderError = 1011,

    [ProtoBuf.ProtoEnum(Name = @"SET_NICKNAME_RET_CALLBACK_PROCESSING")]
    SetNicknameRetCallbackProcessing = 1012,

    [ProtoBuf.ProtoEnum(Name = @"RET_IN_GM_BIND_ACCESS")]
    RetInGmBindAccess = 1013,

    [ProtoBuf.ProtoEnum(Name = @"RET_QUEST_REWARD_ALREADY_TAKEN")]
    RetQuestRewardAlreadyTaken = 1100,

    [ProtoBuf.ProtoEnum(Name = @"RET_QUEST_NOT_ACCEPT")]
    RetQuestNotAccept = 1101,

    [ProtoBuf.ProtoEnum(Name = @"RET_QUEST_NOT_FINISH")]
    RetQuestNotFinish = 1102,

    [ProtoBuf.ProtoEnum(Name = @"RET_QUEST_STATUS_ERROR")]
    RetQuestStatusError = 1103,

    [ProtoBuf.ProtoEnum(Name = @"RET_ACHIEVEMENT_LEVEL_NOT_REACH")]
    RetAchievementLevelNotReach = 1104,

    [ProtoBuf.ProtoEnum(Name = @"RET_ACHIEVEMENT_LEVEL_ALREADY_TAKEN")]
    RetAchievementLevelAlreadyTaken = 1105,

    [ProtoBuf.ProtoEnum(Name = @"RET_AVATAR_NOT_EXIST")]
    RetAvatarNotExist = 1200,

    [ProtoBuf.ProtoEnum(Name = @"RET_AVATAR_RES_EXP_NOT_ENOUGH")]
    RetAvatarResExpNotEnough = 1201,

    [ProtoBuf.ProtoEnum(Name = @"RET_AVATAR_EXP_REACH_PROMOTION_LIMIT")]
    RetAvatarExpReachPromotionLimit = 1202,

    [ProtoBuf.ProtoEnum(Name = @"RET_AVATAR_REACH_MAX_PROMOTION")]
    RetAvatarReachMaxPromotion = 1203,

    [ProtoBuf.ProtoEnum(Name = @"RET_SKILLTREE_CONFIG_NOT_EXIST")]
    RetSkilltreeConfigNotExist = 1204,

    [ProtoBuf.ProtoEnum(Name = @"RET_SKILLTREE_ALREADY_UNLOCK")]
    RetSkilltreeAlreadyUnlock = 1205,

    [ProtoBuf.ProtoEnum(Name = @"RET_SKILLTREE_PRE_LOCKED")]
    RetSkilltreePreLocked = 1206,

    [ProtoBuf.ProtoEnum(Name = @"RET_SKILLTREE_LEVEL_NOT_MEET")]
    RetSkilltreeLevelNotMeet = 1207,

    [ProtoBuf.ProtoEnum(Name = @"RET_SKILLTREE_RANK_NOT_MEET")]
    RetSkilltreeRankNotMeet = 1208,

    [ProtoBuf.ProtoEnum(Name = @"RET_AVATAR_DRESS_NO_EQUIPMENT")]
    RetAvatarDressNoEquipment = 1209,

    [ProtoBuf.ProtoEnum(Name = @"RET_AVATAR_EXP_ITEM_NOT_EXIST")]
    RetAvatarExpItemNotExist = 1210,

    [ProtoBuf.ProtoEnum(Name = @"RET_SKILLTREE_POINT_UNLOCK")]
    RetSkilltreePointUnlock = 1211,

    [ProtoBuf.ProtoEnum(Name = @"RET_SKILLTREE_POINT_LEVEL_UPGRADE_NOT_MATCH")]
    RetSkilltreePointLevelUpgradeNotMatch = 1212,

    [ProtoBuf.ProtoEnum(Name = @"RET_SKILLTREE_POINT_LEVEL_REACH_MAX")]
    RetSkilltreePointLevelReachMax = 1213,

    [ProtoBuf.ProtoEnum(Name = @"RET_WORLD_LEVEL_NOT_MEET")]
    RetWorldLevelNotMeet = 1214,

    [ProtoBuf.ProtoEnum(Name = @"RET_PLAYER_LEVEL_NOT_MEET")]
    RetPlayerLevelNotMeet = 1215,

    [ProtoBuf.ProtoEnum(Name = @"RET_AVATAR_RANK_NOT_MATCH")]
    RetAvatarRankNotMatch = 1216,

    [ProtoBuf.ProtoEnum(Name = @"RET_AVATAR_RANK_REACH_MAX")]
    RetAvatarRankReachMax = 1217,

    [ProtoBuf.ProtoEnum(Name = @"RET_HERO_BASIC_TYPE_NOT_MATCH")]
    RetHeroBasicTypeNotMatch = 1218,

    [ProtoBuf.ProtoEnum(Name = @"RET_AVATAR_PROMOTION_NOT_MEET")]
    RetAvatarPromotionNotMeet = 1219,

    [ProtoBuf.ProtoEnum(Name = @"RET_PROMOTION_REWARD_CONFIG_NOT_EXIST")]
    RetPromotionRewardConfigNotExist = 1220,

    [ProtoBuf.ProtoEnum(Name = @"RET_PROMOTION_REWARD_ALREADY_TAKEN")]
    RetPromotionRewardAlreadyTaken = 1221,

    [ProtoBuf.ProtoEnum(Name = @"RET_AVATAR_SKIN_ITEM_NOT_EXIST")]
    RetAvatarSkinItemNotExist = 1222,

    [ProtoBuf.ProtoEnum(Name = @"RET_AVATAR_SKIN_ALREADY_DRESSED")]
    RetAvatarSkinAlreadyDressed = 1223,

    [ProtoBuf.ProtoEnum(Name = @"RET_AVATAR_NOT_DRESS_SKIN")]
    RetAvatarNotDressSkin = 1224,

    [ProtoBuf.ProtoEnum(Name = @"RET_AVATAR_SKIN_NOT_MATCH_AVATAR")]
    RetAvatarSkinNotMatchAvatar = 1225,

    [ProtoBuf.ProtoEnum(Name = @"RET_ITEM_NOT_EXIST")]
    RetItemNotExist = 1300,

    [ProtoBuf.ProtoEnum(Name = @"RET_ITEM_COST_NOT_ENOUGH")]
    RetItemCostNotEnough = 1301,

    [ProtoBuf.ProtoEnum(Name = @"RET_ITEM_COST_TOO_MUCH")]
    RetItemCostTooMuch = 1302,

    [ProtoBuf.ProtoEnum(Name = @"RET_ITEM_NO_COST")]
    RetItemNoCost = 1303,

    [ProtoBuf.ProtoEnum(Name = @"RET_ITEM_NOT_ENOUGH")]
    RetItemNotEnough = 1304,

    [ProtoBuf.ProtoEnum(Name = @"RET_ITEM_INVALID")]
    RetItemInvalid = 1305,

    [ProtoBuf.ProtoEnum(Name = @"RET_ITEM_CONFIG_NOT_EXIST")]
    RetItemConfigNotExist = 1306,

    [ProtoBuf.ProtoEnum(Name = @"RET_SCOIN_NOT_ENOUGH")]
    RetScoinNotEnough = 1307,

    [ProtoBuf.ProtoEnum(Name = @"RET_ITEM_REWARD_EXCEED_LIMIT")]
    RetItemRewardExceedLimit = 1308,

    [ProtoBuf.ProtoEnum(Name = @"RET_ITEM_INVALID_USE")]
    RetItemInvalidUse = 1309,

    [ProtoBuf.ProtoEnum(Name = @"RET_ITEM_USE_CONFIG_NOT_EXIST")]
    RetItemUseConfigNotExist = 1310,

    [ProtoBuf.ProtoEnum(Name = @"RET_REWARD_CONFIG_NOT_EXIST")]
    RetRewardConfigNotExist = 1311,

    [ProtoBuf.ProtoEnum(Name = @"RET_ITEM_EXCEED_LIMIT")]
    RetItemExceedLimit = 1312,

    [ProtoBuf.ProtoEnum(Name = @"RET_ITEM_COUNT_INVALID")]
    RetItemCountInvalid = 1313,

    [ProtoBuf.ProtoEnum(Name = @"RET_ITEM_USE_TARGET_TYPE_INVALID")]
    RetItemUseTargetTypeInvalid = 1314,

    [ProtoBuf.ProtoEnum(Name = @"RET_ITEM_USE_SATIETY_FULL")]
    RetItemUseSatietyFull = 1315,

    [ProtoBuf.ProtoEnum(Name = @"RET_ITEM_COMPOSE_NOT_EXIST")]
    RetItemComposeNotExist = 1316,

    [ProtoBuf.ProtoEnum(Name = @"RET_RELIC_COMPOSE_NOT_EXIST")]
    RetRelicComposeNotExist = 1317,

    [ProtoBuf.ProtoEnum(Name = @"RET_ITEM_CAN_NOT_SELL")]
    RetItemCanNotSell = 1318,

    [ProtoBuf.ProtoEnum(Name = @"RET_ITEM_SELL_EXCEDD_LIMIT")]
    RetItemSellExceddLimit = 1319,

    [ProtoBuf.ProtoEnum(Name = @"RET_ITEM_NOT_IN_COST_LIST")]
    RetItemNotInCostList = 1320,

    [ProtoBuf.ProtoEnum(Name = @"RET_ITEM_SPECIAL_COST_NOT_ENOUGH")]
    RetItemSpecialCostNotEnough = 1321,

    [ProtoBuf.ProtoEnum(Name = @"RET_ITEM_SPECIAL_COST_TOO_MUCH")]
    RetItemSpecialCostTooMuch = 1322,

    [ProtoBuf.ProtoEnum(Name = @"RET_ITEM_FORMULA_NOT_EXIST")]
    RetItemFormulaNotExist = 1323,

    [ProtoBuf.ProtoEnum(Name = @"RET_ITEM_AUTO_GIFT_OPTIONAL_NOT_EXIST")]
    RetItemAutoGiftOptionalNotExist = 1324,

    [ProtoBuf.ProtoEnum(Name = @"RET_RELIC_COMPOSE_RELIC_INVALID")]
    RetRelicComposeRelicInvalid = 1325,

    [ProtoBuf.ProtoEnum(Name = @"RET_RELIC_COMPOSE_MAIN_AFFIX_ID_INVALID")]
    RetRelicComposeMainAffixIdInvalid = 1326,

    [ProtoBuf.ProtoEnum(Name = @"RET_RELIC_COMPOSE_WRONG_FORMULA_TYPE")]
    RetRelicComposeWrongFormulaType = 1327,

    [ProtoBuf.ProtoEnum(Name = @"RET_RELIC_COMPOSE_RELIC_NOT_EXIST")]
    RetRelicComposeRelicNotExist = 1328,

    [ProtoBuf.ProtoEnum(Name = @"RET_RELIC_COMPOSE_BLACK_GOLD_COUNT_INVALID")]
    RetRelicComposeBlackGoldCountInvalid = 1329,

    [ProtoBuf.ProtoEnum(Name = @"RET_RELIC_COMPOSE_BLACK_GOLD_NOT_NEED")]
    RetRelicComposeBlackGoldNotNeed = 1330,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONTH_CARD_CANNOT_USE")]
    RetMonthCardCannotUse = 1331,

    [ProtoBuf.ProtoEnum(Name = @"RET_ITEM_REWARD_EXCEED_DISAPPEAR")]
    RetItemRewardExceedDisappear = 1332,

    [ProtoBuf.ProtoEnum(Name = @"RET_ITEM_NEED_RECYCLE")]
    RetItemNeedRecycle = 1333,

    [ProtoBuf.ProtoEnum(Name = @"RET_ITEM_COMPOSE_EXCEED_LIMIT")]
    RetItemComposeExceedLimit = 1334,

    [ProtoBuf.ProtoEnum(Name = @"RET_ITEM_CAN_NOT_DESTROY")]
    RetItemCanNotDestroy = 1335,

    [ProtoBuf.ProtoEnum(Name = @"RET_ITEM_ALREADY_MARK")]
    RetItemAlreadyMark = 1336,

    [ProtoBuf.ProtoEnum(Name = @"RET_ITEM_MARK_EXCEED_LIMIT")]
    RetItemMarkExceedLimit = 1337,

    [ProtoBuf.ProtoEnum(Name = @"RET_ITEM_NOT_MARK")]
    RetItemNotMark = 1338,

    [ProtoBuf.ProtoEnum(Name = @"RET_ITEN_TURN_FOOD_NOT_SET")]
    RetItenTurnFoodNotSet = 1339,

    [ProtoBuf.ProtoEnum(Name = @"RET_ITEM_TURN_FOOD_ALREADY_SET")]
    RetItemTurnFoodAlreadySet = 1340,

    [ProtoBuf.ProtoEnum(Name = @"RET_ITEM_TURN_FOOD_CONSUME_TYPE_ERROR")]
    RetItemTurnFoodConsumeTypeError = 1341,

    [ProtoBuf.ProtoEnum(Name = @"RET_ITEM_TURN_FOOD_SWITCH_ALREADY_OPEN")]
    RetItemTurnFoodSwitchAlreadyOpen = 1342,

    [ProtoBuf.ProtoEnum(Name = @"RET_ITEM_TURN_FOOD_SWITCH_ALREADY_CLOSE")]
    RetItemTurnFoodSwitchAlreadyClose = 1343,

    [ProtoBuf.ProtoEnum(Name = @"RET_HCOIN_EXCHANGE_TOO_MUCH")]
    RetHcoinExchangeTooMuch = 1344,

    [ProtoBuf.ProtoEnum(Name = @"RET_ITEM_TURN_FOOD_SCENE_TYPE_ERROR")]
    RetItemTurnFoodSceneTypeError = 1345,

    [ProtoBuf.ProtoEnum(Name = @"RET_EQUIPMENT_ALREADY_DRESSED")]
    RetEquipmentAlreadyDressed = 1350,

    [ProtoBuf.ProtoEnum(Name = @"RET_EQUIPMENT_NOT_EXIST")]
    RetEquipmentNotExist = 1351,

    [ProtoBuf.ProtoEnum(Name = @"RET_EQUIPMENT_REACH_LEVEL_LIMIT")]
    RetEquipmentReachLevelLimit = 1352,

    [ProtoBuf.ProtoEnum(Name = @"RET_EQUIPMENT_CONSUME_SELF")]
    RetEquipmentConsumeSelf = 1353,

    [ProtoBuf.ProtoEnum(Name = @"RET_EQUIPMENT_ALREADY_LOCKED")]
    RetEquipmentAlreadyLocked = 1354,

    [ProtoBuf.ProtoEnum(Name = @"RET_EQUIPMENT_ALREADY_UNLOCKED")]
    RetEquipmentAlreadyUnlocked = 1355,

    [ProtoBuf.ProtoEnum(Name = @"RET_EQUIPMENT_LOCKED")]
    RetEquipmentLocked = 1356,

    [ProtoBuf.ProtoEnum(Name = @"RET_EQUIPMENT_SELECT_NUM_OVER_LIMIT")]
    RetEquipmentSelectNumOverLimit = 1357,

    [ProtoBuf.ProtoEnum(Name = @"RET_EQUIPMENT_RANK_UP_MUST_CONSUME_SAME_TID")]
    RetEquipmentRankUpMustConsumeSameTid = 1358,

    [ProtoBuf.ProtoEnum(Name = @"RET_EQUIPMENT_PROMOTION_REACH_MAX")]
    RetEquipmentPromotionReachMax = 1359,

    [ProtoBuf.ProtoEnum(Name = @"RET_EQUIPMENT_RANK_UP_REACH_MAX")]
    RetEquipmentRankUpReachMax = 1360,

    [ProtoBuf.ProtoEnum(Name = @"RET_EQUIPMENT_LEVEL_REACH_MAX")]
    RetEquipmentLevelReachMax = 1361,

    [ProtoBuf.ProtoEnum(Name = @"RET_EQUIPMENT_EXCEED_LIMIT")]
    RetEquipmentExceedLimit = 1362,

    [ProtoBuf.ProtoEnum(Name = @"RET_RELIC_NOT_EXIST")]
    RetRelicNotExist = 1363,

    [ProtoBuf.ProtoEnum(Name = @"RET_RELIC_REACH_LEVEL_LIMIT")]
    RetRelicReachLevelLimit = 1364,

    [ProtoBuf.ProtoEnum(Name = @"RET_RELIC_CONSUME_SELF")]
    RetRelicConsumeSelf = 1365,

    [ProtoBuf.ProtoEnum(Name = @"RET_RELIC_ALREADY_DRESSED")]
    RetRelicAlreadyDressed = 1366,

    [ProtoBuf.ProtoEnum(Name = @"RET_RELIC_LOCKED")]
    RetRelicLocked = 1367,

    [ProtoBuf.ProtoEnum(Name = @"RET_RELIC_ALREADY_LOCKED")]
    RetRelicAlreadyLocked = 1368,

    [ProtoBuf.ProtoEnum(Name = @"RET_RELIC_ALREADY_UNLOCKED")]
    RetRelicAlreadyUnlocked = 1369,

    [ProtoBuf.ProtoEnum(Name = @"RET_RELIC_LEVEL_IS_NOT_ZERO")]
    RetRelicLevelIsNotZero = 1370,

    [ProtoBuf.ProtoEnum(Name = @"RET_UNIQUE_ID_REPEATED")]
    RetUniqueIdRepeated = 1371,

    [ProtoBuf.ProtoEnum(Name = @"RET_EQUIPMENT_LEVEL_NOT_MEET")]
    RetEquipmentLevelNotMeet = 1372,

    [ProtoBuf.ProtoEnum(Name = @"RET_EQUIPMENT_ITEM_NOT_IN_COST_LIST")]
    RetEquipmentItemNotInCostList = 1373,

    [ProtoBuf.ProtoEnum(Name = @"RET_EQUIPMENT_LEVEL_GREATER_THAN_ONE")]
    RetEquipmentLevelGreaterThanOne = 1374,

    [ProtoBuf.ProtoEnum(Name = @"RET_EQUIPMENT_ALREADY_RANKED")]
    RetEquipmentAlreadyRanked = 1375,

    [ProtoBuf.ProtoEnum(Name = @"RET_RELIC_EXCEED_LIMIT")]
    RetRelicExceedLimit = 1376,

    [ProtoBuf.ProtoEnum(Name = @"RET_RELIC_ALREADY_DISCARDED")]
    RetRelicAlreadyDiscarded = 1377,

    [ProtoBuf.ProtoEnum(Name = @"RET_RELIC_ALREADY_UNDISCARDED")]
    RetRelicAlreadyUndiscarded = 1378,

    [ProtoBuf.ProtoEnum(Name = @"RET_EQUIPMENT_BATCH_LOCK_TOO_FAST")]
    RetEquipmentBatchLockTooFast = 1379,

    [ProtoBuf.ProtoEnum(Name = @"RET_LINEUP_INVALID_INDEX")]
    RetLineupInvalidIndex = 1400,

    [ProtoBuf.ProtoEnum(Name = @"RET_LINEUP_INVALID_MEMBER_POS")]
    RetLineupInvalidMemberPos = 1401,

    [ProtoBuf.ProtoEnum(Name = @"RET_LINEUP_SWAP_NOT_EXIST")]
    RetLineupSwapNotExist = 1402,

    [ProtoBuf.ProtoEnum(Name = @"RET_LINEUP_AVATAR_ALREADY_IN")]
    RetLineupAvatarAlreadyIn = 1403,

    [ProtoBuf.ProtoEnum(Name = @"RET_LINEUP_CREATE_AVATAR_ERROR")]
    RetLineupCreateAvatarError = 1404,

    [ProtoBuf.ProtoEnum(Name = @"RET_LINEUP_AVATAR_INIT_ERROR")]
    RetLineupAvatarInitError = 1405,

    [ProtoBuf.ProtoEnum(Name = @"RET_LINEUP_NOT_EXIST")]
    RetLineupNotExist = 1406,

    [ProtoBuf.ProtoEnum(Name = @"RET_LINEUP_ONLY_ONE_MEMBER")]
    RetLineupOnlyOneMember = 1407,

    [ProtoBuf.ProtoEnum(Name = @"RET_LINEUP_SAME_LEADER_SLOT")]
    RetLineupSameLeaderSlot = 1408,

    [ProtoBuf.ProtoEnum(Name = @"RET_LINEUP_NO_LEADER_SELECT")]
    RetLineupNoLeaderSelect = 1409,

    [ProtoBuf.ProtoEnum(Name = @"RET_LINEUP_SWAP_SAME_SLOT")]
    RetLineupSwapSameSlot = 1410,

    [ProtoBuf.ProtoEnum(Name = @"RET_LINEUP_AVATAR_NOT_EXIST")]
    RetLineupAvatarNotExist = 1411,

    [ProtoBuf.ProtoEnum(Name = @"RET_LINEUP_TRIAL_AVATAR_CAN_NOT_QUIT")]
    RetLineupTrialAvatarCanNotQuit = 1412,

    [ProtoBuf.ProtoEnum(Name = @"RET_LINEUP_VIRTUAL_LINEUP_PLANE_NOT_MATCH")]
    RetLineupVirtualLineupPlaneNotMatch = 1413,

    [ProtoBuf.ProtoEnum(Name = @"RET_LINEUP_NOT_VALID_LEADER")]
    RetLineupNotValidLeader = 1414,

    [ProtoBuf.ProtoEnum(Name = @"RET_LINEUP_SAME_INDEX")]
    RetLineupSameIndex = 1415,

    [ProtoBuf.ProtoEnum(Name = @"RET_LINEUP_IS_EMPTY")]
    RetLineupIsEmpty = 1416,

    [ProtoBuf.ProtoEnum(Name = @"RET_LINEUP_NAME_FORMAT_ERROR")]
    RetLineupNameFormatError = 1417,

    [ProtoBuf.ProtoEnum(Name = @"RET_LINEUP_TYPE_NOT_MATCH")]
    RetLineupTypeNotMatch = 1418,

    [ProtoBuf.ProtoEnum(Name = @"RET_LINEUP_REPLACE_ALL_FAILED")]
    RetLineupReplaceAllFailed = 1419,

    [ProtoBuf.ProtoEnum(Name = @"RET_LINEUP_NOT_ALLOW_EDIT")]
    RetLineupNotAllowEdit = 1420,

    [ProtoBuf.ProtoEnum(Name = @"RET_LINEUP_AVATAR_IS_ALIVE")]
    RetLineupAvatarIsAlive = 1421,

    [ProtoBuf.ProtoEnum(Name = @"RET_LINEUP_ASSIST_HAS_ONLY_MEMBER")]
    RetLineupAssistHasOnlyMember = 1422,

    [ProtoBuf.ProtoEnum(Name = @"RET_LINEUP_ASSIST_CANNOT_SWITCH")]
    RetLineupAssistCannotSwitch = 1423,

    [ProtoBuf.ProtoEnum(Name = @"RET_LINEUP_AVATAR_TYPE_INVALID")]
    RetLineupAvatarTypeInvalid = 1424,

    [ProtoBuf.ProtoEnum(Name = @"RET_LINEUP_NAME_UTF8_ERROR")]
    RetLineupNameUtf8Error = 1425,

    [ProtoBuf.ProtoEnum(Name = @"RET_LINEUP_LEADER_LOCK")]
    RetLineupLeaderLock = 1426,

    [ProtoBuf.ProtoEnum(Name = @"RET_LINEUP_STORY_LINE_NOT_MATCH")]
    RetLineupStoryLineNotMatch = 1427,

    [ProtoBuf.ProtoEnum(Name = @"RET_LINEUP_AVATAR_LOCK")]
    RetLineupAvatarLock = 1428,

    [ProtoBuf.ProtoEnum(Name = @"RET_LINEUP_AVATAR_INVALID")]
    RetLineupAvatarInvalid = 1429,

    [ProtoBuf.ProtoEnum(Name = @"RET_LINEUP_AVATAR_ALREADY_INIT")]
    RetLineupAvatarAlreadyInit = 1430,

    [ProtoBuf.ProtoEnum(Name = @"RET_MAIL_NOT_EXIST")]
    RetMailNotExist = 1700,

    [ProtoBuf.ProtoEnum(Name = @"RET_MAIL_RANGE_INVALID")]
    RetMailRangeInvalid = 1701,

    [ProtoBuf.ProtoEnum(Name = @"RET_MAIL_MAIL_ID_INVALID")]
    RetMailMailIdInvalid = 1702,

    [ProtoBuf.ProtoEnum(Name = @"RET_MAIL_NO_MAIL_TAKE_ATTACHMENT")]
    RetMailNoMailTakeAttachment = 1703,

    [ProtoBuf.ProtoEnum(Name = @"RET_MAIL_NO_MAIL_TO_DEL")]
    RetMailNoMailToDel = 1704,

    [ProtoBuf.ProtoEnum(Name = @"RET_MAIL_TYPE_INVALID")]
    RetMailTypeInvalid = 1705,

    [ProtoBuf.ProtoEnum(Name = @"RET_MAIL_PARA_INVALID")]
    RetMailParaInvalid = 1706,

    [ProtoBuf.ProtoEnum(Name = @"RET_MAIL_ATTACHEMENT_INVALID")]
    RetMailAttachementInvalid = 1707,

    [ProtoBuf.ProtoEnum(Name = @"RET_MAIL_TICKET_INVALID")]
    RetMailTicketInvalid = 1708,

    [ProtoBuf.ProtoEnum(Name = @"RET_MAIL_TICKET_REPEATED")]
    RetMailTicketRepeated = 1709,

    [ProtoBuf.ProtoEnum(Name = @"RET_STAGE_SETTLE_ERROR")]
    RetStageSettleError = 1800,

    [ProtoBuf.ProtoEnum(Name = @"RET_STAGE_CONFIG_NOT_EXIST")]
    RetStageConfigNotExist = 1801,

    [ProtoBuf.ProtoEnum(Name = @"RET_STAGE_NOT_FOUND")]
    RetStageNotFound = 1802,

    [ProtoBuf.ProtoEnum(Name = @"RET_STAGE_COCOON_PROP_NOT_VALID")]
    RetStageCocoonPropNotValid = 1804,

    [ProtoBuf.ProtoEnum(Name = @"RET_STAGE_COCOON_WAVE_NOT_VALID")]
    RetStageCocoonWaveNotValid = 1805,

    [ProtoBuf.ProtoEnum(Name = @"RET_STAGE_PROP_ID_NOT_EQUAL")]
    RetStagePropIdNotEqual = 1806,

    [ProtoBuf.ProtoEnum(Name = @"RET_STAGE_COCOON_WAVE_OVER")]
    RetStageCocoonWaveOver = 1807,

    [ProtoBuf.ProtoEnum(Name = @"RET_STAGE_WEEK_COCOON_OVER_CNT")]
    RetStageWeekCocoonOverCnt = 1808,

    [ProtoBuf.ProtoEnum(Name = @"RET_STAGE_COCOON_NOT_OPEN")]
    RetStageCocoonNotOpen = 1809,

    [ProtoBuf.ProtoEnum(Name = @"RET_STAGE_TRIAL_NOT_OPEN")]
    RetStageTrialNotOpen = 1810,

    [ProtoBuf.ProtoEnum(Name = @"RET_STAGE_FARM_NOT_OPEN")]
    RetStageFarmNotOpen = 1811,

    [ProtoBuf.ProtoEnum(Name = @"RET_STAGE_FARM_TYPE_ERROR")]
    RetStageFarmTypeError = 1812,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHAPTER_LOCK")]
    RetChapterLock = 1900,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHAPTER_CHALLENGE_NUM_NOT_ENOUGH")]
    RetChapterChallengeNumNotEnough = 1901,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHAPTER_REWARD_ID_NOT_EXIST")]
    RetChapterRewardIdNotExist = 1902,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHAPTER_REWARD_ALREADY_TAKEN")]
    RetChapterRewardAlreadyTaken = 1903,

    [ProtoBuf.ProtoEnum(Name = @"RET_BATTLE_STAGE_NOT_MATCH")]
    RetBattleStageNotMatch = 2000,

    [ProtoBuf.ProtoEnum(Name = @"RET_IN_BATTLE_NOW")]
    RetInBattleNow = 2001,

    [ProtoBuf.ProtoEnum(Name = @"RET_BATTLE_CHEAT")]
    RetBattleCheat = 2002,

    [ProtoBuf.ProtoEnum(Name = @"RET_BATTLE_FAIL")]
    RetBattleFail = 2003,

    [ProtoBuf.ProtoEnum(Name = @"RET_BATTLE_NO_LINEUP")]
    RetBattleNoLineup = 2004,

    [ProtoBuf.ProtoEnum(Name = @"RET_BATTLE_LINEUP_EMPTY")]
    RetBattleLineupEmpty = 2005,

    [ProtoBuf.ProtoEnum(Name = @"RET_BATTLE_VERSION_NOT_MATCH")]
    RetBattleVersionNotMatch = 2006,

    [ProtoBuf.ProtoEnum(Name = @"RET_BATTLE_QUIT_BY_SERVER")]
    RetBattleQuitByServer = 2007,

    [ProtoBuf.ProtoEnum(Name = @"RET_IN_BATTLE_CHECK")]
    RetInBattleCheck = 2008,

    [ProtoBuf.ProtoEnum(Name = @"RET_BATTLE_CHECK_NEED_RETRY")]
    RetBattleCheckNeedRetry = 2009,

    [ProtoBuf.ProtoEnum(Name = @"RET_BATTLE_COST_TIME_CHECK_FAIL")]
    RetBattleCostTimeCheckFail = 2010,

    [ProtoBuf.ProtoEnum(Name = @"RET_LACK_EXCHANGE_STAMINA_TIMES")]
    RetLackExchangeStaminaTimes = 2100,

    [ProtoBuf.ProtoEnum(Name = @"RET_LACK_STAMINA")]
    RetLackStamina = 2101,

    [ProtoBuf.ProtoEnum(Name = @"RET_STAMINA_FULL")]
    RetStaminaFull = 2102,

    [ProtoBuf.ProtoEnum(Name = @"RET_AUTHKEY_SIGN_TYPE_ERROR")]
    RetAuthkeySignTypeError = 2103,

    [ProtoBuf.ProtoEnum(Name = @"RET_AUTHKEY_SIGN_VER_ERROR")]
    RetAuthkeySignVerError = 2104,

    [ProtoBuf.ProtoEnum(Name = @"RET_NICKNAME_FORMAT_ERROR")]
    RetNicknameFormatError = 2105,

    [ProtoBuf.ProtoEnum(Name = @"RET_SENSITIVE_WORDS")]
    RetSensitiveWords = 2106,

    [ProtoBuf.ProtoEnum(Name = @"RET_LEVEL_REWARD_HAS_TAKEN")]
    RetLevelRewardHasTaken = 2107,

    [ProtoBuf.ProtoEnum(Name = @"RET_LEVEL_REWARD_LEVEL_ERROR")]
    RetLevelRewardLevelError = 2108,

    [ProtoBuf.ProtoEnum(Name = @"RET_LANGUAGE_INVALID")]
    RetLanguageInvalid = 2109,

    [ProtoBuf.ProtoEnum(Name = @"RET_NICKNAME_IN_CD")]
    RetNicknameInCd = 2110,

    [ProtoBuf.ProtoEnum(Name = @"RET_GAMEPLAY_BIRTHDAY_INVALID")]
    RetGameplayBirthdayInvalid = 2111,

    [ProtoBuf.ProtoEnum(Name = @"RET_GAMEPLAY_BIRTHDAY_ALREADY_SET")]
    RetGameplayBirthdayAlreadySet = 2112,

    [ProtoBuf.ProtoEnum(Name = @"RET_NICKNAME_UTF8_ERROR")]
    RetNicknameUtf8Error = 2113,

    [ProtoBuf.ProtoEnum(Name = @"RET_NICKNAME_DIGIT_LIMIT_ERROR")]
    RetNicknameDigitLimitError = 2114,

    [ProtoBuf.ProtoEnum(Name = @"RET_SENSITIVE_WORDS_PLATFORM_ERROR")]
    RetSensitiveWordsPlatformError = 2115,

    [ProtoBuf.ProtoEnum(Name = @"RET_PLAYER_SETTING_TYPE_INVALID")]
    RetPlayerSettingTypeInvalid = 2116,

    [ProtoBuf.ProtoEnum(Name = @"RET_MAZE_LACK_TICKET")]
    RetMazeLackTicket = 2201,

    [ProtoBuf.ProtoEnum(Name = @"RET_MAZE_NOT_UNLOCK")]
    RetMazeNotUnlock = 2202,

    [ProtoBuf.ProtoEnum(Name = @"RET_MAZE_NO_ABILITY")]
    RetMazeNoAbility = 2204,

    [ProtoBuf.ProtoEnum(Name = @"RET_MAZE_NO_PLANE")]
    RetMazeNoPlane = 2205,

    [ProtoBuf.ProtoEnum(Name = @"RET_MAZE_MAP_NOT_EXIST")]
    RetMazeMapNotExist = 2207,

    [ProtoBuf.ProtoEnum(Name = @"RET_MAZE_MP_NOT_ENOUGH")]
    RetMazeMpNotEnough = 2213,

    [ProtoBuf.ProtoEnum(Name = @"RET_SPRING_NOT_ENABLE")]
    RetSpringNotEnable = 2214,

    [ProtoBuf.ProtoEnum(Name = @"RET_SPRING_TOO_FAR")]
    RetSpringTooFar = 2216,

    [ProtoBuf.ProtoEnum(Name = @"RET_NOT_IN_MAZE")]
    RetNotInMaze = 2218,

    [ProtoBuf.ProtoEnum(Name = @"RET_MAZE_TIME_OF_DAY_TYPE_ERROR")]
    RetMazeTimeOfDayTypeError = 2223,

    [ProtoBuf.ProtoEnum(Name = @"RET_PLOT_NOT_UNLOCK")]
    RetPlotNotUnlock = 2300,

    [ProtoBuf.ProtoEnum(Name = @"RET_MISSION_NOT_EXIST")]
    RetMissionNotExist = 2400,

    [ProtoBuf.ProtoEnum(Name = @"RET_MISSION_ALREADY_DONE")]
    RetMissionAlreadyDone = 2401,

    [ProtoBuf.ProtoEnum(Name = @"RET_DAILY_TASK_NOT_FINISH")]
    RetDailyTaskNotFinish = 2402,

    [ProtoBuf.ProtoEnum(Name = @"RET_DAILY_TASK_REWARD_HAS_TAKEN")]
    RetDailyTaskRewardHasTaken = 2403,

    [ProtoBuf.ProtoEnum(Name = @"RET_MISSION_NOT_FINISH")]
    RetMissionNotFinish = 2404,

    [ProtoBuf.ProtoEnum(Name = @"RET_MISSION_NOT_DOING")]
    RetMissionNotDoing = 2405,

    [ProtoBuf.ProtoEnum(Name = @"RET_MISSION_FINISH_WAY_NOT_MATCH")]
    RetMissionFinishWayNotMatch = 2406,

    [ProtoBuf.ProtoEnum(Name = @"RET_MISSION_SCENE_NOT_MATCH")]
    RetMissionSceneNotMatch = 2407,

    [ProtoBuf.ProtoEnum(Name = @"RET_MISSION_CUSTOM_VALUE_NOT_VALID")]
    RetMissionCustomValueNotValid = 2408,

    [ProtoBuf.ProtoEnum(Name = @"RET_MISSION_SUB_MISSION_NOT_MATCH")]
    RetMissionSubMissionNotMatch = 2409,

    [ProtoBuf.ProtoEnum(Name = @"RET_ADVENTURE_MAP_NOT_EXIST")]
    RetAdventureMapNotExist = 2500,

    [ProtoBuf.ProtoEnum(Name = @"RET_SCENE_ENTITY_NOT_EXIST")]
    RetSceneEntityNotExist = 2600,

    [ProtoBuf.ProtoEnum(Name = @"RET_NOT_IN_SCENE")]
    RetNotInScene = 2601,

    [ProtoBuf.ProtoEnum(Name = @"RET_SCENE_MONSTER_NOT_EXIST")]
    RetSceneMonsterNotExist = 2602,

    [ProtoBuf.ProtoEnum(Name = @"RET_INTERACT_CONFIG_NOT_EXIST")]
    RetInteractConfigNotExist = 2603,

    [ProtoBuf.ProtoEnum(Name = @"RET_UNSUPPORTED_PROP_STATE")]
    RetUnsupportedPropState = 2604,

    [ProtoBuf.ProtoEnum(Name = @"RET_SCENE_ENTRY_ID_NOT_MATCH")]
    RetSceneEntryIdNotMatch = 2605,

    [ProtoBuf.ProtoEnum(Name = @"RET_SCENE_ENTITY_MOVE_CHECK_FAILED")]
    RetSceneEntityMoveCheckFailed = 2606,

    [ProtoBuf.ProtoEnum(Name = @"RET_ASSIST_MONSTER_COUNT_LIMIT")]
    RetAssistMonsterCountLimit = 2607,

    [ProtoBuf.ProtoEnum(Name = @"RET_SCENE_USE_SKILL_FAIL")]
    RetSceneUseSkillFail = 2608,

    [ProtoBuf.ProtoEnum(Name = @"RET_PROP_IS_HIDDEN")]
    RetPropIsHidden = 2609,

    [ProtoBuf.ProtoEnum(Name = @"RET_LOADING_SUCC_ALREADY")]
    RetLoadingSuccAlready = 2610,

    [ProtoBuf.ProtoEnum(Name = @"RET_SCENE_ENTITY_TYPE_INVALID")]
    RetSceneEntityTypeInvalid = 2611,

    [ProtoBuf.ProtoEnum(Name = @"RET_INTERACT_TYPE_INVALID")]
    RetInteractTypeInvalid = 2612,

    [ProtoBuf.ProtoEnum(Name = @"RET_INTERACT_NOT_IN_REGION")]
    RetInteractNotInRegion = 2613,

    [ProtoBuf.ProtoEnum(Name = @"RET_INTERACT_SUB_TYPE_INVALID")]
    RetInteractSubTypeInvalid = 2614,

    [ProtoBuf.ProtoEnum(Name = @"RET_NOT_LEADER_ENTITY")]
    RetNotLeaderEntity = 2615,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONSTER_IS_NOT_FARM_ELEMENT")]
    RetMonsterIsNotFarmElement = 2616,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONSTER_CONFIG_NOT_EXIST")]
    RetMonsterConfigNotExist = 2617,

    [ProtoBuf.ProtoEnum(Name = @"RET_AVATAR_HP_ALREADY_FULL")]
    RetAvatarHpAlreadyFull = 2618,

    [ProtoBuf.ProtoEnum(Name = @"RET_CUR_INTERACT_ENTITY_NOT_MATCH")]
    RetCurInteractEntityNotMatch = 2619,

    [ProtoBuf.ProtoEnum(Name = @"RET_PLANE_TYPE_NOT_ALLOW")]
    RetPlaneTypeNotAllow = 2620,

    [ProtoBuf.ProtoEnum(Name = @"RET_GROUP_NOT_EXIST")]
    RetGroupNotExist = 2621,

    [ProtoBuf.ProtoEnum(Name = @"RET_GROUP_SAVE_DATA_IN_CD")]
    RetGroupSaveDataInCd = 2622,

    [ProtoBuf.ProtoEnum(Name = @"RET_GROUP_SAVE_LENGH_REACH_MAX")]
    RetGroupSaveLenghReachMax = 2623,

    [ProtoBuf.ProtoEnum(Name = @"RET_RECENT_ELEMENT_NOT_EXIST")]
    RetRecentElementNotExist = 2624,

    [ProtoBuf.ProtoEnum(Name = @"RET_RECENT_ELEMENT_STAGE_NOT_MATCH")]
    RetRecentElementStageNotMatch = 2625,

    [ProtoBuf.ProtoEnum(Name = @"RET_SCENE_POSITION_VERSION_NOT_MATCH")]
    RetScenePositionVersionNotMatch = 2626,

    [ProtoBuf.ProtoEnum(Name = @"RET_GAMEPLAY_COUNTER_NOT_EXIST")]
    RetGameplayCounterNotExist = 2627,

    [ProtoBuf.ProtoEnum(Name = @"RET_GAMEPLAY_COUNTER_NOT_ENOUGH")]
    RetGameplayCounterNotEnough = 2628,

    [ProtoBuf.ProtoEnum(Name = @"RET_GROUP_STATE_NOT_MATCH")]
    RetGroupStateNotMatch = 2629,

    [ProtoBuf.ProtoEnum(Name = @"RET_SCENE_ENTITY_POS_NOT_MATCH")]
    RetSceneEntityPosNotMatch = 2630,

    [ProtoBuf.ProtoEnum(Name = @"RET_GROUP_STATE_CUSTOM_SAVE_DATA_OFF")]
    RetGroupStateCustomSaveDataOff = 2631,

    [ProtoBuf.ProtoEnum(Name = @"RET_BUY_TIMES_LIMIT")]
    RetBuyTimesLimit = 2700,

    [ProtoBuf.ProtoEnum(Name = @"RET_BUY_LIMIT_TYPE")]
    RetBuyLimitType = 2701,

    [ProtoBuf.ProtoEnum(Name = @"RET_SHOP_NOT_OPEN")]
    RetShopNotOpen = 2702,

    [ProtoBuf.ProtoEnum(Name = @"RET_GOODS_NOT_OPEN")]
    RetGoodsNotOpen = 2703,

    [ProtoBuf.ProtoEnum(Name = @"RET_CITY_LEVEL_REWARD_TAKEN")]
    RetCityLevelRewardTaken = 2704,

    [ProtoBuf.ProtoEnum(Name = @"RET_CITY_LEVEL_NOT_MEET")]
    RetCityLevelNotMeet = 2705,

    [ProtoBuf.ProtoEnum(Name = @"RET_SINGLE_BUY_LIMIT")]
    RetSingleBuyLimit = 2706,

    [ProtoBuf.ProtoEnum(Name = @"RET_TUTORIAL_NOT_UNLOCK")]
    RetTutorialNotUnlock = 2751,

    [ProtoBuf.ProtoEnum(Name = @"RET_TUTORIAL_UNLOCK_ALREADY")]
    RetTutorialUnlockAlready = 2752,

    [ProtoBuf.ProtoEnum(Name = @"RET_TUTORIAL_FINISH_ALREADY")]
    RetTutorialFinishAlready = 2753,

    [ProtoBuf.ProtoEnum(Name = @"RET_TUTORIAL_PRE_NOT_UNLOCK")]
    RetTutorialPreNotUnlock = 2754,

    [ProtoBuf.ProtoEnum(Name = @"RET_TUTORIAL_PLAYER_LEVEL_NOT_MATCH")]
    RetTutorialPlayerLevelNotMatch = 2755,

    [ProtoBuf.ProtoEnum(Name = @"RET_TUTORIAL_TUTORIAL_NOT_FOUND")]
    RetTutorialTutorialNotFound = 2756,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHALLENGE_NOT_EXIST")]
    RetChallengeNotExist = 2801,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHALLENGE_NOT_UNLOCK")]
    RetChallengeNotUnlock = 2802,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHALLENGE_ALREADY")]
    RetChallengeAlready = 2803,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHALLENGE_LINEUP_EDIT_FORBIDDEN")]
    RetChallengeLineupEditForbidden = 2804,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHALLENGE_LINEUP_EMPTY")]
    RetChallengeLineupEmpty = 2805,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHALLENGE_NOT_DOING")]
    RetChallengeNotDoing = 2806,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHALLENGE_NOT_FINISH")]
    RetChallengeNotFinish = 2807,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHALLENGE_TARGET_NOT_FINISH")]
    RetChallengeTargetNotFinish = 2808,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHALLENGE_TARGET_REWARD_TAKEN")]
    RetChallengeTargetRewardTaken = 2809,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHALLENGE_TIME_NOT_VALID")]
    RetChallengeTimeNotValid = 2810,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHALLENGE_STARS_COUNT_NOT_MEET")]
    RetChallengeStarsCountNotMeet = 2811,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHALLENGE_STARS_REWARD_TAKEN")]
    RetChallengeStarsRewardTaken = 2812,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHALLENGE_STARS_NOT_EXIST")]
    RetChallengeStarsNotExist = 2813,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHALLENGE_CUR_SCENE_NOT_ENTRY_FLOOR")]
    RetChallengeCurSceneNotEntryFloor = 2814,

    [ProtoBuf.ProtoEnum(Name = @"RET_BASIC_TYPE_ALREADY")]
    RetBasicTypeAlready = 2850,

    [ProtoBuf.ProtoEnum(Name = @"RET_NO_BASIC_TYPE")]
    RetNoBasicType = 2851,

    [ProtoBuf.ProtoEnum(Name = @"RET_NOT_CHOOSE_BASIC_TYPE")]
    RetNotChooseBasicType = 2852,

    [ProtoBuf.ProtoEnum(Name = @"RET_NOT_FUNC_CLOSE")]
    RetNotFuncClose = 2853,

    [ProtoBuf.ProtoEnum(Name = @"RET_NOT_CHOOSE_GENDER")]
    RetNotChooseGender = 2854,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROGUE_STATUS_NOT_MATCH")]
    RetRogueStatusNotMatch = 2901,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROGUE_SELECT_BUFF_NOT_EXIST")]
    RetRogueSelectBuffNotExist = 2902,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROGUE_COIN_NOT_ENOUGH")]
    RetRogueCoinNotEnough = 2903,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROGUE_STAMINA_NOT_ENOUGH")]
    RetRogueStaminaNotEnough = 2904,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROGUE_APPRAISAL_COUNT_NOT_ENOUGH")]
    RetRogueAppraisalCountNotEnough = 2905,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROGUE_PROP_ALREADY_USED")]
    RetRoguePropAlreadyUsed = 2906,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROGUE_RECORD_ALREADY_SAVED")]
    RetRogueRecordAlreadySaved = 2907,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROGUE_ROLL_BUFF_MAX_COUNT")]
    RetRogueRollBuffMaxCount = 2908,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROGUE_PICK_AVATAR_INVALID")]
    RetRoguePickAvatarInvalid = 2909,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROGUE_QUEST_EXPIRE")]
    RetRogueQuestExpire = 2910,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROGUE_QUEST_REWARD_ALREADY")]
    RetRogueQuestRewardAlready = 2911,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROGUE_REVIVE_COUNT_NOT_ENOUGH")]
    RetRogueReviveCountNotEnough = 2912,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROGUE_AREA_INVALID")]
    RetRogueAreaInvalid = 2913,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROGUE_SCORE_REWARD_POOL_INVALID")]
    RetRogueScoreRewardPoolInvalid = 2914,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROGUE_SCORE_REWARD_ROW_INVALID")]
    RetRogueScoreRewardRowInvalid = 2915,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROGUE_AEON_LEVEL_NOT_MEET")]
    RetRogueAeonLevelNotMeet = 2916,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROGUE_AEON_LEVEL_REWARD_ALREADY_TAKEN")]
    RetRogueAeonLevelRewardAlreadyTaken = 2917,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROGUE_AEON_CONFIG_NOT_EXIST")]
    RetRogueAeonConfigNotExist = 2918,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROGUE_TRIAL_AVATAR_INVALID")]
    RetRogueTrialAvatarInvalid = 2919,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROGUE_HANDBOOK_REWARD_ALREADY_TAKEN")]
    RetRogueHandbookRewardAlreadyTaken = 2920,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROGUE_ROOM_TYPE_NOT_MATCH")]
    RetRogueRoomTypeNotMatch = 2921,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROGUE_SHOP_GOOD_NOT_FOUND")]
    RetRogueShopGoodNotFound = 2922,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROGUE_SHOP_GOOD_ALREADY_BOUGHT")]
    RetRogueShopGoodAlreadyBought = 2923,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROGUE_SHOP_GOOD_ALREADY_OWN")]
    RetRogueShopGoodAlreadyOwn = 2924,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROGUE_SHOP_MIRACLE_NOT_EXIST")]
    RetRogueShopMiracleNotExist = 2925,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROGUE_SHOP_NOT_EXIST")]
    RetRogueShopNotExist = 2926,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROGUE_SHOP_CANNOT_REFRESH")]
    RetRogueShopCannotRefresh = 2927,

    [ProtoBuf.ProtoEnum(Name = @"RET_MISSION_EVENT_CONFIG_NOT_EXIST")]
    RetMissionEventConfigNotExist = 2951,

    [ProtoBuf.ProtoEnum(Name = @"RET_MISSION_EVENT_NOT_CLIENT")]
    RetMissionEventNotClient = 2952,

    [ProtoBuf.ProtoEnum(Name = @"RET_MISSION_EVENT_FINISHED")]
    RetMissionEventFinished = 2953,

    [ProtoBuf.ProtoEnum(Name = @"RET_MISSION_EVENT_DOING")]
    RetMissionEventDoing = 2954,

    [ProtoBuf.ProtoEnum(Name = @"RET_HAS_CHALLENGE_MISSION_EVENT")]
    RetHasChallengeMissionEvent = 2955,

    [ProtoBuf.ProtoEnum(Name = @"RET_NOT_CHALLENGE_MISSION_EVENT")]
    RetNotChallengeMissionEvent = 2956,

    [ProtoBuf.ProtoEnum(Name = @"RET_GACHA_ID_NOT_EXIST")]
    RetGachaIdNotExist = 3001,

    [ProtoBuf.ProtoEnum(Name = @"RET_GACHA_NUM_INVALID")]
    RetGachaNumInvalid = 3002,

    [ProtoBuf.ProtoEnum(Name = @"RET_GACHA_FIRST_GACHA_MUST_ONE")]
    RetGachaFirstGachaMustOne = 3003,

    [ProtoBuf.ProtoEnum(Name = @"RET_GACHA_REQ_DUPLICATED")]
    RetGachaReqDuplicated = 3004,

    [ProtoBuf.ProtoEnum(Name = @"RET_GACHA_NOT_IN_SCHEDULE")]
    RetGachaNotInSchedule = 3005,

    [ProtoBuf.ProtoEnum(Name = @"RET_GACHA_NEWBIE_CLOSE")]
    RetGachaNewbieClose = 3006,

    [ProtoBuf.ProtoEnum(Name = @"RET_GACHA_TODAY_LIMITED")]
    RetGachaTodayLimited = 3007,

    [ProtoBuf.ProtoEnum(Name = @"RET_GACHA_NOT_SUPPORT")]
    RetGachaNotSupport = 3008,

    [ProtoBuf.ProtoEnum(Name = @"RET_GACHA_CEILING_NOT_ENOUGH")]
    RetGachaCeilingNotEnough = 3009,

    [ProtoBuf.ProtoEnum(Name = @"RET_GACHA_CEILING_CLOSE")]
    RetGachaCeilingClose = 3010,

    [ProtoBuf.ProtoEnum(Name = @"RET_NOT_IN_RAID")]
    RetNotInRaid = 3101,

    [ProtoBuf.ProtoEnum(Name = @"RET_RAID_DOING")]
    RetRaidDoing = 3102,

    [ProtoBuf.ProtoEnum(Name = @"RET_NOT_PROP")]
    RetNotProp = 3103,

    [ProtoBuf.ProtoEnum(Name = @"RET_RAID_ID_NOT_MATCH")]
    RetRaidIdNotMatch = 3104,

    [ProtoBuf.ProtoEnum(Name = @"RET_RAID_RESTART_NOT_MATCH")]
    RetRaidRestartNotMatch = 3105,

    [ProtoBuf.ProtoEnum(Name = @"RET_RAID_LIMIT")]
    RetRaidLimit = 3106,

    [ProtoBuf.ProtoEnum(Name = @"RET_RAID_AVATAR_LIST_EMPTY")]
    RetRaidAvatarListEmpty = 3107,

    [ProtoBuf.ProtoEnum(Name = @"RET_RAID_AVATAR_NOT_EXIST")]
    RetRaidAvatarNotExist = 3108,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHALLENGE_RAID_REWARD_ALREADY")]
    RetChallengeRaidRewardAlready = 3109,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHALLENGE_RAID_SCORE_NOT_REACH")]
    RetChallengeRaidScoreNotReach = 3110,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHALLENGE_RAID_NOT_OPEN")]
    RetChallengeRaidNotOpen = 3111,

    [ProtoBuf.ProtoEnum(Name = @"RET_RAID_FINISHED")]
    RetRaidFinished = 3112,

    [ProtoBuf.ProtoEnum(Name = @"RET_RAID_WORLD_LEVEL_NOT_LOCK")]
    RetRaidWorldLevelNotLock = 3113,

    [ProtoBuf.ProtoEnum(Name = @"RET_RAID_CANNOT_USE_ASSIST")]
    RetRaidCannotUseAssist = 3114,

    [ProtoBuf.ProtoEnum(Name = @"RET_RAID_AVATAR_NOT_MATCH")]
    RetRaidAvatarNotMatch = 3115,

    [ProtoBuf.ProtoEnum(Name = @"RET_RAID_CAN_NOT_SAVE")]
    RetRaidCanNotSave = 3116,

    [ProtoBuf.ProtoEnum(Name = @"RET_RAID_NO_SAVE")]
    RetRaidNoSave = 3117,

    [ProtoBuf.ProtoEnum(Name = @"RET_ACTIVITY_RAID_NOT_OPEN")]
    RetActivityRaidNotOpen = 3118,

    [ProtoBuf.ProtoEnum(Name = @"RET_RAID_AVATAR_CAPTAIN_NOT_EXIST")]
    RetRaidAvatarCaptainNotExist = 3119,

    [ProtoBuf.ProtoEnum(Name = @"RET_RAID_STORY_LINE_NOT_MATCH")]
    RetRaidStoryLineNotMatch = 3120,

    [ProtoBuf.ProtoEnum(Name = @"RET_TALK_EVENT_ALREADY_TAKEN")]
    RetTalkEventAlreadyTaken = 3151,

    [ProtoBuf.ProtoEnum(Name = @"RET_NPC_ALREADY_MEET")]
    RetNpcAlreadyMeet = 3152,

    [ProtoBuf.ProtoEnum(Name = @"RET_NPC_NOT_IN_CONFIG")]
    RetNpcNotInConfig = 3153,

    [ProtoBuf.ProtoEnum(Name = @"RET_DIALOGUE_GROUP_DISMATCH")]
    RetDialogueGroupDismatch = 3154,

    [ProtoBuf.ProtoEnum(Name = @"RET_DIALOGUE_EVENT_INVALID")]
    RetDialogueEventInvalid = 3155,

    [ProtoBuf.ProtoEnum(Name = @"RET_TALK_EVENT_TAKE_PROTO_NOT_MATCH")]
    RetTalkEventTakeProtoNotMatch = 3156,

    [ProtoBuf.ProtoEnum(Name = @"RET_TALK_EVENT_NOT_VALID")]
    RetTalkEventNotValid = 3157,

    [ProtoBuf.ProtoEnum(Name = @"RET_EXPEDITION_CONFIG_NOT_EXIST")]
    RetExpeditionConfigNotExist = 3201,

    [ProtoBuf.ProtoEnum(Name = @"RET_EXPEDITION_REWARD_CONFIG_NOT_EXIST")]
    RetExpeditionRewardConfigNotExist = 3202,

    [ProtoBuf.ProtoEnum(Name = @"RET_EXPEDITION_NOT_UNLOCKED")]
    RetExpeditionNotUnlocked = 3203,

    [ProtoBuf.ProtoEnum(Name = @"RET_EXPEDITION_ALREADY_ACCEPTED")]
    RetExpeditionAlreadyAccepted = 3204,

    [ProtoBuf.ProtoEnum(Name = @"RET_EXPEDITION_REPEATED_AVATAR")]
    RetExpeditionRepeatedAvatar = 3205,

    [ProtoBuf.ProtoEnum(Name = @"RET_AVATAR_ALREADY_DISPATCHED")]
    RetAvatarAlreadyDispatched = 3206,

    [ProtoBuf.ProtoEnum(Name = @"RET_EXPEDITION_NOT_ACCEPTED")]
    RetExpeditionNotAccepted = 3207,

    [ProtoBuf.ProtoEnum(Name = @"RET_EXPEDITION_NOT_FINISH")]
    RetExpeditionNotFinish = 3208,

    [ProtoBuf.ProtoEnum(Name = @"RET_EXPEDITION_ALREADY_FINISH")]
    RetExpeditionAlreadyFinish = 3209,

    [ProtoBuf.ProtoEnum(Name = @"RET_EXPEDITION_TEAM_COUNT_LIMIT")]
    RetExpeditionTeamCountLimit = 3210,

    [ProtoBuf.ProtoEnum(Name = @"RET_EXPEDITION_AVATAR_NUM_NOT_MATCH")]
    RetExpeditionAvatarNumNotMatch = 3211,

    [ProtoBuf.ProtoEnum(Name = @"RET_EXPEDITION_NOT_OPEN")]
    RetExpeditionNotOpen = 3212,

    [ProtoBuf.ProtoEnum(Name = @"RET_EXPEDITION_FRIEND_AVATAR_NOT_VALID")]
    RetExpeditionFriendAvatarNotValid = 3213,

    [ProtoBuf.ProtoEnum(Name = @"RET_EXPEDITION_NOT_PUBLISHED")]
    RetExpeditionNotPublished = 3214,

    [ProtoBuf.ProtoEnum(Name = @"RET_LOGIN_ACTIVITY_HAS_TAKEN")]
    RetLoginActivityHasTaken = 3301,

    [ProtoBuf.ProtoEnum(Name = @"RET_LOGIN_ACTIVITY_DAYS_LACK")]
    RetLoginActivityDaysLack = 3302,

    [ProtoBuf.ProtoEnum(Name = @"RET_TRIAL_ACTIVITY_REWARD_ALREADY_TAKE")]
    RetTrialActivityRewardAlreadyTake = 3303,

    [ProtoBuf.ProtoEnum(Name = @"RET_TRIAL_ACTIVITY_STAGE_NOT_FINISH")]
    RetTrialActivityStageNotFinish = 3304,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONSTER_RESEARCH_ACTIVITY_HAS_TAKEN")]
    RetMonsterResearchActivityHasTaken = 3305,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONSTER_RESEARCH_ACTIVITY_MATERIAL_NOT_SUBMITTED")]
    RetMonsterResearchActivityMaterialNotSubmitted = 3306,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONSTER_RESEARCH_ACTIVITY_MATERIAL_ALREADY_SUBMITTED")]
    RetMonsterResearchActivityMaterialAlreadySubmitted = 3307,

    [ProtoBuf.ProtoEnum(Name = @"RET_FANTASTIC_STORY_ACTIVITY_STORY_ERROR")]
    RetFantasticStoryActivityStoryError = 3308,

    [ProtoBuf.ProtoEnum(Name = @"RET_FANTASTIC_STORY_ACTIVITY_STORY_NOT_OPEN")]
    RetFantasticStoryActivityStoryNotOpen = 3309,

    [ProtoBuf.ProtoEnum(Name = @"RET_FANTASTIC_STORY_ACTIVITY_BATTLE_ERROR")]
    RetFantasticStoryActivityBattleError = 3310,

    [ProtoBuf.ProtoEnum(Name = @"RET_FANTASTIC_STORY_ACTIVITY_BATTLE_NOT_OPEN")]
    RetFantasticStoryActivityBattleNotOpen = 3311,

    [ProtoBuf.ProtoEnum(Name = @"RET_FANTASTIC_STORY_ACTIVITY_BATTLE_AVATAR_ERROR")]
    RetFantasticStoryActivityBattleAvatarError = 3312,

    [ProtoBuf.ProtoEnum(Name = @"RET_FANTASTIC_STORY_ACTIVITY_BATTLE_BUFF_ERROR")]
    RetFantasticStoryActivityBattleBuffError = 3313,

    [ProtoBuf.ProtoEnum(Name = @"RET_FANTASTIC_STORY_ACTIVITY_PRE_BATTLE_SCORE_NOT_ENOUGH")]
    RetFantasticStoryActivityPreBattleScoreNotEnough = 3314,

    [ProtoBuf.ProtoEnum(Name = @"RET_TRIAL_ACTIVITY_ALREADY_IN_TRIAL_ACTIVITY")]
    RetTrialActivityAlreadyInTrialActivity = 3315,

    [ProtoBuf.ProtoEnum(Name = @"RET_MESSAGE_CONFIG_NOT_EXIST")]
    RetMessageConfigNotExist = 3501,

    [ProtoBuf.ProtoEnum(Name = @"RET_MESSAGE_SECTION_NOT_TAKE")]
    RetMessageSectionNotTake = 3502,

    [ProtoBuf.ProtoEnum(Name = @"RET_MESSAGE_GROUP_NOT_TAKE")]
    RetMessageGroupNotTake = 3503,

    [ProtoBuf.ProtoEnum(Name = @"RET_MESSAGE_SECTION_ID_NOT_MATCH")]
    RetMessageSectionIdNotMatch = 3504,

    [ProtoBuf.ProtoEnum(Name = @"RET_MESSAGE_SECTION_CAN_NOT_FINISH")]
    RetMessageSectionCanNotFinish = 3505,

    [ProtoBuf.ProtoEnum(Name = @"RET_MESSAGE_ITEM_CAN_NOT_FINISH")]
    RetMessageItemCanNotFinish = 3506,

    [ProtoBuf.ProtoEnum(Name = @"RET_MESSAGE_ITEM_RAID_CAN_NOT_FINISH")]
    RetMessageItemRaidCanNotFinish = 3507,

    [ProtoBuf.ProtoEnum(Name = @"RET_FRIEND_ALREADY_IS_FRIEND")]
    RetFriendAlreadyIsFriend = 3601,

    [ProtoBuf.ProtoEnum(Name = @"RET_FRIEND_IS_NOT_FRIEND")]
    RetFriendIsNotFriend = 3602,

    [ProtoBuf.ProtoEnum(Name = @"RET_FRIEND_APPLY_EXPIRE")]
    RetFriendApplyExpire = 3603,

    [ProtoBuf.ProtoEnum(Name = @"RET_FRIEND_IN_BLACKLIST")]
    RetFriendInBlacklist = 3604,

    [ProtoBuf.ProtoEnum(Name = @"RET_FRIEND_NOT_IN_BLACKLIST")]
    RetFriendNotInBlacklist = 3605,

    [ProtoBuf.ProtoEnum(Name = @"RET_FRIEND_NUMBER_LIMIT")]
    RetFriendNumberLimit = 3606,

    [ProtoBuf.ProtoEnum(Name = @"RET_FRIEND_BLACKLIST_NUMBER_LIMIT")]
    RetFriendBlacklistNumberLimit = 3607,

    [ProtoBuf.ProtoEnum(Name = @"RET_FRIEND_DAILY_APPLY_LIMIT")]
    RetFriendDailyApplyLimit = 3608,

    [ProtoBuf.ProtoEnum(Name = @"RET_FRIEND_IN_HANDLE_LIMIT")]
    RetFriendInHandleLimit = 3609,

    [ProtoBuf.ProtoEnum(Name = @"RET_FRIEND_APPLY_IN_CD")]
    RetFriendApplyInCd = 3610,

    [ProtoBuf.ProtoEnum(Name = @"RET_FRIEND_REMARK_NAME_FORMAT_ERROR")]
    RetFriendRemarkNameFormatError = 3611,

    [ProtoBuf.ProtoEnum(Name = @"RET_FRIEND_PLAYER_NOT_FOUND")]
    RetFriendPlayerNotFound = 3612,

    [ProtoBuf.ProtoEnum(Name = @"RET_FRIEND_IN_TARGET_BLACKLIST")]
    RetFriendInTargetBlacklist = 3613,

    [ProtoBuf.ProtoEnum(Name = @"RET_FRIEND_TARGET_NUMBER_LIMIT")]
    RetFriendTargetNumberLimit = 3614,

    [ProtoBuf.ProtoEnum(Name = @"RET_ASSIST_QUERY_TOO_FAST")]
    RetAssistQueryTooFast = 3615,

    [ProtoBuf.ProtoEnum(Name = @"RET_ASSIST_NOT_EXIST")]
    RetAssistNotExist = 3616,

    [ProtoBuf.ProtoEnum(Name = @"RET_ASSIST_USED_ALREADY")]
    RetAssistUsedAlready = 3617,

    [ProtoBuf.ProtoEnum(Name = @"RET_FRIEND_REPORT_REASON_FORMAT_ERROR")]
    RetFriendReportReasonFormatError = 3618,

    [ProtoBuf.ProtoEnum(Name = @"RET_FRIEND_REPORT_SENSITIVE_WORDS")]
    RetFriendReportSensitiveWords = 3619,

    [ProtoBuf.ProtoEnum(Name = @"RET_ASSIST_USED_TIMES_OVER")]
    RetAssistUsedTimesOver = 3620,

    [ProtoBuf.ProtoEnum(Name = @"RET_ASSIST_QUIT_ALREADY")]
    RetAssistQuitAlready = 3621,

    [ProtoBuf.ProtoEnum(Name = @"RET_ASSIST_AVATAR_IN_LINEUP")]
    RetAssistAvatarInLineup = 3622,

    [ProtoBuf.ProtoEnum(Name = @"RET_ASSIST_NO_REWARD")]
    RetAssistNoReward = 3623,

    [ProtoBuf.ProtoEnum(Name = @"RET_FRIEND_SEARCH_NUM_LIMIT")]
    RetFriendSearchNumLimit = 3624,

    [ProtoBuf.ProtoEnum(Name = @"RET_FRIEND_SEARCH_IN_CD")]
    RetFriendSearchInCd = 3625,

    [ProtoBuf.ProtoEnum(Name = @"RET_FRIEND_REMARK_NAME_UTF8_ERROR")]
    RetFriendRemarkNameUtf8Error = 3626,

    [ProtoBuf.ProtoEnum(Name = @"RET_FRIEND_REPORT_REASON_UTF8_ERROR")]
    RetFriendReportReasonUtf8Error = 3627,

    [ProtoBuf.ProtoEnum(Name = @"RET_ASSIST_SET_ALREADY")]
    RetAssistSetAlready = 3628,

    [ProtoBuf.ProtoEnum(Name = @"RET_FRIEND_TARGET_FORBID_OTHER_APPLY")]
    RetFriendTargetForbidOtherApply = 3629,

    [ProtoBuf.ProtoEnum(Name = @"RET_FRIEND_MARKED_CNT_MAX")]
    RetFriendMarkedCntMax = 3630,

    [ProtoBuf.ProtoEnum(Name = @"RET_FRIEND_MARKED_ALREADY")]
    RetFriendMarkedAlready = 3631,

    [ProtoBuf.ProtoEnum(Name = @"RET_FRIEND_NOT_MARKED")]
    RetFriendNotMarked = 3632,

    [ProtoBuf.ProtoEnum(Name = @"RET_PLAYER_BOARD_HEAD_ICON_NOT_EXIST")]
    RetPlayerBoardHeadIconNotExist = 3701,

    [ProtoBuf.ProtoEnum(Name = @"RET_PLAYER_BOARD_HEAD_ICON_LOCKED")]
    RetPlayerBoardHeadIconLocked = 3702,

    [ProtoBuf.ProtoEnum(Name = @"RET_PLAYER_BOARD_HEAD_ICON_ALREADY_UNLOCKED")]
    RetPlayerBoardHeadIconAlreadyUnlocked = 3703,

    [ProtoBuf.ProtoEnum(Name = @"RET_PLAYER_BOARD_DISPLAY_AVATAR_NOT_EXIST")]
    RetPlayerBoardDisplayAvatarNotExist = 3704,

    [ProtoBuf.ProtoEnum(Name = @"RET_PLAYER_BOARD_DISPLAY_AVATAR_EXCEED_LIMIT")]
    RetPlayerBoardDisplayAvatarExceedLimit = 3705,

    [ProtoBuf.ProtoEnum(Name = @"RET_PLAYER_BOARD_DISPLAY_REPEATED_AVATAR")]
    RetPlayerBoardDisplayRepeatedAvatar = 3706,

    [ProtoBuf.ProtoEnum(Name = @"RET_PLAYER_BOARD_DISPLAY_AVATAR_SAME_POS")]
    RetPlayerBoardDisplayAvatarSamePos = 3707,

    [ProtoBuf.ProtoEnum(Name = @"RET_PLAYER_BOARD_DISPLAY_AVATAR_LOCKED")]
    RetPlayerBoardDisplayAvatarLocked = 3708,

    [ProtoBuf.ProtoEnum(Name = @"RET_SIGNATURE_LENGTH_EXCEED_LIMIT")]
    RetSignatureLengthExceedLimit = 3709,

    [ProtoBuf.ProtoEnum(Name = @"RET_SIGNATURE_SENSITIVE_WORDS")]
    RetSignatureSensitiveWords = 3710,

    [ProtoBuf.ProtoEnum(Name = @"RET_PLAYER_BOARD_ASSIST_AVATAR_NOT_EXIST")]
    RetPlayerBoardAssistAvatarNotExist = 3712,

    [ProtoBuf.ProtoEnum(Name = @"RET_PLAYER_BOARD_ASSIST_AVATAR_LOCKED")]
    RetPlayerBoardAssistAvatarLocked = 3713,

    [ProtoBuf.ProtoEnum(Name = @"RET_SIGNATURE_UTF8_ERROR")]
    RetSignatureUtf8Error = 3714,

    [ProtoBuf.ProtoEnum(Name = @"RET_PLAYER_BOARD_ASSIST_AVATAR_CNT_ERROR")]
    RetPlayerBoardAssistAvatarCntError = 3715,

    [ProtoBuf.ProtoEnum(Name = @"RET_BATTLE_PASS_TIER_NOT_VALID")]
    RetBattlePassTierNotValid = 3801,

    [ProtoBuf.ProtoEnum(Name = @"RET_BATTLE_PASS_LEVEL_NOT_MEET")]
    RetBattlePassLevelNotMeet = 3802,

    [ProtoBuf.ProtoEnum(Name = @"RET_BATTLE_PASS_REWARD_TAKE_ALREADY")]
    RetBattlePassRewardTakeAlready = 3803,

    [ProtoBuf.ProtoEnum(Name = @"RET_BATTLE_PASS_NOT_PREMIUM")]
    RetBattlePassNotPremium = 3804,

    [ProtoBuf.ProtoEnum(Name = @"RET_BATTLE_PASS_NOT_DOING")]
    RetBattlePassNotDoing = 3805,

    [ProtoBuf.ProtoEnum(Name = @"RET_BATTLE_PASS_LEVEL_INVALID")]
    RetBattlePassLevelInvalid = 3806,

    [ProtoBuf.ProtoEnum(Name = @"RET_BATTLE_PASS_NOT_UNLOCK")]
    RetBattlePassNotUnlock = 3807,

    [ProtoBuf.ProtoEnum(Name = @"RET_BATTLE_PASS_NO_REWARD")]
    RetBattlePassNoReward = 3808,

    [ProtoBuf.ProtoEnum(Name = @"RET_BATTLE_PASS_QUEST_NOT_VALID")]
    RetBattlePassQuestNotValid = 3809,

    [ProtoBuf.ProtoEnum(Name = @"RET_BATTLE_PASS_NOT_CHOOSE_OPTIONAL")]
    RetBattlePassNotChooseOptional = 3810,

    [ProtoBuf.ProtoEnum(Name = @"RET_BATTLE_PASS_NOT_TAKE_REWARD")]
    RetBattlePassNotTakeReward = 3811,

    [ProtoBuf.ProtoEnum(Name = @"RET_BATTLE_PASS_OPTIONAL_NOT_VALID")]
    RetBattlePassOptionalNotValid = 3812,

    [ProtoBuf.ProtoEnum(Name = @"RET_BATTLE_PASS_BUY_ALREADY")]
    RetBattlePassBuyAlready = 3813,

    [ProtoBuf.ProtoEnum(Name = @"RET_BATTLE_PASS_NEAR_END")]
    RetBattlePassNearEnd = 3814,

    [ProtoBuf.ProtoEnum(Name = @"RET_MUSIC_LOCKED")]
    RetMusicLocked = 3901,

    [ProtoBuf.ProtoEnum(Name = @"RET_MUSIC_NOT_EXIST")]
    RetMusicNotExist = 3902,

    [ProtoBuf.ProtoEnum(Name = @"RET_MUSIC_UNLOCK_FAILED")]
    RetMusicUnlockFailed = 3903,

    [ProtoBuf.ProtoEnum(Name = @"RET_PUNK_LORD_LACK_SUMMON_TIMES")]
    RetPunkLordLackSummonTimes = 4001,

    [ProtoBuf.ProtoEnum(Name = @"RET_PUNK_LORD_ATTACKING_MONSTER_LIMIT")]
    RetPunkLordAttackingMonsterLimit = 4002,

    [ProtoBuf.ProtoEnum(Name = @"RET_PUNK_LORD_MONSTER_NOT_EXIST")]
    RetPunkLordMonsterNotExist = 4003,

    [ProtoBuf.ProtoEnum(Name = @"RET_PUNK_LORD_MONSTER_ALREADY_SHARED")]
    RetPunkLordMonsterAlreadyShared = 4004,

    [ProtoBuf.ProtoEnum(Name = @"RET_PUNK_LORD_MONSTER_EXPIRED")]
    RetPunkLordMonsterExpired = 4005,

    [ProtoBuf.ProtoEnum(Name = @"RET_PUNK_LORD_SELF_MONSTER_ATTACK_LIMIT")]
    RetPunkLordSelfMonsterAttackLimit = 4006,

    [ProtoBuf.ProtoEnum(Name = @"RET_PUNK_LORD_LACK_SUPPORT_TIMES")]
    RetPunkLordLackSupportTimes = 4007,

    [ProtoBuf.ProtoEnum(Name = @"RET_PUNK_LORD_MONSTER_ALREADY_KILLED")]
    RetPunkLordMonsterAlreadyKilled = 4008,

    [ProtoBuf.ProtoEnum(Name = @"RET_PUNK_LORD_MONSTER_ATTACKER_LIMIT")]
    RetPunkLordMonsterAttackerLimit = 4009,

    [ProtoBuf.ProtoEnum(Name = @"RET_PUNK_LORD_WORLD_LEVLE_NOT_VALID")]
    RetPunkLordWorldLevleNotValid = 4010,

    [ProtoBuf.ProtoEnum(Name = @"RET_PUNK_LORD_REWARD_LEVLE_NOT_EXIST")]
    RetPunkLordRewardLevleNotExist = 4011,

    [ProtoBuf.ProtoEnum(Name = @"RET_PUNK_LORD_POINT_NOT_MEET")]
    RetPunkLordPointNotMeet = 4012,

    [ProtoBuf.ProtoEnum(Name = @"RET_PUNK_LORD_IN_ATTACKING")]
    RetPunkLordInAttacking = 4013,

    [ProtoBuf.ProtoEnum(Name = @"RET_PUNK_LORD_OPERATION_IN_CD")]
    RetPunkLordOperationInCd = 4014,

    [ProtoBuf.ProtoEnum(Name = @"RET_PUNK_LORD_REWARD_ALREADY_TAKEN")]
    RetPunkLordRewardAlreadyTaken = 4015,

    [ProtoBuf.ProtoEnum(Name = @"RET_PUNK_LORD_OVER_BONUS_REWARD_LIMIT")]
    RetPunkLordOverBonusRewardLimit = 4016,

    [ProtoBuf.ProtoEnum(Name = @"RET_PUNK_LORD_NOT_IN_SCHEDULE")]
    RetPunkLordNotInSchedule = 4017,

    [ProtoBuf.ProtoEnum(Name = @"RET_PUNK_LORD_MONSTER_NOT_ATTACKED")]
    RetPunkLordMonsterNotAttacked = 4018,

    [ProtoBuf.ProtoEnum(Name = @"RET_PUNK_LORD_MONSTER_NOT_KILLED")]
    RetPunkLordMonsterNotKilled = 4019,

    [ProtoBuf.ProtoEnum(Name = @"RET_PUNK_LORD_MONSTER_KILLED_SCORE_ALREADY_TAKE")]
    RetPunkLordMonsterKilledScoreAlreadyTake = 4020,

    [ProtoBuf.ProtoEnum(Name = @"RET_PUNK_LORD_REWARD_LEVLE_ALREADY_TAKE")]
    RetPunkLordRewardLevleAlreadyTake = 4021,

    [ProtoBuf.ProtoEnum(Name = @"RET_DAILY_ACTIVE_LEVEL_INVALID")]
    RetDailyActiveLevelInvalid = 4101,

    [ProtoBuf.ProtoEnum(Name = @"RET_DAILY_ACTIVE_LEVEL_REWARD_ALREADY_TAKEN")]
    RetDailyActiveLevelRewardAlreadyTaken = 4102,

    [ProtoBuf.ProtoEnum(Name = @"RET_DAILY_ACTIVE_LEVEL_AP_NOT_ENOUGH")]
    RetDailyActiveLevelApNotEnough = 4103,

    [ProtoBuf.ProtoEnum(Name = @"RET_DAILY_MEET_PAM")]
    RetDailyMeetPam = 4201,

    [ProtoBuf.ProtoEnum(Name = @"RET_REPLAY_ID_NOT_MATCH")]
    RetReplayIdNotMatch = 4251,

    [ProtoBuf.ProtoEnum(Name = @"RET_REPLAY_REQ_NOT_VALID")]
    RetReplayReqNotValid = 4252,

    [ProtoBuf.ProtoEnum(Name = @"RET_FIGHT_ACTIVITY_DIFFICULTY_LEVEL_NOT_PASSED")]
    RetFightActivityDifficultyLevelNotPassed = 4301,

    [ProtoBuf.ProtoEnum(Name = @"RET_FIGHT_ACTIVITY_DIFFICULTY_LEVEL_REWARD_ALREADY_TAKE")]
    RetFightActivityDifficultyLevelRewardAlreadyTake = 4302,

    [ProtoBuf.ProtoEnum(Name = @"RET_FIGHT_ACTIVITY_STAGE_NOT_OPEN")]
    RetFightActivityStageNotOpen = 4303,

    [ProtoBuf.ProtoEnum(Name = @"RET_TRAIN_VISITOR_VISITOR_NOT_EXIST")]
    RetTrainVisitorVisitorNotExist = 4351,

    [ProtoBuf.ProtoEnum(Name = @"RET_TRAIN_VISITOR_BEHAVIOR_NOT_EXIST")]
    RetTrainVisitorBehaviorNotExist = 4352,

    [ProtoBuf.ProtoEnum(Name = @"RET_TRAIN_VISITOR_BEHAVIOR_FINISHED")]
    RetTrainVisitorBehaviorFinished = 4353,

    [ProtoBuf.ProtoEnum(Name = @"RET_TRAIN_VISITOR_ALL_BEHAVIOR_REWARD_TAKEN")]
    RetTrainVisitorAllBehaviorRewardTaken = 4354,

    [ProtoBuf.ProtoEnum(Name = @"RET_TRAIN_VISITOR_GET_ON_MISSION_NOT_FINISH")]
    RetTrainVisitorGetOnMissionNotFinish = 4355,

    [ProtoBuf.ProtoEnum(Name = @"RET_TRAIN_VISITOR_NOT_GET_OFF")]
    RetTrainVisitorNotGetOff = 4356,

    [ProtoBuf.ProtoEnum(Name = @"RET_TEXT_JOIN_UNKNOW_IS_OVERRIDE")]
    RetTextJoinUnknowIsOverride = 4401,

    [ProtoBuf.ProtoEnum(Name = @"RET_TEXT_JOIN_ID_NOT_EXIST")]
    RetTextJoinIdNotExist = 4402,

    [ProtoBuf.ProtoEnum(Name = @"RET_TEXT_JOIN_CAN_NOT_OVERRIDE")]
    RetTextJoinCanNotOverride = 4403,

    [ProtoBuf.ProtoEnum(Name = @"RET_TEXT_JOIN_ITEM_ID_ERROR")]
    RetTextJoinItemIdError = 4404,

    [ProtoBuf.ProtoEnum(Name = @"RET_TEXT_JOIN_SENSITIVE_CHECK_ERROR")]
    RetTextJoinSensitiveCheckError = 4405,

    [ProtoBuf.ProtoEnum(Name = @"RET_TEXT_JOIN_MUST_OVERRIDE")]
    RetTextJoinMustOverride = 4406,

    [ProtoBuf.ProtoEnum(Name = @"RET_TEXT_JOIN_TEXT_EMPTY")]
    RetTextJoinTextEmpty = 4407,

    [ProtoBuf.ProtoEnum(Name = @"RET_TEXT_JOIN_TEXT_FORMAT_ERROR")]
    RetTextJoinTextFormatError = 4408,

    [ProtoBuf.ProtoEnum(Name = @"RET_TEXT_JOIN_TEXT_UTF8_ERROR")]
    RetTextJoinTextUtf8Error = 4409,

    [ProtoBuf.ProtoEnum(Name = @"RET_TEXT_JOIN_BATCH_REQ_ID_REPEAT")]
    RetTextJoinBatchReqIdRepeat = 4410,

    [ProtoBuf.ProtoEnum(Name = @"RET_TEXT_JOIN_TYPE_NOT_SUPPORT_BATCH_REQ")]
    RetTextJoinTypeNotSupportBatchReq = 4411,

    [ProtoBuf.ProtoEnum(Name = @"RET_TEXT_JOIN_AVATAR_ID_NOT_EXIST")]
    RetTextJoinAvatarIdNotExist = 4412,

    [ProtoBuf.ProtoEnum(Name = @"RET_TEXT_JOIN_UNKNOW_TYPE")]
    RetTextJoinUnknowType = 4413,

    [ProtoBuf.ProtoEnum(Name = @"RET_PAM_MISSION_MISSION_ID_ERROR")]
    RetPamMissionMissionIdError = 4451,

    [ProtoBuf.ProtoEnum(Name = @"RET_PAM_MISSION_MISSION_EXPIRE")]
    RetPamMissionMissionExpire = 4452,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHAT_TYPE_NOT_EXIST")]
    RetChatTypeNotExist = 4501,

    [ProtoBuf.ProtoEnum(Name = @"RET_MSG_TYPE_NOT_EXIST")]
    RetMsgTypeNotExist = 4502,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHAT_NO_TARGET_UID")]
    RetChatNoTargetUid = 4503,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHAT_MSG_EMPTY")]
    RetChatMsgEmpty = 4504,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHAT_MSG_EXCEED_LIMIT")]
    RetChatMsgExceedLimit = 4505,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHAT_MSG_SENSITIVE_CHECK_ERROR")]
    RetChatMsgSensitiveCheckError = 4506,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHAT_MSG_UTF8_ERROR")]
    RetChatMsgUtf8Error = 4507,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHAT_FORBID_SWITCH_OPEN")]
    RetChatForbidSwitchOpen = 4508,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHAT_FORBID")]
    RetChatForbid = 4509,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHAT_MSG_INCLUDE_SPECIAL_STR")]
    RetChatMsgIncludeSpecialStr = 4510,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHAT_MSG_EMOJI_NOT_EXIST")]
    RetChatMsgEmojiNotExist = 4511,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHAT_MSG_EMOJI_GENDER_NOT_MATCH")]
    RetChatMsgEmojiGenderNotMatch = 4512,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHAT_MSG_EMOJI_NOT_MARKED")]
    RetChatMsgEmojiNotMarked = 4513,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHAT_MSG_EMOJI_ALREADY_MARKED")]
    RetChatMsgEmojiAlreadyMarked = 4514,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHAT_MSG_EMOJI_MARKED_MAX_LIMIT")]
    RetChatMsgEmojiMarkedMaxLimit = 4515,

    [ProtoBuf.ProtoEnum(Name = @"RET_BOXING_CLUB_CHALLENGE_NOT_OPEN")]
    RetBoxingClubChallengeNotOpen = 4601,

    [ProtoBuf.ProtoEnum(Name = @"RET_MUSEUM_NOT_OPEN")]
    RetMuseumNotOpen = 4651,

    [ProtoBuf.ProtoEnum(Name = @"RET_MUSEUM_TURN_CNT_NOT_MATCH")]
    RetMuseumTurnCntNotMatch = 4652,

    [ProtoBuf.ProtoEnum(Name = @"RET_MUSEUM_PHASE_NOT_REACH")]
    RetMuseumPhaseNotReach = 4653,

    [ProtoBuf.ProtoEnum(Name = @"RET_MUSEUM_UNKNOW_STUFF")]
    RetMuseumUnknowStuff = 4654,

    [ProtoBuf.ProtoEnum(Name = @"RET_MUSEUM_UNKNOW_AREA")]
    RetMuseumUnknowArea = 4655,

    [ProtoBuf.ProtoEnum(Name = @"RET_MUSEUM_UNKNOW_POS")]
    RetMuseumUnknowPos = 4656,

    [ProtoBuf.ProtoEnum(Name = @"RET_MUSEUM_STUFF_ALREADY_IN_AREA")]
    RetMuseumStuffAlreadyInArea = 4657,

    [ProtoBuf.ProtoEnum(Name = @"RET_MUSEUM_STUFF_NOT_IN_AREA")]
    RetMuseumStuffNotInArea = 4658,

    [ProtoBuf.ProtoEnum(Name = @"RET_MUSEUM_GET_NPC_REPEAT")]
    RetMuseumGetNpcRepeat = 4659,

    [ProtoBuf.ProtoEnum(Name = @"RET_MUSEUM_GET_NPC_UNLOCK")]
    RetMuseumGetNpcUnlock = 4660,

    [ProtoBuf.ProtoEnum(Name = @"RET_MUSEUM_GET_NPC_NOT_ENOUGH")]
    RetMuseumGetNpcNotEnough = 4661,

    [ProtoBuf.ProtoEnum(Name = @"RET_MUSEUM_CHANGE_STUFF_AREA_ERROR")]
    RetMuseumChangeStuffAreaError = 4662,

    [ProtoBuf.ProtoEnum(Name = @"RET_MUSEUM_NOT_INIT")]
    RetMuseumNotInit = 4663,

    [ProtoBuf.ProtoEnum(Name = @"RET_MUSEUM_EVENT_ERROR")]
    RetMuseumEventError = 4664,

    [ProtoBuf.ProtoEnum(Name = @"RET_MUSEUM_UNKNOW_CHOOSE_EVENT_ID")]
    RetMuseumUnknowChooseEventId = 4665,

    [ProtoBuf.ProtoEnum(Name = @"RET_MUSEUM_EVENT_ORDER_NOT_MATCH")]
    RetMuseumEventOrderNotMatch = 4666,

    [ProtoBuf.ProtoEnum(Name = @"RET_MUSEUM_EVENT_PHASE_NOT_UNLOCK")]
    RetMuseumEventPhaseNotUnlock = 4667,

    [ProtoBuf.ProtoEnum(Name = @"RET_MUSEUM_EVENT_MISSION_NOT_FOUND")]
    RetMuseumEventMissionNotFound = 4668,

    [ProtoBuf.ProtoEnum(Name = @"RET_MUSEUM_AREA_LEVEL_UP_ALREADY")]
    RetMuseumAreaLevelUpAlready = 4669,

    [ProtoBuf.ProtoEnum(Name = @"RET_MUSEUM_STUFF_ALREADY_USED")]
    RetMuseumStuffAlreadyUsed = 4670,

    [ProtoBuf.ProtoEnum(Name = @"RET_MUSEUM_EVENT_ROUND_NOT_UNLOCK")]
    RetMuseumEventRoundNotUnlock = 4671,

    [ProtoBuf.ProtoEnum(Name = @"RET_MUSEUM_STUFF_IN_AREA")]
    RetMuseumStuffInArea = 4672,

    [ProtoBuf.ProtoEnum(Name = @"RET_MUSEUM_STUFF_DISPATCH")]
    RetMuseumStuffDispatch = 4673,

    [ProtoBuf.ProtoEnum(Name = @"RET_MUSEUM_IS_END")]
    RetMuseumIsEnd = 4674,

    [ProtoBuf.ProtoEnum(Name = @"RET_MUSEUM_STUFF_LEAVING")]
    RetMuseumStuffLeaving = 4675,

    [ProtoBuf.ProtoEnum(Name = @"RET_MUSEUM_EVENT_MISSION_NOT_FINISH")]
    RetMuseumEventMissionNotFinish = 4678,

    [ProtoBuf.ProtoEnum(Name = @"RET_MUSEUM_COLLECT_REWARD_NOT_EXIST")]
    RetMuseumCollectRewardNotExist = 4679,

    [ProtoBuf.ProtoEnum(Name = @"RET_MUSEUM_COLLECT_REWARD_ALREADY_TAKEN")]
    RetMuseumCollectRewardAlreadyTaken = 4680,

    [ProtoBuf.ProtoEnum(Name = @"RET_MUSEUM_ACCEPT_MISSION_MAX_LIMIT")]
    RetMuseumAcceptMissionMaxLimit = 4681,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROGUE_CHALLENGE_NOT_OPEN")]
    RetRogueChallengeNotOpen = 4701,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROGUE_CHALLENGE_ASSIS_REFRESH_LIMIT")]
    RetRogueChallengeAssisRefreshLimit = 4702,

    [ProtoBuf.ProtoEnum(Name = @"RET_ALLEY_NOT_INIT")]
    RetAlleyNotInit = 4721,

    [ProtoBuf.ProtoEnum(Name = @"RET_ALLEY_NOT_OPEN")]
    RetAlleyNotOpen = 4722,

    [ProtoBuf.ProtoEnum(Name = @"RET_ALLEY_MAP_NOT_EXIST")]
    RetAlleyMapNotExist = 4724,

    [ProtoBuf.ProtoEnum(Name = @"RET_ALLEY_EMPTY_POS_LIST")]
    RetAlleyEmptyPosList = 4725,

    [ProtoBuf.ProtoEnum(Name = @"RET_ALLEY_LINE_POS_INVALID")]
    RetAlleyLinePosInvalid = 4726,

    [ProtoBuf.ProtoEnum(Name = @"RET_ALLEY_SHOP_NOT_UNLOCK")]
    RetAlleyShopNotUnlock = 4727,

    [ProtoBuf.ProtoEnum(Name = @"RET_ALLEY_DEPOT_FULL")]
    RetAlleyDepotFull = 4728,

    [ProtoBuf.ProtoEnum(Name = @"RET_ALLEY_SHOP_NOT_INCLUDE")]
    RetAlleyShopNotInclude = 4729,

    [ProtoBuf.ProtoEnum(Name = @"RET_ALLEY_EVENT_NOT_UNLOCK")]
    RetAlleyEventNotUnlock = 4730,

    [ProtoBuf.ProtoEnum(Name = @"RET_ALLEY_EVENT_NOT_REFRESH")]
    RetAlleyEventNotRefresh = 4731,

    [ProtoBuf.ProtoEnum(Name = @"RET_ALLEY_EVENT_STATE_DOING")]
    RetAlleyEventStateDoing = 4732,

    [ProtoBuf.ProtoEnum(Name = @"RET_ALLEY_EVENT_STATE_FINISH")]
    RetAlleyEventStateFinish = 4733,

    [ProtoBuf.ProtoEnum(Name = @"RET_ALLEY_EVENT_ERROR")]
    RetAlleyEventError = 4734,

    [ProtoBuf.ProtoEnum(Name = @"RET_ALLEY_REWARD_LEVEL_ERROR")]
    RetAlleyRewardLevelError = 4735,

    [ProtoBuf.ProtoEnum(Name = @"RET_ALLEY_REWARD_PRESTIGE_NOT_ENOUGH")]
    RetAlleyRewardPrestigeNotEnough = 4736,

    [ProtoBuf.ProtoEnum(Name = @"RET_ALLEY_SHIP_EMPTY")]
    RetAlleyShipEmpty = 4737,

    [ProtoBuf.ProtoEnum(Name = @"RET_ALLEY_SHIP_ID_DISMATCH")]
    RetAlleyShipIdDismatch = 4738,

    [ProtoBuf.ProtoEnum(Name = @"RET_ALLEY_SHIP_NOT_EXIST")]
    RetAlleyShipNotExist = 4739,

    [ProtoBuf.ProtoEnum(Name = @"RET_ALLEY_SHIP_NOT_UNLOCK")]
    RetAlleyShipNotUnlock = 4740,

    [ProtoBuf.ProtoEnum(Name = @"RET_ALLEY_GOODS_NOT_EXIST")]
    RetAlleyGoodsNotExist = 4741,

    [ProtoBuf.ProtoEnum(Name = @"RET_ALLEY_GOODS_NOT_UNLOCK")]
    RetAlleyGoodsNotUnlock = 4742,

    [ProtoBuf.ProtoEnum(Name = @"RET_ALLEY_PROFIT_NOT_POSITIVE")]
    RetAlleyProfitNotPositive = 4743,

    [ProtoBuf.ProtoEnum(Name = @"RET_ALLEY_SPECIAL_ORDER_DISMATCH")]
    RetAlleySpecialOrderDismatch = 4744,

    [ProtoBuf.ProtoEnum(Name = @"RET_ALLEY_ORDER_GOODS_OVER_LIMIT")]
    RetAlleyOrderGoodsOverLimit = 4745,

    [ProtoBuf.ProtoEnum(Name = @"RET_ALLEY_SPECIAL_ORDER_CONDITION_NOT_MEET")]
    RetAlleySpecialOrderConditionNotMeet = 4746,

    [ProtoBuf.ProtoEnum(Name = @"RET_ALLEY_DEPOT_SIZE_OVER_LIMIT")]
    RetAlleyDepotSizeOverLimit = 4747,

    [ProtoBuf.ProtoEnum(Name = @"RET_ALLEY_GOODS_NOT_ENOUGH")]
    RetAlleyGoodsNotEnough = 4748,

    [ProtoBuf.ProtoEnum(Name = @"RET_ALLEY_ORDER_INDEX_INVALID")]
    RetAlleyOrderIndexInvalid = 4749,

    [ProtoBuf.ProtoEnum(Name = @"RET_ALLEY_REWARD_ALREADY_TAKE")]
    RetAlleyRewardAlreadyTake = 4750,

    [ProtoBuf.ProtoEnum(Name = @"RET_ALLEY_REWARD_NOT_EXIST")]
    RetAlleyRewardNotExist = 4751,

    [ProtoBuf.ProtoEnum(Name = @"RET_ALLEY_MAIN_MISSION_NOT_DOING")]
    RetAlleyMainMissionNotDoing = 4752,

    [ProtoBuf.ProtoEnum(Name = @"RET_ALLEY_CRITICAL_EVENT_NOT_FINISH")]
    RetAlleyCriticalEventNotFinish = 4753,

    [ProtoBuf.ProtoEnum(Name = @"RET_ALLEY_SHOP_GOODS_NOT_VALID")]
    RetAlleyShopGoodsNotValid = 4754,

    [ProtoBuf.ProtoEnum(Name = @"RET_ALLEY_SLASH_NOT_OPEN")]
    RetAlleySlashNotOpen = 4755,

    [ProtoBuf.ProtoEnum(Name = @"RET_ALLEY_PLACING_ANCHOR_INVALID")]
    RetAlleyPlacingAnchorInvalid = 4756,

    [ProtoBuf.ProtoEnum(Name = @"RET_ALLEY_PLACING_GOODS_INDEX_INVALID")]
    RetAlleyPlacingGoodsIndexInvalid = 4757,

    [ProtoBuf.ProtoEnum(Name = @"RET_ALLEY_SAVE_MAP_TOO_QUICK")]
    RetAlleySaveMapTooQuick = 4758,

    [ProtoBuf.ProtoEnum(Name = @"RET_ALLEY_MAP_NOT_LINK")]
    RetAlleyMapNotLink = 4759,

    [ProtoBuf.ProtoEnum(Name = @"RET_ALLEY_FUNDS_NOT_LOWER_BASE")]
    RetAlleyFundsNotLowerBase = 4760,

    [ProtoBuf.ProtoEnum(Name = @"RET_ALLEY_EVENT_NOT_FINISH")]
    RetAlleyEventNotFinish = 4761,

    [ProtoBuf.ProtoEnum(Name = @"RET_ALLEY_NORMAL_ORDER_NOT_MEET")]
    RetAlleyNormalOrderNotMeet = 4762,

    [ProtoBuf.ProtoEnum(Name = @"RET_PLAYER_RETURN_NOT_OPEN")]
    RetPlayerReturnNotOpen = 4801,

    [ProtoBuf.ProtoEnum(Name = @"RET_PLAYER_RETURN_IS_SIGNED")]
    RetPlayerReturnIsSigned = 4802,

    [ProtoBuf.ProtoEnum(Name = @"RET_PLAYER_RETURN_POINT_NOT_ENOUGH")]
    RetPlayerReturnPointNotEnough = 4803,

    [ProtoBuf.ProtoEnum(Name = @"RET_PLAYER_RETURN_CONDITION_INVALID")]
    RetPlayerReturnConditionInvalid = 4804,

    [ProtoBuf.ProtoEnum(Name = @"RET_PLAYER_RETURN_HAS_SIGNED")]
    RetPlayerReturnHasSigned = 4805,

    [ProtoBuf.ProtoEnum(Name = @"RET_PLAYER_RETURN_REWARD_TAKEN")]
    RetPlayerReturnRewardTaken = 4806,

    [ProtoBuf.ProtoEnum(Name = @"RET_AETHER_DIVIDE_NO_LINEUP")]
    RetAetherDivideNoLineup = 4851,

    [ProtoBuf.ProtoEnum(Name = @"RET_AETHER_DIVIDE_LINEUP_INVALID")]
    RetAetherDivideLineupInvalid = 4852,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHAT_BUBBLE_ID_ERROR")]
    RetChatBubbleIdError = 4901,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHAT_BUBBLE_ID_NOT_UNLOCK")]
    RetChatBubbleIdNotUnlock = 4902,

    [ProtoBuf.ProtoEnum(Name = @"RET_PHONE_THEME_ID_ERROR")]
    RetPhoneThemeIdError = 4903,

    [ProtoBuf.ProtoEnum(Name = @"RET_PHONE_THEME_ID_NOT_UNLOCK")]
    RetPhoneThemeIdNotUnlock = 4904,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHAT_BUBBLE_SELECT_IS_CURRENT")]
    RetChatBubbleSelectIsCurrent = 4905,

    [ProtoBuf.ProtoEnum(Name = @"RET_PHONE_THEME_SELECT_IS_CURRENT")]
    RetPhoneThemeSelectIsCurrent = 4906,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHESS_ROGUE_CONFIG_NOT_FOUND")]
    RetChessRogueConfigNotFound = 4951,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHESS_ROGUE_CONFIG_INVALID")]
    RetChessRogueConfigInvalid = 4952,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHESS_ROGUE_NO_VALID_ROOM")]
    RetChessRogueNoValidRoom = 4963,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHESS_ROGUE_NO_CELL_INFO")]
    RetChessRogueNoCellInfo = 4964,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHESS_ROGUE_CELL_NOT_FINISH")]
    RetChessRogueCellNotFinish = 4965,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHESS_ROGUE_CELL_IS_LOCKED")]
    RetChessRogueCellIsLocked = 4966,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHESS_ROGUE_SCHEDULE_NOT_MATCH")]
    RetChessRogueScheduleNotMatch = 4967,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHESS_ROGUE_STATUS_FAIL")]
    RetChessRogueStatusFail = 4968,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHESS_ROGUE_AREA_NOT_EXIST")]
    RetChessRogueAreaNotExist = 4969,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHESS_ROGUE_LINEUP_FAIL")]
    RetChessRogueLineupFail = 4970,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHESS_ROGUE_AEON_FAIL")]
    RetChessRogueAeonFail = 4980,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHESS_ROGUE_ENTER_CELL_FAIL")]
    RetChessRogueEnterCellFail = 4981,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHESS_ROGUE_ROLL_DICE_FAIL")]
    RetChessRogueRollDiceFail = 4982,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHESS_ROGUE_DICE_STATUS_FAIL")]
    RetChessRogueDiceStatusFail = 4983,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHESS_ROGUE_DICE_CNT_NOT_FULL")]
    RetChessRogueDiceCntNotFull = 4984,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHESS_ROGUE_UNLOCK")]
    RetChessRogueUnlock = 4985,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHESS_ROGUE_PICK_AVATAR_FAIL")]
    RetChessRoguePickAvatarFail = 4986,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHESS_ROGUE_AVATAR_INVALID")]
    RetChessRogueAvatarInvalid = 4987,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHESS_ROGUE_CELL_CAN_NOT_SELECT")]
    RetChessRogueCellCanNotSelect = 4988,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHESS_ROGUE_DICE_CONFIRMED")]
    RetChessRogueDiceConfirmed = 4989,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHESS_ROGUE_NOUS_DICE_NOT_MATCH")]
    RetChessRogueNousDiceNotMatch = 4990,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHESS_ROGUE_NOUS_DICE_RARITY_FAIL")]
    RetChessRogueNousDiceRarityFail = 4991,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHESS_ROGUE_NOUS_DICE_SURFACE_DUPLICATE")]
    RetChessRogueNousDiceSurfaceDuplicate = 4992,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHESS_ROGUE_NOT_IN_ROGUE")]
    RetChessRogueNotInRogue = 4993,

    [ProtoBuf.ProtoEnum(Name = @"RET_CHESS_ROGUE_NOUS_DICE_BRANCH_LIMIT")]
    RetChessRogueNousDiceBranchLimit = 4994,

    [ProtoBuf.ProtoEnum(Name = @"RET_HELIOBUS_NOT_OPEN")]
    RetHeliobusNotOpen = 5101,

    [ProtoBuf.ProtoEnum(Name = @"RET_HELIOBUS_SNS_POST_NOT_UNLOCK")]
    RetHeliobusSnsPostNotUnlock = 5102,

    [ProtoBuf.ProtoEnum(Name = @"RET_HELIOBUS_SNS_ALREADY_READ")]
    RetHeliobusSnsAlreadyRead = 5103,

    [ProtoBuf.ProtoEnum(Name = @"RET_HELIOBUS_SNS_ALREADY_LIKED")]
    RetHeliobusSnsAlreadyLiked = 5104,

    [ProtoBuf.ProtoEnum(Name = @"RET_HELIOBUS_SNS_ALREADY_COMMENTED")]
    RetHeliobusSnsAlreadyCommented = 5105,

    [ProtoBuf.ProtoEnum(Name = @"RET_HELIOBUS_SNS_IN_MISSION")]
    RetHeliobusSnsInMission = 5106,

    [ProtoBuf.ProtoEnum(Name = @"RET_HELIOBUS_SNS_ALREADY_POSTED")]
    RetHeliobusSnsAlreadyPosted = 5107,

    [ProtoBuf.ProtoEnum(Name = @"RET_HELIOBUS_SNS_NOT_DOING_MISSION")]
    RetHeliobusSnsNotDoingMission = 5108,

    [ProtoBuf.ProtoEnum(Name = @"RET_HELIOBUS_REWARD_LEVEL_MAX")]
    RetHeliobusRewardLevelMax = 5109,

    [ProtoBuf.ProtoEnum(Name = @"RET_HELIOBUS_INCOME_NOT_ENOUGH")]
    RetHeliobusIncomeNotEnough = 5110,

    [ProtoBuf.ProtoEnum(Name = @"RET_HELIOBUS_SNS_COMMENT_NOT_UNLOCK")]
    RetHeliobusSnsCommentNotUnlock = 5111,

    [ProtoBuf.ProtoEnum(Name = @"RET_HELIOBUS_CHALLENGE_NOT_UNLOCK")]
    RetHeliobusChallengeNotUnlock = 5112,

    [ProtoBuf.ProtoEnum(Name = @"RET_HELIOBUS_CHALLENGE_ID_ERROR")]
    RetHeliobusChallengeIdError = 5113,

    [ProtoBuf.ProtoEnum(Name = @"RET_HELIOBUS_SKILL_NOT_UNLOCK")]
    RetHeliobusSkillNotUnlock = 5114,

    [ProtoBuf.ProtoEnum(Name = @"RET_HELIOBUS_ACCEPT_POST_MISSION_FAIL")]
    RetHeliobusAcceptPostMissionFail = 5115,

    [ProtoBuf.ProtoEnum(Name = @"RET_HELIOBUS_SKILL_NOT_SELECTED")]
    RetHeliobusSkillNotSelected = 5116,

    [ProtoBuf.ProtoEnum(Name = @"RET_HELIOBUS_PLANE_TYPE_INVALID")]
    RetHeliobusPlaneTypeInvalid = 5117,

    [ProtoBuf.ProtoEnum(Name = @"RET_REDDOT_PARAM_INVALID")]
    RetReddotParamInvalid = 5151,

    [ProtoBuf.ProtoEnum(Name = @"RET_REDDOT_ACTIVITY_NOT_OPEN")]
    RetReddotActivityNotOpen = 5152,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROGUE_ENDLESS_ACTIVITY_CONFIG_ERROR")]
    RetRogueEndlessActivityConfigError = 5201,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROGUE_ENDLESS_ACTIVITY_NOT_OPEN")]
    RetRogueEndlessActivityNotOpen = 5202,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROGUE_ENDLESS_ACTIVITY_OVER_BONUS_REWARD_LIMIT")]
    RetRogueEndlessActivityOverBonusRewardLimit = 5203,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROGUE_ENDLESS_ACTIVITY_SCORE_NOT_MEET")]
    RetRogueEndlessActivityScoreNotMeet = 5204,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROGUE_ENDLESS_ACTIVITY_REWARD_LEVLE_ALREADY_TAKE")]
    RetRogueEndlessActivityRewardLevleAlreadyTake = 5205,

    [ProtoBuf.ProtoEnum(Name = @"RET_HEART_DIAL_SCRIPT_NOT_FOUND")]
    RetHeartDialScriptNotFound = 5251,

    [ProtoBuf.ProtoEnum(Name = @"RET_HEART_DIAL_SCRIPT_EMOTION_THE_SAME")]
    RetHeartDialScriptEmotionTheSame = 5252,

    [ProtoBuf.ProtoEnum(Name = @"RET_HEART_DIAL_SCRIPT_STEP_NOT_NORMAL")]
    RetHeartDialScriptStepNotNormal = 5253,

    [ProtoBuf.ProtoEnum(Name = @"RET_HEART_DIAL_SCRIPT_CONDITION_NOT_MATCH")]
    RetHeartDialScriptConditionNotMatch = 5254,

    [ProtoBuf.ProtoEnum(Name = @"RET_HEART_DIAL_SCRIPT_SUBMIT_ITEM_NUM_NOT_MATCH")]
    RetHeartDialScriptSubmitItemNumNotMatch = 5255,

    [ProtoBuf.ProtoEnum(Name = @"RET_HEART_DIAL_SCRIPT_SUBMIT_ITEM_ID_NOT_MATCH")]
    RetHeartDialScriptSubmitItemIdNotMatch = 5256,

    [ProtoBuf.ProtoEnum(Name = @"RET_HEART_DIAL_DIALOGUE_NOT_FOUND")]
    RetHeartDialDialogueNotFound = 5257,

    [ProtoBuf.ProtoEnum(Name = @"RET_HEART_DIAL_DIALOGUE_ALREADY_PERFORMED")]
    RetHeartDialDialogueAlreadyPerformed = 5258,

    [ProtoBuf.ProtoEnum(Name = @"RET_HEART_DIAL_NPC_NOT_FOUND")]
    RetHeartDialNpcNotFound = 5259,

    [ProtoBuf.ProtoEnum(Name = @"RET_HEART_DIAL_TRACE_CONFIG_NOT_FOUND")]
    RetHeartDialTraceConfigNotFound = 5260,

    [ProtoBuf.ProtoEnum(Name = @"RET_HEART_DIAL_FLOOR_TRACE_EXIST")]
    RetHeartDialFloorTraceExist = 5261,

    [ProtoBuf.ProtoEnum(Name = @"RET_HEART_DIAL_TRACE_FLOOR_NOT_MATCH")]
    RetHeartDialTraceFloorNotMatch = 5262,

    [ProtoBuf.ProtoEnum(Name = @"RET_TRAVEL_BROCHURE_CONFIG_ERROR")]
    RetTravelBrochureConfigError = 5301,

    [ProtoBuf.ProtoEnum(Name = @"RET_TRAVEL_BROCHURE_PARAM_INVALID")]
    RetTravelBrochureParamInvalid = 5302,

    [ProtoBuf.ProtoEnum(Name = @"RET_TRAVEL_BROCHURE_LOCKED")]
    RetTravelBrochureLocked = 5303,

    [ProtoBuf.ProtoEnum(Name = @"RET_TRAVEL_BROCHURE_CANNOT_OPERATE")]
    RetTravelBrochureCannotOperate = 5304,

    [ProtoBuf.ProtoEnum(Name = @"RET_TRAVEL_BROCHURE_WORLD_ID_NOT_MATCH")]
    RetTravelBrochureWorldIdNotMatch = 5305,

    [ProtoBuf.ProtoEnum(Name = @"RET_TRAVEL_BROCHURE_HAS_NO_WORLD_BOOK")]
    RetTravelBrochureHasNoWorldBook = 5306,

    [ProtoBuf.ProtoEnum(Name = @"RET_TRAVEL_BROCHURE_PAGE_FULL")]
    RetTravelBrochurePageFull = 5307,

    [ProtoBuf.ProtoEnum(Name = @"RET_MAP_ROTATION_NOT_IN_REGION")]
    RetMapRotationNotInRegion = 5351,

    [ProtoBuf.ProtoEnum(Name = @"RET_MAP_ROTATION_ROTATER_ALREADY_DEPLOYED")]
    RetMapRotationRotaterAlreadyDeployed = 5352,

    [ProtoBuf.ProtoEnum(Name = @"RET_MAP_ROTATION_ENERGY_NOT_ENOUGH")]
    RetMapRotationEnergyNotEnough = 5353,

    [ProtoBuf.ProtoEnum(Name = @"RET_MAP_ROTATION_ENTITY_NOT_ON_CUR_POSE")]
    RetMapRotationEntityNotOnCurPose = 5354,

    [ProtoBuf.ProtoEnum(Name = @"RET_MAP_ROTATION_ROTATER_NOT_DEPLOYED")]
    RetMapRotationRotaterNotDeployed = 5355,

    [ProtoBuf.ProtoEnum(Name = @"RET_MAP_ROTATION_POSE_ROTATER_MISMATCH")]
    RetMapRotationPoseRotaterMismatch = 5356,

    [ProtoBuf.ProtoEnum(Name = @"RET_MAP_ROTATION_ROTATER_NOT_REMOVABLE")]
    RetMapRotationRotaterNotRemovable = 5357,

    [ProtoBuf.ProtoEnum(Name = @"RET_SPACE_ZOO_ACTIVITY_CAT_NOT_FOUND")]
    RetSpaceZooActivityCatNotFound = 5401,

    [ProtoBuf.ProtoEnum(Name = @"RET_SPACE_ZOO_ACTIVITY_CAT_PARAM_INVALID")]
    RetSpaceZooActivityCatParamInvalid = 5402,

    [ProtoBuf.ProtoEnum(Name = @"RET_SPACE_ZOO_ACTIVITY_CAT_ITEM_NOT_ENOUGH")]
    RetSpaceZooActivityCatItemNotEnough = 5403,

    [ProtoBuf.ProtoEnum(Name = @"RET_SPACE_ZOO_ACTIVITY_CAT_BAG_FULL")]
    RetSpaceZooActivityCatBagFull = 5404,

    [ProtoBuf.ProtoEnum(Name = @"RET_SPACE_ZOO_ACTIVITY_CAT_NOT_TO_MUTATE")]
    RetSpaceZooActivityCatNotToMutate = 5405,

    [ProtoBuf.ProtoEnum(Name = @"RET_SPACE_ZOO_ACTIVITY_CAT_STATE_ERROR")]
    RetSpaceZooActivityCatStateError = 5406,

    [ProtoBuf.ProtoEnum(Name = @"RET_SPACE_ZOO_ACTIVITY_CAT_CATTERY_LOCKED")]
    RetSpaceZooActivityCatCatteryLocked = 5407,

    [ProtoBuf.ProtoEnum(Name = @"RET_SPACE_ZOO_ACTIVITY_CAT_OUT_NOW")]
    RetSpaceZooActivityCatOutNow = 5408,

    [ProtoBuf.ProtoEnum(Name = @"RET_SPACE_ZOO_ACTIVITY_CAT_CONFIG_NOT_FOUND")]
    RetSpaceZooActivityCatConfigNotFound = 5409,

    [ProtoBuf.ProtoEnum(Name = @"RET_SPACE_ZOO_ACTIVITY_CAT_FEATURE_NOT_FOUND")]
    RetSpaceZooActivityCatFeatureNotFound = 5410,

    [ProtoBuf.ProtoEnum(Name = @"RET_SPACE_ZOO_ACTIVITY_CAT_ADD_CAT_ERROR")]
    RetSpaceZooActivityCatAddCatError = 5411,

    [ProtoBuf.ProtoEnum(Name = @"RET_SPACE_ZOO_ACTIVITY_CAT_MONEY_NOT_ENOUGH")]
    RetSpaceZooActivityCatMoneyNotEnough = 5412,

    [ProtoBuf.ProtoEnum(Name = @"RET_SPACE_ZOO_ACTIVITY_CAT_COND_NOT_MATCH")]
    RetSpaceZooActivityCatCondNotMatch = 5413,

    [ProtoBuf.ProtoEnum(Name = @"RET_STRONG_CHALLENGE_ACTIVITY_STAGE_CFG_MISS")]
    RetStrongChallengeActivityStageCfgMiss = 5501,

    [ProtoBuf.ProtoEnum(Name = @"RET_STRONG_CHALLENGE_ACTIVITY_STAGE_NOT_OPEN")]
    RetStrongChallengeActivityStageNotOpen = 5502,

    [ProtoBuf.ProtoEnum(Name = @"RET_STRONG_CHALLENGE_ACTIVITY_BUFF_ERROR")]
    RetStrongChallengeActivityBuffError = 5503,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROLL_SHOP_NOT_FOUND")]
    RetRollShopNotFound = 5551,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROLL_SHOP_GROUP_EMPTY")]
    RetRollShopGroupEmpty = 5552,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROLL_SHOP_EMPTY")]
    RetRollShopEmpty = 5553,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROLL_SHOP_GACHA_REQ_DUPLICATED")]
    RetRollShopGachaReqDuplicated = 5554,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROLL_SHOP_RANDOM_ERROR")]
    RetRollShopRandomError = 5555,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROLL_SHOP_GROUP_TYPE_NOT_FOUND")]
    RetRollShopGroupTypeNotFound = 5556,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROLL_SHOP_HAS_STORED_REWARD_ALREADY")]
    RetRollShopHasStoredRewardAlready = 5557,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROLL_SHOP_NO_STORED_REWARD")]
    RetRollShopNoStoredReward = 5558,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROLL_SHOP_NOT_IN_VALID_SCENE")]
    RetRollShopNotInValidScene = 5559,

    [ProtoBuf.ProtoEnum(Name = @"RET_ROLL_SHOP_INVALID_ROLL_SHOP_TYPE")]
    RetRollShopInvalidRollShopType = 5560,

    [ProtoBuf.ProtoEnum(Name = @"RET_ACTIVITY_RAID_COLLECTION_PREV_NOT_FINISH")]
    RetActivityRaidCollectionPrevNotFinish = 5601,

    [ProtoBuf.ProtoEnum(Name = @"RET_OFFERING_NOT_UNLOCK")]
    RetOfferingNotUnlock = 5651,

    [ProtoBuf.ProtoEnum(Name = @"RET_OFFERING_LEVEL_NOT_UNLOCK")]
    RetOfferingLevelNotUnlock = 5652,

    [ProtoBuf.ProtoEnum(Name = @"RET_OFFERING_REACH_MAX_LEVEL")]
    RetOfferingReachMaxLevel = 5653,

    [ProtoBuf.ProtoEnum(Name = @"RET_OFFERING_ITEM_NOT_ENOUGH")]
    RetOfferingItemNotEnough = 5654,

    [ProtoBuf.ProtoEnum(Name = @"RET_OFFERING_LONGTAIL_NOT_OPEN")]
    RetOfferingLongtailNotOpen = 5655,

    [ProtoBuf.ProtoEnum(Name = @"RET_OFFERING_REWARD_CONDITION")]
    RetOfferingRewardCondition = 5656,

    [ProtoBuf.ProtoEnum(Name = @"RET_DRINK_MAKER_CHAT_INVALID")]
    RetDrinkMakerChatInvalid = 5701,

    [ProtoBuf.ProtoEnum(Name = @"RET_DRINK_MAKER_PARAM_INVALID")]
    RetDrinkMakerParamInvalid = 5702,

    [ProtoBuf.ProtoEnum(Name = @"RET_DRINK_MAKER_PARAM_NOT_UNLOCK")]
    RetDrinkMakerParamNotUnlock = 5703,

    [ProtoBuf.ProtoEnum(Name = @"RET_DRINK_MAKER_CONFIG_NOT_FOUND")]
    RetDrinkMakerConfigNotFound = 5704,

    [ProtoBuf.ProtoEnum(Name = @"RET_DRINK_MAKER_NOT_LAST_CHAT")]
    RetDrinkMakerNotLastChat = 5705,

    [ProtoBuf.ProtoEnum(Name = @"RET_DRINK_MAKER_DAY_AND_FREE_PHASE_NOT_OPEN")]
    RetDrinkMakerDayAndFreePhaseNotOpen = 5706,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONOPOLY_NOT_OPEN")]
    RetMonopolyNotOpen = 5751,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONOPOLY_CONFIG_ERROR")]
    RetMonopolyConfigError = 5752,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONOPOLY_DICE_NOT_ENOUGH")]
    RetMonopolyDiceNotEnough = 5753,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONOPOLY_CUR_CELL_NOT_FINISH")]
    RetMonopolyCurCellNotFinish = 5754,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONOPOLY_COIN_NOT_ENOUGH")]
    RetMonopolyCoinNotEnough = 5755,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONOPOLY_CELL_WAIT_PENDING")]
    RetMonopolyCellWaitPending = 5756,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONOPOLY_CELL_STATE_ERROR")]
    RetMonopolyCellStateError = 5757,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONOPOLY_CELL_CONTENT_ERROR")]
    RetMonopolyCellContentError = 5758,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONOPOLY_ITEM_NOT_ENOUGH")]
    RetMonopolyItemNotEnough = 5759,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONOPOLY_CELL_CONTENT_CANNOT_GIVEUP")]
    RetMonopolyCellContentCannotGiveup = 5760,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONOPOLY_ASSET_LEVEL_INVALID")]
    RetMonopolyAssetLevelInvalid = 5761,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONOPOLY_TURN_NOT_FINISH")]
    RetMonopolyTurnNotFinish = 5762,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONOPOLY_GUIDE_NOT_FINISH")]
    RetMonopolyGuideNotFinish = 5763,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONOPOLY_RAFFLE_REWARD_REISSUED")]
    RetMonopolyRaffleRewardReissued = 5764,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONOPOLY_NO_GAME_ACTIVE")]
    RetMonopolyNoGameActive = 5771,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONOPOLY_GAME_RATIO_NOT_INCREASABLE")]
    RetMonopolyGameRatioNotIncreasable = 5772,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONOPOLY_GAME_RATIO_MAX")]
    RetMonopolyGameRatioMax = 5773,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONOPOLY_GAME_TARGET_RATIO_INVALID")]
    RetMonopolyGameTargetRatioInvalid = 5774,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONOPOLY_GAME_BINGO_FLIP_POS_INVALID")]
    RetMonopolyGameBingoFlipPosInvalid = 5775,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONOPOLY_GAME_GUESS_ALREADY_CHOOSE")]
    RetMonopolyGameGuessAlreadyChoose = 5776,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONOPOLY_GAME_GUESS_CHOOSE_INVALID")]
    RetMonopolyGameGuessChooseInvalid = 5777,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONOPOLY_GAME_GUESS_INFORMATION_ALREADY_BOUGHT")]
    RetMonopolyGameGuessInformationAlreadyBought = 5778,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONOPOLY_GAME_RAISE_RATIO_NOT_UNLOCK")]
    RetMonopolyGameRaiseRatioNotUnlock = 5779,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONOPOLY_FRIEND_NOT_SYNCED")]
    RetMonopolyFriendNotSynced = 5785,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONOPOLY_GET_FRIEND_RANKING_LIST_IN_CD")]
    RetMonopolyGetFriendRankingListInCd = 5786,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONOPOLY_LIKE_TARGET_NOT_FRIEND")]
    RetMonopolyLikeTargetNotFriend = 5787,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONOPOLY_DAILY_ALREADY_LIKED")]
    RetMonopolyDailyAlreadyLiked = 5788,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONOPOLY_SOCIAL_EVENT_STATUS_NOT_MATCH")]
    RetMonopolySocialEventStatusNotMatch = 5789,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONOPOLY_SOCIAL_EVENT_SERVER_CACHE_NOT_EXIST")]
    RetMonopolySocialEventServerCacheNotExist = 5790,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONOPOLY_ACTIVITY_ID_NOT_MATCH")]
    RetMonopolyActivityIdNotMatch = 5791,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONOPOLY_RAFFLE_POOL_NOT_EXIST")]
    RetMonopolyRafflePoolNotExist = 5792,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONOPOLY_RAFFLE_POOL_TIME_NOT_MATCH")]
    RetMonopolyRafflePoolTimeNotMatch = 5793,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONOPOLY_RAFFLE_POOL_PHASE_NOT_MEET")]
    RetMonopolyRafflePoolPhaseNotMeet = 5794,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONOPOLY_RAFFLE_POOL_SHOW_TIME_NOT_MEET")]
    RetMonopolyRafflePoolShowTimeNotMeet = 5795,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONOPOLY_RAFFLE_TICKET_NOT_FOUND")]
    RetMonopolyRaffleTicketNotFound = 5796,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONOPOLY_RAFFLE_TICKET_TIME_NOT_MEET")]
    RetMonopolyRaffleTicketTimeNotMeet = 5797,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONOPOLY_RAFFLE_TICKET_REWARD_ALREADY_TAKEN")]
    RetMonopolyRaffleTicketRewardAlreadyTaken = 5798,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONOPOLY_RAFFLE_POOL_NOT_IN_RAFFLE_TIME")]
    RetMonopolyRafflePoolNotInRaffleTime = 5799,

    [ProtoBuf.ProtoEnum(Name = @"RET_MONOPOLY_MBTI_REPORT_REWARD_ALREADY_TAKEN")]
    RetMonopolyMbtiReportRewardAlreadyTaken = 5800
}

[ProtoBuf.ProtoContract]
public enum ExtraLineupType
{
    [ProtoBuf.ProtoEnum(Name = @"LINEUP_NONE")]
    LineupNone = 0,

    [ProtoBuf.ProtoEnum(Name = @"LINEUP_CHALLENGE")]
    LineupChallenge = 1,

    [ProtoBuf.ProtoEnum(Name = @"LINEUP_ROGUE")]
    LineupRogue = 2,

    [ProtoBuf.ProtoEnum(Name = @"LINEUP_CHALLENGE_2")]
    LineupChallenge2 = 3,

    [ProtoBuf.ProtoEnum(Name = @"LINEUP_CHALLENGE_3")]
    LineupChallenge3 = 4,

    [ProtoBuf.ProtoEnum(Name = @"LINEUP_ROGUE_CHALLENGE")]
    LineupRogueChallenge = 5,

    [ProtoBuf.ProtoEnum(Name = @"LINEUP_STAGE_TRIAL")]
    LineupStageTrial = 6,

    [ProtoBuf.ProtoEnum(Name = @"LINEUP_ROGUE_TRIAL")]
    LineupRogueTrial = 7,

    [ProtoBuf.ProtoEnum(Name = @"LINEUP_ACTIVITY")]
    LineupActivity = 8,

    [ProtoBuf.ProtoEnum(Name = @"LINEUP_BOXING_CLUB")]
    LineupBoxingClub = 9,

    [ProtoBuf.ProtoEnum(Name = @"LINEUP_TREASURE_DUNGEON")]
    LineupTreasureDungeon = 11,

    [ProtoBuf.ProtoEnum(Name = @"LINEUP_CHESS_ROGUE")]
    LineupChessRogue = 12,

    [ProtoBuf.ProtoEnum(Name = @"LINEUP_HELIOBUS")]
    LineupHeliobus = 13
}

[ProtoBuf.ProtoContract]
public enum MissionStatus
{
    [ProtoBuf.ProtoEnum(Name = @"MISSION_NONE")]
    MissionNone = 0,

    [ProtoBuf.ProtoEnum(Name = @"MISSION_DOING")]
    MissionDoing = 1,

    [ProtoBuf.ProtoEnum(Name = @"MISSION_FINISH")]
    MissionFinish = 2,

    [ProtoBuf.ProtoEnum(Name = @"MISSION_PREPARED")]
    MissionPrepared = 3
}

[ProtoBuf.ProtoContract]
public enum TutorialStatus
{
    [ProtoBuf.ProtoEnum(Name = @"TUTORIAL_NONE")]
    TutorialNone = 0,

    [ProtoBuf.ProtoEnum(Name = @"TUTORIAL_UNLOCK")]
    TutorialUnlock = 1,

    [ProtoBuf.ProtoEnum(Name = @"TUTORIAL_FINISH")]
    TutorialFinish = 2
}

[ProtoBuf.ProtoContract]
public enum ChestType
{
    [ProtoBuf.ProtoEnum(Name = @"MAP_INFO_CHEST_TYPE_NONE")]
    MapInfoChestTypeNone = 0,

    [ProtoBuf.ProtoEnum(Name = @"MAP_INFO_CHEST_TYPE_NORMAL")]
    MapInfoChestTypeNormal = 101,

    [ProtoBuf.ProtoEnum(Name = @"MAP_INFO_CHEST_TYPE_CHALLENGE")]
    MapInfoChestTypeChallenge = 102,

    [ProtoBuf.ProtoEnum(Name = @"MAP_INFO_CHEST_TYPE_PUZZLE")]
    MapInfoChestTypePuzzle = 104
}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192

#endregion
