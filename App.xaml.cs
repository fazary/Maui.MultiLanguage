using Maui.MultiLanguage.Helpers;

namespace Maui.MultiLanguage;

public partial class App : Application
{
    public App()
    {
        LanguageHelper.SetLanguage();
        InitializeComponent();

        MainPage = new AppShell();
    }
}
