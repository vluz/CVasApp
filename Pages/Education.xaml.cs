namespace CVasApp;

using AlohaKit.Animations.Helpers;
using CommunityToolkit.Maui.Views;
using CVasApp.Popups;
using Microsoft.Maui.Controls.Internals;

public partial class Education : ContentPage
{
    Border lastselected;
    public Education()
    {
        InitializeComponent();
    }

    private async void OnBackButtonClickedAsync(object sender, EventArgs e)
    {
        await BackButton.ScaleTo(0.8, 70, Easing.Linear);
        await BackButton.ScaleTo(1, 50, Easing.Linear);
        await Shell.Current.GoToAsync("..");
    }

    private async void OnTapGestureRecognizerTapped(object sender, TappedEventArgs e)
    {
        if (lastselected != null)
        {
            lastselected.StrokeThickness = 1;
            lastselected.Scale = 1;
            for (int i = 150; i > 90; i = i - 10)
            {
                lastselected.HeightRequest = i;
                await Task.Delay(1);
            }
            lastselected.HeightRequest = 90;
        }
        Border border = (sender) as Border;
        border.StrokeThickness = 6;
        await border.ScaleTo(1.15);
        for (int i = 90; i < 150; i=i+2)
        {
            border.HeightRequest = i;
            await Task.Delay(1);
        }
        lastselected = border;
    }
}