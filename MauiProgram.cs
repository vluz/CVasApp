namespace CVasApp;
using CommunityToolkit.Maui;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();

			builder.UseMauiApp<App>();

            builder.UseMauiCommunityToolkit();
			
			builder.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("Font Awesome 6 Brands-Regular-400.otf", "FontBrands");
				fonts.AddFont("Font Awesome 6 Free-Regular-400.otf", "FontRegular");
				fonts.AddFont("Font Awesome 6 Free-Solid-900.otf", "FontSolid");
				fonts.AddFont("simplifica.ttf", "FontSimplifica");
                //fonts.AddFont("", "Font");
                fonts.AddFont("CooperHewitt-Light.otf", "FontCHLight");
                fonts.AddFont("CooperHewitt-Medium.otf", "FontCHMedium");
                fonts.AddFont("CooperHewitt-Semibold.otf", "FontCHBold");
            });

		return builder.Build();
	}
}
