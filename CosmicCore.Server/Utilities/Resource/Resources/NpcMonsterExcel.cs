using Newtonsoft.Json;

namespace CosmicCore.Server.Utilities.Resource.Resources;

[Resource(FileNames = ["NPCMonsterData.json"])]
public class NpcMonsterExcel : IResource
{
    public int Id => ID;
    public int ID { get; set; }
    [JsonProperty("NPCName")]
    public HashedName NpcName { get; set; }

    public void OnLoad()
    {
    }
}
