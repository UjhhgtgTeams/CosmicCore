using System.Security;
using Newtonsoft.Json;

namespace CosmicCore.Server.Utilities.Deserialize;

public static class SerializeUtils
{
    public static T? TryDeserializeFile<T>(string path) where T : class
    {
        string content;
        try
        {
            content = File.ReadAllText(path);
        }
        catch (Exception ex) when (ex is IOException or UnauthorizedAccessException
                                       or SecurityException)
        {
            return null;
        }

        return JsonConvert.DeserializeObject<T>(content);
    }
}
