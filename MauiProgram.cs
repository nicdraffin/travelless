﻿using Microsoft.Extensions.Logging;
using travelless.Components.Data;

namespace travelless
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

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
        public static void ConfigureServices(IServiceCollection services)
        {
            // ... other services ...

            services.AddSingleton<FlightManager>();
        }
    }
}
