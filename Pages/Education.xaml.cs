namespace CVasApp;
using Microsoft.Maui.Controls;

/// <summary>
/// Education Page code behind
/// </summary>
public partial class Education : ContentPage
{
    Border lastselected;
    public Education()
    {
        InitializeComponent();
    }


    /// <summary>
    /// Go back one page
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

        /* Unmerged change from project 'CVasApp (net7.0-windows10.0.19041.0)'
        Before:
                Border nowselected = (sender) as Border;  // Get clicked list item

                if (lastselected != null)   // Is there onother item selected? If yes perform closing animation
        After:
                Border nowselected = (sender) as Border;  // Get clicked list item

                if (lastselected != null)   // Is there onother item selected? If yes perform closing animation
        */

        /* Unmerged change from project 'CVasApp (net7.0-maccatalyst)'
        Before:
                Border nowselected = (sender) as Border;  // Get clicked list item

                if (lastselected != null)   // Is there onother item selected? If yes perform closing animation
        After:
                Border nowselected = (sender) as Border;  // Get clicked list item

                if (lastselected != null)   // Is there onother item selected? If yes perform closing animation
        */

        /* Unmerged change from project 'CVasApp (net7.0-android33.0)'
        Before:
                Border nowselected = (sender) as Border;  // Get clicked list item

                if (lastselected != null)   // Is there onother item selected? If yes perform closing animation
        After:
                Border nowselected = (sender) as Border;  // Get clicked list item

                if (lastselected != null)   // Is there onother item selected? If yes perform closing animation
        */
        Border nowselected = (sender) as Border;  // Get clicked list item

        if (lastselected != null)   // Is there onother item selected? If yes perform closing animation
        {
            lastselected.StrokeThickness = 1;
            lastselected.Scale = 1;
            for (int i = 150; i > 90; i = i - 10)
            {
                lastselected.HeightRequest = i;
                await Task.Delay(1);   // Not actually 1ms, it takes more due to processing but just enough to be useful
            }
            lastselected.HeightRequest = 90;
        }
        if (nowselected == lastselected)  // Did the user select the same cell? If yes break  
        {
            lastselected = null;  // Reset selections to none
            return;  // Break
        }

        //Perform opening animation
        nowselected.StrokeThickness = 6;
        await nowselected.ScaleTo(1.15);
        for (int i = 90; i < 150; i = i + 4)
        {
            nowselected.HeightRequest = i;
            await Task.Delay(1);
        }
        lastselected = nowselected;  //store this cell as the one selected
    }
}