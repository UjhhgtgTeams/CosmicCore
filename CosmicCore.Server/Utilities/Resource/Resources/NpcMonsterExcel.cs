namespace CosmicCore.Server.Utilities.Resource.Resources;

[Resource(FileNames = ["NPCMonsterData.json"])]
public class NpcMonsterExcel : IResource
{
    public override int Id => ID;
    public int ID;
    public long NPCName;

    public override void OnLoad()
    {
    }
}
