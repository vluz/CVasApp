using CommunityToolkit.Maui.Views;
namespace CVasApp.Popups;

public partial class Mail : Popup
{
    public Mail()
    {
        InitializeComponent();
    }

    private async void onPageloaded(object sender, EventArgs e)
    {
        while (true)
        {
            await Task.Delay(200);
            await MailActionButton.ScaleTo(0.8, 800, Easing.Linear);
            await Task.Delay(100);
            await MailActionButton.ScaleTo(1, 1000, Easing.Linear);
            await Task.Delay(200);
            
        }
    }

    private async void PopupMailCliked(object sender, EventArgs e)
    {
        await BackButton.ScaleTo(0.8, 70, Easing.Linear);
        await BackButton.ScaleTo(1, 50, Easing.Linear);
        Close();
    }

    private async void MailClicked(object sender, EventArgs e)
    {
        if (Email.Default.IsComposeSupported)
        {
            var message = new EmailMessage
            {
                Subject = "CV as App",
                Body = "",
                BodyFormat = EmailBodyFormat.PlainText,
                To = new List<string>(new[] { "vluz@me.com" })
            };
            await Email.Default.ComposeAsync(message);
        }
    }
}