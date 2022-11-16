namespace CVasApp;

public partial class Profile : ContentPage
{
    public Profile()
    {
        InitializeComponent();
    }

    private async void OnBackButtonClickedAsync(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}