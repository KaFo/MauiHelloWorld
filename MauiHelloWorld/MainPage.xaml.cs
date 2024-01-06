using FFmpeg.AutoGen.Abstractions;

namespace MauiHelloWorld;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
#if !NO_AUTOGEN
        var intVersion = ffmpeg.avcodec_version();
        LblHello.Text = "Hello FFmpeg " + ToVersion(intVersion);
#endif        
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
    
    private static Version ToVersion(uint v)
    {
        return new Version((int)v >> 16, (int)((v >> 8) & 0xff), (int)(v & 0xff));
    }

}

