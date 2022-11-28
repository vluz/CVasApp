namespace CVasApp;

public partial class Cert : ContentPage
{
    Border lastselected;
    public Cert()
    {
        InitializeComponent();
    }

    private async void OnBackButtonClickedAsync(object sender, EventArgs e)
    {
        await BackButton.ScaleTo(0.8, 70, Easing.Linear);
        await BackButton.ScaleTo(1, 50, Easing.Linear);
        await Shell.Current.GoToAsync("..");
    }

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