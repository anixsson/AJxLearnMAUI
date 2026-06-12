using System.Diagnostics;
using Microsoft.Extensions.DependencyInjection;
using MauiApp_Desktop.Pages;

namespace MauiApp_Desktop;

public partial class App : Application
{
    public static MainWindow MainWindow { get; private set; }
    public static BrowserWindow BrowserWindow { get; private set; }

    public App()
    {
        InitializeComponent();

        MainWindow = new MainWindow();
        BrowserWindow = new BrowserWindow();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return MainWindow;
    }
}
