namespace MauiApp_Desktop;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        Title = "Learning MAUI on Desktop";



        SizeChanged += OnSizeChanged;
        Destroying += (sender, args) =>
        {
            Application.Current?.Quit();
        };
        Created += (sender, args) =>
        {
            var displayInfo = DeviceDisplay.Current.MainDisplayInfo;

            X = (displayInfo.Width / displayInfo.Density - Width) / 2;
            Y = (displayInfo.Height / displayInfo.Density - Height) / 2;
        };
    }

    private void OnSizeChanged(object? sender, EventArgs e)
    {
        // if width is more than 1000, set window width to 1000
        if (this.Width > 800)
        {
            FlyoutPager.FlyoutLayoutBehavior = FlyoutLayoutBehavior.Split;
        }
        else
        {
            FlyoutPager.FlyoutLayoutBehavior = FlyoutLayoutBehavior.Default;
        }
    }


    private void Button_OnPressed(object? sender, EventArgs e)
    {
        if (sender is Button button && button.CommandParameter is string url)
        {
            App.BrowserWindow.SetUrl(url);
        }
    }
}
