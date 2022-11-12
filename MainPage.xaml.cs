using Microsoft.Maui.ApplicationModel.DataTransfer;
using System;

namespace CVasApp;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnProfileButtonClickedAsync(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Profile");
    }

    private async void OnExpButtonClickedAsync(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Exp");
    }

    private async void OnCertButtonClickedAsync(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Cert");
    }

    private async void OnEducationButtonClickedAsync(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Education");
    }

    private async void OnOptionsButtonClickedAsync(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Options");
    }
    private async void OnOtherButtonClickedAsync(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Other");
    }
    private async void OnSkillsButtonClickedAsync(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Skills");
    }
    private void OnExitButtonClicked(object sender, EventArgs e)
    {
        Application.Current.Quit();
    }
    private async void OnShareButtonClickedAsync(object sender, EventArgs e)
    {
        await Share.RequestAsync(new ShareTextRequest
        {
            Uri = "https://victest.rf.gd/",
            Title = "Share Web Link"
        });
    }
}

