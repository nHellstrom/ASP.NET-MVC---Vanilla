namespace SaltyBook.Models;

public static class ThemeModel
{
    public static string Theme { get; set; } = "light-theme";

    private static void SetDarkTheme()
    {
        Theme = "dark-theme";
    }

    private static void SetLightTheme()
    {
        Theme = "light-theme";
    }

    public static void SwitchTheme()
    {
        if (Theme == "light-theme")
        {
            SetDarkTheme();
        }
        else
        {
            SetLightTheme();
        }
    }
}