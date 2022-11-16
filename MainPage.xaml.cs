﻿using CommunityToolkit.Maui.Views;
using CVasApp.Popups;
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
        ProfileButton.IsEnabled = false;
        var audioplayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("click.wav"));
        var scaleupani = ProfileButton.ScaleTo(ProfileButton.Scale = 1.25, 70, Easing.BounceIn);
        await Task.WhenAll(scaleupani);
        audioplayer.Play();
        var scaledownani = ProfileButton.ScaleTo(ProfileButton.Scale = 1, 70, Easing.BounceIn);
        await Task.WhenAll(scaledownani);
        await Shell.Current.GoToAsync("Profile");
        audioplayer.Dispose();
        ProfileButton.IsEnabled = true;
    }
    private async void OnProfilePicClickedAsync(object sender, EventArgs e)
    {
        ProfilePic.IsEnabled = false;
        var audioplayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("click.wav"));
        audioplayer.Play();
        await Shell.Current.GoToAsync("Profile");
        audioplayer.Dispose();
        ProfilePic.IsEnabled = true;
    }

    private async void OnExpButtonClickedAsync(object sender, EventArgs e)
    {
        ExpButton.IsEnabled = false;
        var audioplayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("click.wav"));
        var scaleupani = ExpButton.ScaleTo(ExpButton.Scale = 1.25, 70, Easing.BounceIn);
        await Task.WhenAll(scaleupani);
        audioplayer.Play();
        var scaledownani = ExpButton.ScaleTo(ExpButton.Scale = 1, 70, Easing.BounceIn);
        await Task.WhenAll(scaledownani);
        await Shell.Current.GoToAsync("Exp");
        audioplayer.Dispose();
        ExpButton.IsEnabled = true;
    }

    private async void OnCertButtonClickedAsync(object sender, EventArgs e)
    {
        CertButton.IsEnabled = false;
        var audioplayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("click.wav"));
        var scaleupani = CertButton.ScaleTo(CertButton.Scale = 1.25, 70, Easing.BounceIn);
        await Task.WhenAll(scaleupani);
        audioplayer.Play();
        var scaledownani = CertButton.ScaleTo(CertButton.Scale = 1, 70, Easing.BounceIn);
        await Task.WhenAll(scaledownani);
        await Shell.Current.GoToAsync("Cert");
        audioplayer.Dispose();
        CertButton.IsEnabled = true;
    }

    private async void OnEducationButtonClickedAsync(object sender, EventArgs e)
    {
        EducationButton.IsEnabled = false;
        var audioplayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("click.wav"));
        var scaleupani = EducationButton.ScaleTo(EducationButton.Scale = 1.25, 70, Easing.BounceIn);
        await Task.WhenAll(scaleupani);
        audioplayer.Play();
        var scaledownani = EducationButton.ScaleTo(EducationButton.Scale = 1, 70, Easing.BounceIn);
        await Task.WhenAll(scaledownani);
        await Shell.Current.GoToAsync("Education");
        audioplayer.Dispose();
        EducationButton.IsEnabled = true;
    }

    private async void OnAboutButtonClickedAsync(object sender, EventArgs e)
    {
        AboutButton.IsEnabled = false;
        var audioplayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("click.wav"));
        var scaleupani = AboutButton.ScaleTo(AboutButton.Scale = 1.25, 70, Easing.BounceIn);
        await Task.WhenAll(scaleupani);
        audioplayer.Play();
        var scaledownani = AboutButton.ScaleTo(AboutButton.Scale = 1, 70, Easing.BounceIn);
        await Task.WhenAll(scaledownani);
        await Shell.Current.GoToAsync("About");
        audioplayer.Dispose();
        AboutButton.IsEnabled = true;
    }
    private async void OnOtherButtonClickedAsync(object sender, EventArgs e)
    {
        OtherButton.IsEnabled = false;
        var audioplayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("click.wav"));
        var scaleupani = OtherButton.ScaleTo(OtherButton.Scale = 1.25, 70, Easing.BounceIn);
        await Task.WhenAll(scaleupani);
        audioplayer.Play();
        var scaledownani = OtherButton.ScaleTo(OtherButton.Scale = 1, 70, Easing.BounceIn);
        await Task.WhenAll(scaledownani);
        await Shell.Current.GoToAsync("Other");
        audioplayer.Dispose();
        OtherButton.IsEnabled = true;
    }
    private async void OnSkillsButtonClickedAsync(object sender, EventArgs e)
    {
        SkillsButton.IsEnabled = false;
        var audioplayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("click.wav"));
        var scaleupani = SkillsButton.ScaleTo(SkillsButton.Scale = 1.25, 70, Easing.BounceIn);
        await Task.WhenAll(scaleupani);
        audioplayer.Play();
        var scaledownani = SkillsButton.ScaleTo(SkillsButton.Scale = 1, 70, Easing.BounceIn);
        await Task.WhenAll(scaledownani);
        await Shell.Current.GoToAsync("Skills");
        audioplayer.Dispose();
        SkillsButton.IsEnabled = true;
    }
    private async void OnExitButtonClicked(object sender, EventArgs e)
    {
        var audioplayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("click.wav"));
        var scaleupani = ExitButton.ScaleTo(ExitButton.Scale = 1.25, 70, Easing.BounceIn);
        await Task.WhenAll(scaleupani);
        audioplayer.Play();
        var scaledownani = ExitButton.ScaleTo(ExitButton.Scale = 1, 70, Easing.BounceIn);
        await Task.WhenAll(scaledownani);
        audioplayer.Dispose();
        Application.Current.Quit();
    }
    private async void OnShareButtonClickedAsync(object sender, EventArgs e)
    {
        ShareButton.IsEnabled = false;
        var audioplayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("click.wav"));
        var scaleupani = ShareButton.ScaleTo(ShareButton.Scale = 1.25, 70, Easing.BounceIn);
        await Task.WhenAll(scaleupani);
        audioplayer.Play();
        var scaledownani = ShareButton.ScaleTo(ShareButton.Scale = 1, 70, Easing.BounceIn);
        await Task.WhenAll(scaledownani);
        await Share.RequestAsync(new ShareTextRequest
        {
            Uri = "https://victest.rf.gd/",
            Title = "Share App Link"
        });
        audioplayer.Dispose();
        ShareButton.IsEnabled = true;
    }
    private async void OnWebButtonClickedAsync(object sender, EventArgs e)
    {
        WebButton.IsEnabled = false;
        var audioplayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("click.wav"));
        var scaleupani = WebButton.ScaleTo(WebButton.Scale = 1.25, 70, Easing.BounceIn);
        await Task.WhenAll(scaleupani);
        audioplayer.Play();
        var scaledownani = WebButton.ScaleTo(WebButton.Scale = 1, 70, Easing.BounceIn);
        await Task.WhenAll(scaledownani);
        try
        {
            Uri uri = new Uri("https://victest.rf.gd/");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex)
        {
            // An unexpected error occured. No browser may be installed on the device.
        }
        audioplayer.Dispose();
        WebButton.IsEnabled = true;
    }

    private async void OnSignalPopupClicked(object sender, EventArgs e)
    {
        SignalPopupButton.IsEnabled = false;
        var audioplayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("click.wav"));
        audioplayer.Play();
        var popup = new Signal();

        this.ShowPopup(popup);
        SignalPopupButton.IsEnabled = true;
        //audioplayer.Dispose();
    }
    private async void OnMailPopupClicked(object sender, EventArgs e)
    {
        MailPopupButton.IsEnabled = false;
        var audioplayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("click.wav"));
        audioplayer.Play();
        var popup = new Mail();

        this.ShowPopup(popup);
        //audioplayer.Dispose();
        MailPopupButton.IsEnabled = true;
    }
    private async void OnTelegramPopupClicked(object sender, EventArgs e)
    {
        TelegramPopupButton.IsEnabled = false;
        var audioplayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("click.wav"));
        audioplayer.Play();
        var popup = new Telegram();

        this.ShowPopup(popup);
        //audioplayer.Dispose();
        TelegramPopupButton.IsEnabled = true;
    }
    private async void OnPhonePopupClicked(object sender, EventArgs e)
    {
        PhonePopupButton.IsEnabled = false;
        var audioplayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("click.wav"));
        audioplayer.Play();
        var popup = new Phone();

        this.ShowPopup(popup);
        //audioplayer.Dispose();
        PhonePopupButton.IsEnabled = true;
    }
}

