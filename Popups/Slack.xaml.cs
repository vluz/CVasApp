using CommunityToolkit.Maui.Views;
namespace CVasApp.Popups;

public partial class Slack : Popup
{
	public Slack()
	{
		InitializeComponent();
	}
    private async void PopupSlackCliked(object sender, EventArgs e)
    {
        await BackButton.ScaleTo(0.8, 70, Easing.Linear);
        await BackButton.ScaleTo(1, 50, Easing.Linear);
        Close();
    }

    private async void SlackClicked(object sender, EventArgs e)
    {
        try
        {
            Uri uri = new Uri("https://vic-zt72202.slack.com/");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex)
        {
            // An unexpected error occured. No browser may be installed on the device.
        }
    }

    private async void onPageLoaded(object sender, EventArgs e)
    {
        while (true)
        {
            await Task.Delay(200);
            await SlackActionButton.ScaleTo(0.8, 800, Easing.Linear);
            await Task.Delay(100);
            await SlackActionButton.ScaleTo(1, 1000, Easing.Linear);
            await Task.Delay(200);
        }
    }
}