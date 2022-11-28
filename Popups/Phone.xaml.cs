using CommunityToolkit.Maui.Views;
namespace CVasApp.Popups;

/// <summary>
/// Phone popup code behind
/// </summary>

public partial class Phone : Popup
{
    public Phone()
    {
        InitializeComponent();
    }


    /// <summary>
    /// Perform animation and close popup
    /// </summary>
    private async void PopupPhoneCliked(object sender, EventArgs e)
    {
        await BackButton.ScaleTo(0.8, 70, Easing.Linear);
        await BackButton.ScaleTo(1, 50, Easing.Linear);
        Close();
    }


    /// <summary>
    /// Open default dialer and pop the phone number
    /// </summary>
    private void DialClicked(object sender, EventArgs e)
    {
        if (PhoneDialer.Default.IsSupported)
            PhoneDialer.Default.Open("+351932673261");
    }


    /// <summary>
    /// Performs animation on page load
    /// </summary>
    private async void onPageloaded(object sender, EventArgs e)
    {
        while (true)
        {
            await Task.Delay(200);
            await PhoneActionButton.ScaleTo(0.8, 800, Easing.Linear);
            await Task.Delay(100);
            await PhoneActionButton.ScaleTo(1, 1000, Easing.Linear);
            await Task.Delay(200);
        }
    }
}