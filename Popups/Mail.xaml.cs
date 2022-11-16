using CommunityToolkit.Maui.Views;

namespace CVasApp.Popups;

public partial class Mail : Popup
{
    public Mail()
    {
        InitializeComponent();
    }

    private void PopupMailCliked(object sender, EventArgs e)
    {
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