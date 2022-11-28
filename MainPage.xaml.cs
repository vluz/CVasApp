using CommunityToolkit.Maui.Views;
using CVasApp.Popups;
using Plugin.Maui.Audio;

namespace CVasApp;

/// <summary>
/// Main Page code behind
/// </summary>

public partial class MainPage : ContentPage
{
    private readonly IAudioManager audioManager;
    public MainPage(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;

    }


    /// <summary>
    /// Go to profile page after short animation
    /// </summary>
    private async void OnProfileButtonClickedAsync(object sender, EventArgs e)
    {
        ProfileButton.IsEnabled = false;
        var audioplayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("click.wav"));
        await ProfileButton.ScaleTo(ProfileButton.Scale = 1.25, 70, Easing.BounceIn);
        audioplayer.Play();
        await ProfileButton.ScaleTo(ProfileButton.Scale = 1, 20, Easing.BounceIn);

        await Shell.Current.GoToAsync("Profile");
        audioplayer.Dispose();
        ProfileButton.IsEnabled = true;
    }

    /// <summary>
    /// Go to profile page after short animation
    /// </summary>
    private async void OnProfilePicClickedAsync(object sender, EventArgs e)
    {
        ProfilePic.IsEnabled = false;
        var audioplayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("click.wav"));

        await ProfilePic.ScaleXTo(0.005, 200, Easing.Linear);
        audioplayer.Play();
        await ProfilePic.ScaleXTo(1, 50, Easing.Linear);

        await Shell.Current.GoToAsync("Profile");
        audioplayer.Dispose();
        ProfilePic.IsEnabled = true;
    }


    /// <summary>
    /// Go to exp page after short animation
    /// </summary>
    private async void OnExpButtonClickedAsync(object sender, EventArgs e)
    {
        ExpButton.IsEnabled = false;
        var audioplayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("click.wav"));
        await ExpButton.ScaleTo(ExpButton.Scale = 1.25, 70, Easing.BounceIn);
        audioplayer.Play();
        await ExpButton.ScaleTo(ExpButton.Scale = 1, 20, Easing.BounceIn);
        await Shell.Current.GoToAsync("Exp");
        audioplayer.Dispose();
        ExpButton.IsEnabled = true;
    }


    /// <summary>
    /// Go to cert page after short animation
    /// </summary>
    private async void OnCertButtonClickedAsync(object sender, EventArgs e)
    {
        CertButton.IsEnabled = false;
        var audioplayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("click.wav"));
        await CertButton.ScaleTo(CertButton.Scale = 1.25, 70, Easing.BounceIn);
        audioplayer.Play();
        await CertButton.ScaleTo(CertButton.Scale = 1, 20, Easing.BounceIn);
        await Shell.Current.GoToAsync("Cert");
        audioplayer.Dispose();
        CertButton.IsEnabled = true;
    }


    /// <summary>
    /// Go to education page after short animation
    /// </summary>
    private async void OnEducationButtonClickedAsync(object sender, EventArgs e)
    {
        EducationButton.IsEnabled = false;
        var audioplayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("click.wav"));
        await EducationButton.ScaleTo(EducationButton.Scale = 1.25, 70, Easing.BounceIn);
        audioplayer.Play();
        await EducationButton.ScaleTo(EducationButton.Scale = 1, 20, Easing.BounceIn);
        await Shell.Current.GoToAsync("Education");
        audioplayer.Dispose();
        EducationButton.IsEnabled = true;
    }


    /// <summary>
    /// Go to about page after short animation
    /// </summary>
    private async void OnAboutButtonClickedAsync(object sender, EventArgs e)
    {
        AboutButton.IsEnabled = false;
        var audioplayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("click.wav"));
        await AboutButton.ScaleTo(AboutButton.Scale = 1.25, 70, Easing.BounceIn);
        audioplayer.Play();
        await AboutButton.ScaleTo(AboutButton.Scale = 1, 20, Easing.BounceIn);
        await Shell.Current.GoToAsync("About");
        audioplayer.Dispose();
        AboutButton.IsEnabled = true;
    }


    /// <summary>
    /// Go to other page after short animation
    /// </summary>
    private async void OnOtherButtonClickedAsync(object sender, EventArgs e)
    {
        OtherButton.IsEnabled = false;
        var audioplayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("click.wav"));
        await OtherButton.ScaleTo(OtherButton.Scale = 1.25, 70, Easing.BounceIn);
        audioplayer.Play();
        await OtherButton.ScaleTo(OtherButton.Scale = 1, 20, Easing.BounceIn);
        await Shell.Current.GoToAsync("Other");
        audioplayer.Dispose();
        OtherButton.IsEnabled = true;
    }


    /// <summary>
    /// Go to skills page after short animation
    /// </summary>
    private async void OnSkillsButtonClickedAsync(object sender, EventArgs e)
    {
        SkillsButton.IsEnabled = false;
        var audioplayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("click.wav"));
        await SkillsButton.ScaleTo(SkillsButton.Scale = 1.25, 70, Easing.BounceIn);
        audioplayer.Play();
        await SkillsButton.ScaleTo(SkillsButton.Scale = 1, 20, Easing.BounceIn);
        await Shell.Current.GoToAsync("Skills");
        audioplayer.Dispose();
        SkillsButton.IsEnabled = true;
    }


    /// <summary>
    /// Exit the app
    /// </summary>
    private async void OnExitButtonClicked(object sender, EventArgs e)
    {
        var audioplayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("click.wav"));
        await ExitButton.ScaleTo(ExitButton.Scale = 1.25, 70, Easing.BounceIn);
        audioplayer.Play();
        await ExitButton.ScaleTo(ExitButton.Scale = 1, 20, Easing.BounceIn);
        audioplayer.Dispose();
        Application.Current.Quit();
    }


    /// <summary>
    /// Initiates a share request
    /// </summary>
    private async void OnShareButtonClickedAsync(object sender, EventArgs e)
    {
        ShareButton.IsEnabled = false;
        var audioplayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("click.wav"));
        await ShareButton.ScaleTo(ShareButton.Scale = 1.25, 70, Easing.BounceIn);
        audioplayer.Play();
        await ShareButton.ScaleTo(ShareButton.Scale = 1, 20, Easing.BounceIn);
        await Share.RequestAsync(new ShareTextRequest
        {
            Uri = "https://victest.rf.gd/",
            Title = "Share App Link"
        });
        audioplayer.Dispose();
        ShareButton.IsEnabled = true;
    }


    /// <summary>
    /// Attempts to navigate to a web page
    /// </summary>
    private async void OnWebButtonClickedAsync(object sender, EventArgs e)
    {
        WebButton.IsEnabled = false;
        var audioplayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("click.wav"));
        await WebButton.ScaleTo(WebButton.Scale = 1.25, 70, Easing.BounceIn);
        audioplayer.Play();
        await WebButton.ScaleTo(WebButton.Scale = 1, 20, Easing.BounceIn);
        try
        {
            Uri uri = new Uri("https://victest.rf.gd/");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex)
        {
            Exception exception = ex;
            Console.WriteLine(exception.Message);
            // An unexpected error occured. No browser may be installed on the device.
        }
        audioplayer.Dispose();
        WebButton.IsEnabled = true;
    }



    /// <summary>
    /// Calls popup for signal action confirmation
    /// </summary>
    private async void OnSignalPopupClicked(object sender, EventArgs e)
    {
        SignalPopupButton.IsEnabled = false;
        var audioplayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("click.wav"));
        await SignalPopupButton.ScaleTo(SignalPopupButton.Scale = 1.25, 70, Easing.BounceIn);
        audioplayer.Play();
        await SignalPopupButton.ScaleTo(SignalPopupButton.Scale = 1, 20, Easing.BounceIn);
        var popup = new Signal();

        this.ShowPopup(popup);
        SignalPopupButton.IsEnabled = true;
        audioplayer.Dispose();
    }


    /// <summary>
    /// Calls popup for mail action confirmation
    /// </summary>
    private async void OnMailPopupClicked(object sender, EventArgs e)
    {
        MailPopupButton.IsEnabled = false;
        var audioplayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("click.wav"));
        await MailPopupButton.ScaleTo(MailPopupButton.Scale = 1.25, 70, Easing.BounceIn);
        audioplayer.Play();
        await MailPopupButton.ScaleTo(MailPopupButton.Scale = 1, 20, Easing.BounceIn);
        var popup = new Mail();

        this.ShowPopup(popup);
        audioplayer.Dispose();
        MailPopupButton.IsEnabled = true;
    }


    /// <summary>
    /// Calls popup for slack action confirmation
    /// </summary>
    private async void OnSlackPopupClicked(object sender, EventArgs e)
    {
        SlackPopupButton.IsEnabled = false;
        var audioplayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("click.wav"));
        await SlackPopupButton.ScaleTo(SlackPopupButton.Scale = 1.25, 70, Easing.BounceIn);
        audioplayer.Play();
        await SlackPopupButton.ScaleTo(SlackPopupButton.Scale = 1, 20, Easing.BounceIn);
        var popup = new Slack();

        this.ShowPopup(popup);
        audioplayer.Dispose();
        SlackPopupButton.IsEnabled = true;
    }


    /// <summary>
    /// Calls popup for phone action confirmation
    /// </summary>
    private async void OnPhonePopupClicked(object sender, EventArgs e)
    {
        PhonePopupButton.IsEnabled = false;
        var audioplayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("click.wav"));
        await PhonePopupButton.ScaleTo(PhonePopupButton.Scale = 1.25, 70, Easing.BounceIn);
        audioplayer.Play();
        await PhonePopupButton.ScaleTo(PhonePopupButton.Scale = 1, 20, Easing.BounceIn);
        var popup = new Phone();

        this.ShowPopup(popup);
        audioplayer.Dispose();
        PhonePopupButton.IsEnabled = true;
    }



    /// <summary>
    /// Android gif workaround, awaits bug fix
    /// </summary>
    //private async void OnTopGifLoaded(object sender, EventArgs e)
    //{

    //    Image image = (sender) as Image;
    //    image.Source = ImageSource.FromFile("anidark.webp");
    //    image.IsAnimationPlaying = false;
    //    image.IsAnimationPlaying = true;
    //}



    /// <summary>
    /// Bottom gif workaround, intoduces 9 seconds delay
    /// </summary>
    //private async void OnBottomGifLoaded(object sender, EventArgs e)
    //{
    //    Image image = (sender) as Image;
    //    image.Source = ImageSource.FromFile("anidark.webp");
    //    image.Rotation = 180;
    //    image.IsAnimationPlaying = false;
    //    await Task.Delay(9000);
    //    image.IsAnimationPlaying = true;
    //}
}

