using CommunityToolkit.Maui.Views;

namespace CVasApp.Popups;

public partial class Telegram : Popup
{
    public Telegram()
    {
        InitializeComponent();
    }

    private void PopupTelegramCliked(object sender, EventArgs e)
    {
        Close();
    }

    private async void TelegramClicked(object sender, EventArgs e)
    {
        try
        {
            Uri uri = new Uri("https://t.me/Victor_E_Luz");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex)
        {
            // An unexpected error occured. No browser may be installed on the device.
        }
    }
}