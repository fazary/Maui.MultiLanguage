namespace Maui.MultiLanguage.Helpers;

internal static class Settings
{
    public static string CurrentLanguage
    {
        get => Preferences.Get(nameof(CurrentLanguage), "en");
        set => Preferences.Set(nameof(CurrentLanguage), value);
    }
}