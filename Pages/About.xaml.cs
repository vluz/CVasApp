namespace CVasApp;

/// <summary>
/// About Page code behind
/// </summary>

public partial class About : ContentPage
{
    public About()
    {
        InitializeComponent();
    }



    /// <summary>
    /// Navigate one level, pop last page
    /// </summary>
    private async void OnBackButtonClickedAsync(object sender, EventArgs e)
    {
        await BackButton.ScaleTo(0.8, 70, Easing.Linear);
        await BackButton.ScaleTo(1, 50, Easing.Linear);
        await Shell.Current.GoToAsync("..");
    }
}