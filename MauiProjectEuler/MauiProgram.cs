using MauiProjectEuler.Data;
using Microsoft.AspNetCore.Components.WebView.Maui;

namespace MauiProjectEuler
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();

            builder.Services.AddSingleton<WeatherForecastService>();

            return builder.Build();
        }
    }
}