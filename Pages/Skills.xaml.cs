namespace CVasApp;

/// <summary>
/// Skills Page code behind
/// </summary>

public partial class Skills : ContentPage
{
    Border lastselected;
    public Skills()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Go one page back
    /// </summary>
    private async void OnBackButtonClickedAsync(object sender, EventArgs e)
    {
        await BackButton.ScaleTo(0.8, 70, Easing.Linear);
        await BackButton.ScaleTo(1, 50, Easing.Linear);
        await Shell.Current.GoToAsync("..");
    }


    /// <summary>
    /// performs animations when a item on the list is touched
    /// </summary>
    private async void OnTapGestureRecognizerTapped(object sender, TappedEventArgs e)
    {
        Border nowselected = (sender) as Border;
        if (lastselected != null)
        {
            lastselected.StrokeThickness = 1;
            lastselected.Scale = 1;
            for (int i = 150; i > 90; i = i - 10)
            {
                lastselected.HeightRequest = i;
                await Task.Delay(1);
            }
            lastselected.HeightRequest = 90;
        }
        if (nowselected == lastselected)
        {
            lastselected = null;
            return;
        }

        nowselected.StrokeThickness = 6;
        await nowselected.ScaleTo(1.15);
        for (int i = 90; i < 150; i = i + 4)
        {
            nowselected.HeightRequest = i;
            await Task.Delay(1);
        }
        lastselected = nowselected;
    }
}