namespace CVasApp;

public partial class Options : ContentPage
{
	public Options()
	{
		InitializeComponent();
	}

    private async void OnBackButtonClickedAsync(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

    private async void OnAboutButtonClickedAsync(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("About");
    }
}