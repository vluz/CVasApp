namespace CVasApp;

/// <summary>
/// Exp Page code behind
/// </summary>

public partial class Exp : ContentPage
{
    public Exp()
    {
        InitializeComponent();
    }

    private async void OnBackButtonClickedAsync(object sender, EventArgs e)
    {
        await BackButton.ScaleTo(0.8, 70, Easing.Linear);
        await BackButton.ScaleTo(1, 50, Easing.Linear);
        await Shell.Current.GoToAsync("..");
    }
}