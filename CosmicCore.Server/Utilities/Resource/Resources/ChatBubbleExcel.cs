namespace CosmicCore.Server.Utilities.Resource.Resources;

[Resource(FileNames = ["ChatBubbleConfig.json"], LoadPriority = ResourceLoadPriority.Low)]
public class ChatBubbleExcel : IResource
{
    public override int Id => ID;
    public int ID { get; set; }
    public PersonalizeShowType ShowType { get; set; }

    public override void OnLoad()
    {
    }
}

public enum PersonalizeShowType
{
    None,
    Always,
    AfterStart,
    InSchedule,
    UnlockedOnly
}
