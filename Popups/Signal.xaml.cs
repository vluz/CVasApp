using CommunityToolkit.Maui.Views;
namespace CVasApp.Popups;

public partial class Signal : Popup
{
    public Signal()
    {
        InitializeComponent();
    }

    private void PopupSignalCliked(object sender, EventArgs e)
    {
        Close();
    }

    private async void SignalClicked(object sender, EventArgs e)
    {
        try
        {
            Uri uri = new Uri("https://signal.org/install");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex)
        {
            // An unexpected error occured. No browser may be installed on the device.
        }
    }
}