namespace MauiApp_Desktop;

public partial class BrowserWindow : Window
{
    public BrowserWindow()
    {
        InitializeComponent();

        Title = "Browser Window";

        Created += (sender, args) =>
        {
            var displayInfo = DeviceDisplay.Current.MainDisplayInfo;

            X = (displayInfo.Width / displayInfo.Density - Width) / 2;
            Y = (displayInfo.Height / displayInfo.Density - Height) / 2;
        };
    }

    public void SetUrl(string url)
    {
        theWebView.Source = new Uri(url);
    }

    // Set url and open window if not already open
    public void SetUrlAndOpen(string url)
    {
        SetUrl(url);

        if (Application.Current.Windows.Any(win => win is BrowserWindow))
            return;

        Application.Current?.OpenWindow(this);
    }

}
