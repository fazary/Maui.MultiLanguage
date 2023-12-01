using MultiLanguage.Resources;
using System.Globalization;

namespace Maui.MultiLanguage.Helpers;

internal static class LanguageHelper
{
    public static void SetLanguage()
    {
        var culture = new CultureInfo(Settings.CurrentLanguage);
        LocalizationResourceManager.Instance.SetCulture(culture);
    }
    public static void SetLanguage(string language)
    {
        Settings.CurrentLanguage = language;
        SetLanguage();
    }
}