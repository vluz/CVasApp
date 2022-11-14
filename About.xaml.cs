namespace CVasApp;

public partial class About : ContentPage
{
	public About()
	{
		InitializeComponent();
	}

    private async void OnBackButtonClickedAsync(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}