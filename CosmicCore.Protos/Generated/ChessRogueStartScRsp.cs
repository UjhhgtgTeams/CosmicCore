// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: ChessRogueStartScRsp.proto
// </auto-generated>

namespace CosmicCore.Protos;

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
[global::ProtoBuf.ProtoContract()]
public partial class ChessRogueStartScRsp : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(2, Name = @"retcode")]
    public uint Retcode { get; set; }

    [global::ProtoBuf.ProtoMember(10, Name = @"current_info")]
    public ChessRogueCurrentInfo CurrentInfo { get; set; }

    [global::ProtoBuf.ProtoMember(1, Name = @"lineup")]
    public LineupInfo Lineup { get; set; }

    [global::ProtoBuf.ProtoMember(7, Name = @"cell_info")]
    public ChessRogueCellInfo CellInfo { get; set; }

    [global::ProtoBuf.ProtoMember(4, Name = @"scene")]
    public SceneInfo Scene { get; set; }

    [global::ProtoBuf.ProtoMember(11, Name = @"chess_rogue_info")]
    public ChessRogueInfo ChessRogueInfo { get; set; }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
