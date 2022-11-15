namespace CVasApp;

public partial class Cert : ContentPage
{
	public Cert()
	{
		InitializeComponent();
	}

    private async void OnBackButtonClickedAsync(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}