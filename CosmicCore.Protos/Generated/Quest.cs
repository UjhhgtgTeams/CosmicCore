// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: Quest.proto
// </auto-generated>

namespace CosmicCore.Protos;

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
[global::ProtoBuf.ProtoContract()]
public partial class Quest : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(4, Name = @"finish_time")]
    public long FinishTime { get; set; }

    [global::ProtoBuf.ProtoMember(5, Name = @"id")]
    public uint Id { get; set; }

    [global::ProtoBuf.ProtoMember(15, Name = @"IOIPJKJIHJB", IsPacked = true)]
    public uint[] Ioipjkjihjbs { get; set; }

    [global::ProtoBuf.ProtoMember(6, Name = @"progress")]
    public uint Progress { get; set; }

    [global::ProtoBuf.ProtoMember(13, Name = @"status")]
    public QuestStatus Status { get; set; }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
