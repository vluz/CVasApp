using CommunityToolkit.Maui.Views;
namespace CVasApp.Popups;

public partial class Phone : Popup
{
    public Phone()
    {
        InitializeComponent();
    }

    private void PopupPhoneCliked(object sender, EventArgs e)
    {
        Close();
    }


    private void DialClicked(object sender, EventArgs e)
    {
        if (PhoneDialer.Default.IsSupported)
            PhoneDialer.Default.Open("+351932673261");
    }
}