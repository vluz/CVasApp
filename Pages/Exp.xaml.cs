namespace CVasApp;

public partial class Exp : ContentPage
{
    public Exp()
    {
        InitializeComponent();
    }

    private async void OnBackButtonClickedAsync(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}