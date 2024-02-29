using CosmicCore.Server.Utilities.Account;
using Newtonsoft.Json;

namespace CosmicCore.Server.Utilities.Resource.Resources;

[Resource(FileNames = ["HeroConfig.json"])]
public class HeroExcel : IResource
{
    [JsonProperty("HeroAvatarID")]
    public int HeroAvatarId { get; set; }
    public Gender Gender { get; set; }
    public int Id => HeroAvatarId;

    public void OnLoad()
    {
    }
}
