using Newtonsoft.Json;

namespace CosmicCore.Server.Utilities.Resource.Resources;

[Resource(FileNames = ["MazePlane.json"])]
public class MazePlaneExcel : IResource
{
    public int Id => PlaneId;
    [JsonProperty("PlaneID")]
    public int PlaneId { get; set; }
    [JsonProperty("WorldID")]
    public int WorldId { get; set; }
    [JsonProperty("StartFloorID")]
    public int StartFloorId { get; set; }
    public HashedName PlaneName { get; set; }
    public PlaneType PlaneType { get; set; }

    public void OnLoad()
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
