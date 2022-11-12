namespace CVasApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private async void OnProfileButtonClickedAsync(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Profile");
    }

    private async void OnExpButtonClickedAsync(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Exp");
    }
}

