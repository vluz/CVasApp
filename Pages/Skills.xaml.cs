namespace CVasApp;

public partial class Skills : ContentPage
{
	public Skills()
	{
		InitializeComponent();
	}

    private async void OnBackButtonClickedAsync(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}