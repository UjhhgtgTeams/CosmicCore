// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: NpcRogueInfo.proto
// </auto-generated>

namespace CosmicCore.Protos;

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
[global::ProtoBuf.ProtoContract()]
public partial class NpcRogueInfo : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(15, Name = @"HCGOEHLPCMD")]
    [global::ProtoBuf.ProtoMap]
    public global::System.Collections.Generic.Dictionary<uint, uint> Hcgoehlpcmds { get; } = new global::System.Collections.Generic.Dictionary<uint, uint>();

    [global::ProtoBuf.ProtoMember(13, Name = @"AGBFDIIKPKF")]
    public bool Agbfdiikpkf { get; set; }

    [global::ProtoBuf.ProtoMember(5, Name = @"finish_dialogue")]
    public bool FinishDialogue { get; set; }

    [global::ProtoBuf.ProtoMember(6, Name = @"rogue_npc_id")]
    public uint RogueNpcId { get; set; }

    [global::ProtoBuf.ProtoMember(14, Name = @"GBMDBBBMBEJ")]
    public uint Gbmdbbbmbej { get; set; }

    [global::ProtoBuf.ProtoMember(12, Name = @"INJPFALMDHJ")]
    public uint Injpfalmdhj { get; set; }

    [global::ProtoBuf.ProtoMember(1, Name = @"GENMIFOCMJA")]
    public uint Genmifocmja { get; set; }

    [global::ProtoBuf.ProtoMember(7, Name = @"MNINDBMAJKL")]
    public bool Mnindbmajkl { get; set; }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
