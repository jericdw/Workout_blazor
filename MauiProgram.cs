using Microsoft.Extensions.Logging;
using Workout_blazor.Data;
using Workout_blazor.Models;
using Workout_blazor.ViewModel;

namespace Workout_blazor
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
            builder.Services.AddSingleton(new ExerciseRepository("exercises.db"));
            builder.Services.AddScoped<MainPage>();
            builder.Services.AddTransient<WebContentPage>();
            builder.Services.AddTransient<WebContentViewModel>();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<WeatherForecastService>();

            return builder.Build();
        }
    }
}