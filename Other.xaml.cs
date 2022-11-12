namespace CVasApp;

public partial class Other : ContentPage
{
	public Other()
	{
		InitializeComponent();
	}

    private async void OnBackButtonClickedAsync(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}