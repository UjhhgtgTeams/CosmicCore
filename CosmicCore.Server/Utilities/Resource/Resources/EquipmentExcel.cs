using CosmicCore.Server.Gate.Services.Inventory;
using Newtonsoft.Json;

namespace CosmicCore.Server.Utilities.Resource.Resources;

[Resource(FileNames = ["EquipmentConfig.json"], LoadPriority = ResourceLoadPriority.Low)]
public class EquipmentExcel : IResource
{
    [JsonProperty("EquipmentID")]
    public int EquipmentId { get; set; }
    public int MaxPromotion { get; set; }
    public int MaxRank { get; set; }
    public int ExpType { get; set; }
    public int ExpProvide { get; set; }
    public int CoinCost { get; set; }
    public HashSet<int> RankUpCostList { get; set; }
    public override int Id => EquipmentId;

    public override void OnLoad()
    {
        ResourceManager.ItemExcels.First(it => it.Id == Id).EquipmentExcel = this;
    }

    public bool IsRankUpItem(Item item)
    {
        return item.ItemId == Id || RankUpCostList.Contains(item.ItemId);
    }
}
