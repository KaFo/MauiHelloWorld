using System.Runtime.InteropServices;
using FFmpeg.AutoGen.Abstractions;
#if !NO_AUTOGEN
using FFmpeg.AutoGen.Bindings.StaticallyLinked;
#endif
using ObjCRuntime;
//using FFmpeg.AutoGen.Bindings.StaticallyLinked;

namespace Media.FFmpeg.AppleStatic;

public static class AppleStaticCallTest
{
    [DllImport("__Internal", EntryPoint = "avutil_version", CallingConvention = CallingConvention.Cdecl,SetLastError = true)]
    public static extern uint avutil_version();

    /// <summary>Return the LIBAVUTIL_VERSION_INT constant.</summary>
    //[DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
    //public static extern uint avutil_version();

    public static uint Test()
    {
        uint v = 0;
        v = avutil_version();
#if !NO_AUTOGEN        
        StaticallyLinkedBindings.Initialize();
        var v2 = ffmpeg.avcodec_version();
#endif
        
#pragma warning disable IDE0059
  //      var v1 = StaticallyLinkedBindings.avutil_version();
  
        //var v2 = StaticallyLinkedBindings.avformat_version();
    //   return v + v2 - v2;

    return v;
    }
}