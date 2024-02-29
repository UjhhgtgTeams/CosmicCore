namespace CosmicCore.Server.Utilities.Resource.Resources;

[Resource(FileNames = ["PhoneThemeConfig.json"], LoadPriority = ResourceLoadPriority.Low)]
public class PhoneThemeExcel : IResource
{
    public int Id => ID;
    public int ID { get; set; }
    public PersonalizeShowType ShowType { get; set; }

    public void OnLoad()
    {
    }
}
