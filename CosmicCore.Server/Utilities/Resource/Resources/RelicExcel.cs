using Newtonsoft.Json;

namespace CosmicCore.Server.Utilities.Resource.Resources;

[Resource(FileNames = ["RelicConfig.json"], LoadPriority = ResourceLoadPriority.Low)]
public class RelicExcel : IResource
{
    public int Id => ID;
    public int ID { get; set; }
    [JsonProperty("SetID")]
    public int SetId { get; set; }
    public RelicType Type { get; set; }
    public int MainAffixGroup { get; set; }
    public int SubAffixGroup { get; set; }
    public int MaxLevel { get; set; }
    public int ExpType { get; set; }
    public int ExpProvide { get; set; }
    public int CoinCost { get; set; }

    public void OnLoad()
    {
        for (var idx = 0; idx <= ResourceManager.ItemExcels.Count - 1; idx++)
        {
            ResourceManager.ItemExcels[idx].RelicExcel = this;
        }
    }

    // ReSharper disable IdentifierTypo // darn
    // ReSharper disable InconsistentNaming
    public enum RelicType
    {
        Unknow = 0,
        HEAD = 1,
        HAND = 2,
        BODY = 3,
        FOOT = 4,
        NECK = 5,
        OBJECT = 6
    }
}
