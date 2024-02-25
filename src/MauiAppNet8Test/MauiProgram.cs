using AndreasReitberger.Shared.Hosting;
using AndreasReitberger.Shared.Syncfusion.Hosting;
using MauiAppNet8Test.ViewModels;
using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;

namespace MauiAppNet8Test
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureSyncfusionCore()
                .InitializeSharedMauiStyles()
                .InitializeSharedSyncfusionStyles()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton(Dispatcher.GetForCurrentThread());

            builder.Services.AddSingleton<MainPageViewModel>();
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<SecondPage>();
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
