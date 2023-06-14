using CommunityToolkit.Maui.Views;
namespace CVasApp.Popups;

/// <summary>
/// Github popup code behind
/// </summary>

public partial class Github : Popup
{
    public Github()
    {
        InitializeComponent();
    }


    /// <summary>
    /// Perform animation and close popup
    /// </summary>
    private async void PopupGithubCliked(object sender, EventArgs e)
    {
        await BackButton.ScaleTo(0.8, 70, Easing.Linear);
        await BackButton.ScaleTo(1, 50, Easing.Linear);
        Close();
    }


    /// <summary>
    /// Calls default browser to open a link to Github.org
    /// </summary>
    private async void GithubClicked(object sender, EventArgs e)
    {
        try
        {
            Uri uri = new Uri("https://github.com/vluz");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex)
        {
            Exception exception = ex;
            Console.WriteLine(exception.Message);
            // An unexpected error occurred. No browser may be installed on the device.
        }
    }


    /// <summary>
    /// Performs animation on page load
    /// </summary>
    private async void onPageLoaded(object sender, EventArgs e)
    {
        while (true)
        {
            await Task.Delay(200);
            await GithubActionButton.ScaleTo(0.8, 800, Easing.Linear);
            await Task.Delay(100);
            await GithubActionButton.ScaleTo(1, 1000, Easing.Linear);
            await Task.Delay(200);
        }
    }
}