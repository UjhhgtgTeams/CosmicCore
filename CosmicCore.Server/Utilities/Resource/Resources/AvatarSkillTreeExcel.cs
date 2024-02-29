using CosmicCore.Server.Gate.Services.Inventory;
using Newtonsoft.Json;

namespace CosmicCore.Server.Utilities.Resource.Resources;

[Resource(FileNames = ["AvatarSkillTreeConfig.json"], LoadPriority = ResourceLoadPriority.Low)]
public class AvatarSkillTreeExcel : IResource
{
    [JsonProperty("PointID")] public int PointId { get; set; }

    public int Level { get; set; }
    public int MaxLevel { get; set; }
    public bool DefaultUnlock { get; set; }

    [JsonProperty("AvatarID")] public int AvatarId { get; set; }

    public int AvatarPromotionLimit { get; set; }
    public int AvatarLevelLimit { get; set; }

    public List<ItemParam> MaterialList { get; set; }
    public List<int> PrePoint { get; set; }

    [JsonProperty("LevelUpSkillID")] public List<int> LevelUpSkillId { get; set; }

    public int Id => (PointId << 4) + Level;

    public void OnLoad()
    {
        var excel = ResourceManager.AvatarExcels.First(avatar => avatar.Id == AvatarId);

        if (DefaultUnlock)
        {
            excel.DefaultSkillTrees.Add(this);
        }

        excel.SkillTreeIds.Add(PointId);
    }
}
