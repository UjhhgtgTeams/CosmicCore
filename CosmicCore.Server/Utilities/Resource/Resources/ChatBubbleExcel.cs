namespace CosmicCore.Server.Utilities.Resource.Resources;

[Resource(FileNames = ["ChatBubbleConfig.json"], LoadPriority = ResourceLoadPriority.Low)]
public class ChatBubbleExcel : IResource
{
    public int ID { get; set; }
    public PersonalizeShowType ShowType { get; set; }
    public int Id => ID;

    public void OnLoad()
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
