namespace CosmicCore.Server.Utilities.Resource.Resources;

[Resource(FileNames = ["MazePlane.json"])]
public class MazePlaneExcel : IResource
{
    public override int Id => PlaneID;
    public int PlaneID;
    public int WorldID;
    public int StartFloorID;
    public long PlaneName;
    public PlaneType PlaneType;

    public override void OnLoad()
    {
    }
}

public enum PlaneType
{
    Unknown = 0,
    Town = 1,
    Maze = 2,
    Train = 3,
    Challenge = 4,
    Rogue = 5,
    Raid = 6,
    AetherDivide = 7,
    TrialActivity = 8
}
