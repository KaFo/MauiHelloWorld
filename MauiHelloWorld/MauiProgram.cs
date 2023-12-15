﻿using Microsoft.Extensions.Logging;
using MauiIcons.Material;

namespace MauiHelloWorld;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMaterialMauiIcons()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        
#if DEBUG
		builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
