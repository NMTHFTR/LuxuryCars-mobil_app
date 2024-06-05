using LuxuryCars.ViewModels;
using LuxuryCars.Views;
using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;
using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Maps;

namespace LuxuryCars
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkitMediaElement()
                .UseMauiCommunityToolkit()
                .UseMauiCommunityToolkitMaps("AvDFMHHaEJW-k6PvsePZdAT8cJgk8InoM6xGBoDIOepMF_0tuY82P3HJ_idTHjPk")
                .ConfigureSyncfusionCore()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("fa_solid.ttf", "FontAwesome");
                });
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainPageViewModel>();
            builder.Services.AddSingleton<CarsPage>();
            builder.Services.AddSingleton<CarViewModel>();
            builder.Services.AddSingleton<CarDetailsPage>();
            builder.Services.AddSingleton<CarDetailsViewModel>();
            builder.Services.AddSingleton<SearchByName>();
            builder.Services.AddSingleton<SearchByNameViewModel>();
            builder.Services.AddSingleton<Speedometer>();
            builder.Services.AddSingleton<Rolunk>();
            builder.Services.AddSingleton<Fotok>();
         

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}