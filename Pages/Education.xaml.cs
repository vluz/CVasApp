namespace CVasApp;

using CommunityToolkit.Maui.Views;
using CVasApp.Popups;
using Microsoft.Maui.Controls.Internals;

public partial class Education : ContentPage
{
    public Education()
    {
        InitializeComponent();
    }

    private async void OnBackButtonClickedAsync(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

}