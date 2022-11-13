using Microsoft.Maui.ApplicationModel.DataTransfer;
using System;
using Plugin.Maui.Audio;

namespace CVasApp;

public partial class MainPage : ContentPage
{
    private readonly IAudioManager audioManager;
    public MainPage(IAudioManager audioManager)
    {
        InitializeComponent();
        this.audioManager = audioManager;
    }

    private async void OnProfileButtonClickedAsync(object sender, EventArgs e)
    {
        var audioplayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("click.wav"));
        var scaleupani = ProfileButton.ScaleTo(ProfileButton.Scale = 1.25, 70, Easing.BounceIn);
        await Task.WhenAll(scaleupani);
        audioplayer.Play();
        var scaledownani = ProfileButton.ScaleTo(ProfileButton.Scale = 1, 70, Easing.BounceIn);
        await Task.WhenAll(scaledownani);
        //audioplayer.Dispose();
        await Shell.Current.GoToAsync("Profile");
    }
    private async void OnProfilePicClickedAsync(object sender, EventArgs e)
    {
        var audioplayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("click.wav"));
        audioplayer.Play();
        //audioplayer.Dispose();
        await Shell.Current.GoToAsync("Profile");
    }

    private async void OnExpButtonClickedAsync(object sender, EventArgs e)
    {
        var audioplayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("click.wav"));
        var scaleupani = ExpButton.ScaleTo(ExpButton.Scale = 1.25, 70, Easing.BounceIn);
        await Task.WhenAll(scaleupani);
        audioplayer.Play();
        var scaledownani = ExpButton.ScaleTo(ExpButton.Scale = 1, 70, Easing.BounceIn);
        await Task.WhenAll(scaledownani);
        //audioplayer.Dispose();
        await Shell.Current.GoToAsync("Exp");
    }

    private async void OnCertButtonClickedAsync(object sender, EventArgs e)
    {
        var audioplayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("click.wav"));
        var scaleupani = CertButton.ScaleTo(CertButton.Scale = 1.25, 70, Easing.BounceIn);
        await Task.WhenAll(scaleupani);
        audioplayer.Play();
        var scaledownani = CertButton.ScaleTo(CertButton.Scale = 1, 70, Easing.BounceIn);
        await Task.WhenAll(scaledownani);
        //audioplayer.Dispose();
        await Shell.Current.GoToAsync("Cert");
    }

    private async void OnEducationButtonClickedAsync(object sender, EventArgs e)
    {
        var audioplayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("click.wav"));
        var scaleupani = EducationButton.ScaleTo(EducationButton.Scale = 1.25, 70, Easing.BounceIn);
        await Task.WhenAll(scaleupani);
        audioplayer.Play();
        var scaledownani = EducationButton.ScaleTo(EducationButton.Scale = 1, 70, Easing.BounceIn);
        await Task.WhenAll(scaledownani);
        //audioplayer.Dispose();
        await Shell.Current.GoToAsync("Education");
    }

    private async void OnOptionsButtonClickedAsync(object sender, EventArgs e)
    {
        var audioplayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("click.wav"));
        var scaleupani = OptionsButton.ScaleTo(OptionsButton.Scale = 1.25, 70, Easing.BounceIn);
        await Task.WhenAll(scaleupani);
        audioplayer.Play();
        var scaledownani = OptionsButton.ScaleTo(OptionsButton.Scale = 1, 70, Easing.BounceIn);
        await Task.WhenAll(scaledownani);
        //audioplayer.Dispose();
        await Shell.Current.GoToAsync("Options");
    }
    private async void OnOtherButtonClickedAsync(object sender, EventArgs e)
    {
        var audioplayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("click.wav"));
        var scaleupani = OtherButton.ScaleTo(OtherButton.Scale = 1.25, 70, Easing.BounceIn);
        await Task.WhenAll(scaleupani);
        audioplayer.Play();
        var scaledownani = OtherButton.ScaleTo(OtherButton.Scale = 1, 70, Easing.BounceIn);
        await Task.WhenAll(scaledownani);
        //audioplayer.Dispose();
        await Shell.Current.GoToAsync("Other");
    }
    private async void OnSkillsButtonClickedAsync(object sender, EventArgs e)
    {
        var audioplayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("click.wav"));
        var scaleupani = SkillsButton.ScaleTo(SkillsButton.Scale = 1.25, 70, Easing.BounceIn);
        await Task.WhenAll(scaleupani);
        audioplayer.Play();
        var scaledownani = SkillsButton.ScaleTo(SkillsButton.Scale = 1, 70, Easing.BounceIn);
        await Task.WhenAll(scaledownani);
        //audioplayer.Dispose();
        await Shell.Current.GoToAsync("Skills");
    }
    private async void OnExitButtonClicked(object sender, EventArgs e)
    {
        var audioplayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("click.wav"));
        var scaleupani = ExitButton.ScaleTo(ExitButton.Scale = 1.25, 70, Easing.BounceIn);
        await Task.WhenAll(scaleupani);
        audioplayer.Play();
        var scaledownani = ExitButton.ScaleTo(ExitButton.Scale = 1, 70, Easing.BounceIn);
        await Task.WhenAll(scaledownani);
        //audioplayer.Dispose();
        Application.Current.Quit();
    }
    private async void OnShareButtonClickedAsync(object sender, EventArgs e)
    {
        var audioplayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("click.wav"));
        var scaleupani = ShareButton.ScaleTo(ShareButton.Scale = 1.25, 70, Easing.BounceIn);
        await Task.WhenAll(scaleupani);
        audioplayer.Play();
        var scaledownani = ShareButton.ScaleTo(ShareButton.Scale = 1, 70, Easing.BounceIn);
        await Task.WhenAll(scaledownani);
        //audioplayer.Dispose();
        await Share.RequestAsync(new ShareTextRequest
        {
            Uri = "https://victest.rf.gd/",
            Title = "Share App Link"
        });
    }
    private async void OnWebButtonClickedAsync(object sender, EventArgs e)
    {
        var audioplayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("click.wav"));
        var scaleupani = WebButton.ScaleTo(WebButton.Scale = 1.25, 70, Easing.BounceIn);
        await Task.WhenAll(scaleupani);
        audioplayer.Play();
        var scaledownani = WebButton.ScaleTo(WebButton.Scale = 1, 70, Easing.BounceIn);
        await Task.WhenAll(scaledownani);
        //audioplayer.Dispose();
        try
        {
            Uri uri = new Uri("https://victest.rf.gd/");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex)
        {
            // An unexpected error occured. No browser may be installed on the device.
        }
    }
}

