using CosmicCore.Protos;
using CosmicCore.Server.Gate.Services.Inventory;
using Newtonsoft.Json;

namespace CosmicCore.Server.Utilities.Resource.Resources;

[Resource(FileNames = ["ShopGoodsConfig.json"], LoadPriority = ResourceLoadPriority.Low)]
public class ShopGoodsExcel : IResource
{
    public override int Id => GoodsId;
    [JsonProperty("GoodsID")]
    public int GoodsId { get; set; }
    [JsonProperty("ItemID")]
    public int ItemId { get; set; }
    public int ItemCount { get; set; }
    [JsonProperty("ShopID")]
    public int ShopId { get; set; }
    public int[] CurrencyList { get; set; }
    public int[] CurrencyCostList { get; set; }

    private List<ItemParam> costList = [];

    public override void OnLoad()
    {
        if (ItemId == 0)
            return;

        ResourceManager.ShopExcels.First(shop => shop.Id == ShopId).Goods.Add(GoodsId, this);

        for (var i = 0; i < CurrencyList.Length; i++)
        {
            var param = new ItemParam(CurrencyList[i], CurrencyCostList[i]);
            costList.Add(param);
        }
    }

    public Goods ToProto()
    {
        var proto = new Goods
        {
            GoodsId = Convert.ToUInt32(GoodsId),
            ItemId = Convert.ToUInt32(ItemId),
            EndTime = int.MaxValue
        };
        return proto;
    }
}
