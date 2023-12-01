using Maui.MultiLanguage.Helpers;

namespace Maui.MultiLanguage;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        string lang = Settings.CurrentLanguage switch
        {
            "en" => "ar",
            _ => "en"
        };
        LanguageHelper.SetLanguage(lang);
    }
}

