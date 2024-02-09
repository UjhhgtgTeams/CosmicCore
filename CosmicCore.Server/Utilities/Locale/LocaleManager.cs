using System.Globalization;
using CosmicCore.Server.Utilities.Config;

namespace CosmicCore.Server.Utilities.Locale;

public static class LocaleManager
{
    public static string CurrentLocale
    {
        get
        {
            var locale = ConfigManager.Config.ServerOptions.Language ??
                   CurrentCulture.TwoLetterISOLanguageName.Replace("zh", "chs").ToUpper();
            if (!SupportedLocales.Contains(locale))
                locale = "EN";
            return locale;
        }
    }

    public static CultureInfo CurrentCulture => CultureInfo.CurrentUICulture;

    private static List<string> SupportedLocales = ["CHS", "CHT", "DE", "EN", "ES", "FR", "ID", "JP", "KR", "PT", "RU", "TH", "VI"];
}
