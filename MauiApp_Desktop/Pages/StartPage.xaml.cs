using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp_Desktop.Pages;

public partial class StartPage : ContentPage
{
    public StartPage()
    {
        InitializeComponent();
    }

    private void Button_OnPressed(object? sender, EventArgs e)
    {
        var url = "https://learn.microsoft.com/en-us/dotnet/maui/what-is-maui?view=net-maui-10.0";

        // Show the browser window
        var win = App.BrowserWindow;
        win.SetUrlAndOpen(url);

    }
}
