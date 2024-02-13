using Newtonsoft.Json;

namespace CosmicCore.Server.Utilities.Resource.Resources;

[Resource(FileNames = ["ShopConfig.json"])]
public class ShopExcel : IResource
{
    public override int Id => ShopId;
    [JsonProperty("ShopID")]
    public int ShopId { get; set; }
    public int ShopType { get; set; }

    [JsonIgnore] public Dictionary<int, ShopGoodsExcel> Goods { get; set; } = [];

    public override void OnLoad()
    {
    }
}
