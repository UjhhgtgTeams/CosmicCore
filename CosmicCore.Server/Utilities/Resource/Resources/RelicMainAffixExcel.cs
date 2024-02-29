using Newtonsoft.Json;

namespace CosmicCore.Server.Utilities.Resource.Resources;

[Resource(FileNames = ["RelicMainAffixConfig.json"])]
public class RelicMainAffixExcel : IResource
{
    public int Id => (GroupId << 16) + AffixId;
    [JsonProperty("GroupID")]
    public int GroupId { get; }
    [JsonProperty("AffixID")]
    public int AffixId { get; }
    public AvatarPropertyType Property { get; }
    public double BaseValue { get; }
    public double LevelAdd { get; }
    public bool IsAvailable { get; }

    public void OnLoad()
    {

    }
}
