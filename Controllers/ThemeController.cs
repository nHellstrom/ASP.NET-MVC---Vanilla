using Microsoft.AspNetCore.Mvc;
using SaltyBook.Models;
using System.Diagnostics;


namespace SaltyBook.Controllers;

public class ThemeController : Controller
{
    public string Theme = ThemeModel.Theme;

    public ThemeController()
    {
        Theme = ThemeModel.Theme;
    }

    public void SwitchTheme()
    {
        ThemeModel.SwitchTheme();
    }
}