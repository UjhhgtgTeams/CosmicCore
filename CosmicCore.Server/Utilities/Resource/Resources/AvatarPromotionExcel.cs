using CosmicCore.Server.Gate.Services.Inventory;

namespace CosmicCore.Server.Utilities.Resource.Resources;

[Resource(FileNames = ["AvatarPromotionConfig.json"], LoadPriority = ResourceLoadPriority.Highest)]
public class AvatarPromotionExcel : IResource
{
    public int AvatarID { get; set; }
    public int Promotion { get; set; }
    public int MaxLevel { get; set; }
    public int PlayerLevelRequire { get; set; }
    public int WorldLevelRequire { get; set; }
    public List<ItemParam> PromotionCostList { get; set; }
    public int Id => (AvatarID << 8) + Promotion;

    public void OnLoad()
    {
    }
}
