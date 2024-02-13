using CosmicCore.Protos;
using CosmicCore.Server.Utilities.Resource.Resources;
using Random = CosmicCore.Server.Utilities.Random;

namespace CosmicCore.Server.Gate.Services.Inventory;

public class RelicSubAffix
{
    public int Id { get; }
    public int Count { get; private set; }
    public int Step { get; private set; }

    public RelicSubAffix(RelicSubAffixExcel excel, int count = 1)
    {
        Id = excel.AffixId;
        Count = count;
        Step = Random.FromIntRange(count * excel.StepNum);
    }

    public void IncrementCount(int stepNum)
    {
        Count += 1;
        Step += Random.FromIntRange(stepNum);
    }

    public RelicAffix ToProto()
    {
        return new RelicAffix
        {
            AffixId = (uint)Id,
            Cnt = (uint)Count,
            Step = (uint)Step
        };
    }
}
