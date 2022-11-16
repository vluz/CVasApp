namespace CVasApp;
using CommunityToolkit.Maui;
using Plugin.Maui.Audio;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder.UseMauiApp<App>();

        builder.UseMauiApp<App>().UseMauiCommunityToolkit();

        builder.ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                //fonts.AddFont("", "Font");
                fonts.AddFont("Font Awesome 6 Brands-Regular-400.otf", "FontBrands");
                fonts.AddFont("Font Awesome 6 Free-Solid-900.otf", "FontSolid");

                fonts.AddFont("CooperHewitt-Light.otf", "FontCHLight");
                fonts.AddFont("CooperHewitt-Medium.otf", "FontCHMedium");
            });

        builder.Services.AddSingleton(AudioManager.Current);
        builder.Services.AddTransient<MainPage>();

        return builder.Build();
    }
}
