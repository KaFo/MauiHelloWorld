#if __IOS__
using Media.FFmpeg.AppleStatic;
#elif __MACCATALYST__    
using Media.FFmpeg.AppleStatic;
#endif

using Microsoft.Extensions.Logging;

namespace MauiHelloWorld;
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
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif
        
#if __IOS__
    //iOS testing code
    AppleStaticCallTest.Test();
#elif __MACCATALYST__    
    AppleStaticCallTest.Test();
#endif

        return builder.Build();
    }
}
