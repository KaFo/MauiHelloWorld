// ReSharper disable InconsistentNaming

#if __MACCATALYST__
using ObjCRuntime;

[assembly: LinkWith("libavutil.a", LinkTarget.Arm64 | LinkTarget.x86_64, SmartLink = true, ForceLoad = true)]

[assembly: LinkWith("libavcodec.a", LinkTarget.Arm64 | LinkTarget.x86_64, SmartLink = true, ForceLoad = true)]

//problems with bzip2 functions not found
[assembly: LinkWith("libavformat.a", LinkTarget.Arm64 | LinkTarget.x86_64, SmartLink = true, ForceLoad = true)]

[assembly: LinkWith("libavfilter.a", LinkTarget.Arm64 | LinkTarget.x86_64, SmartLink = true, ForceLoad = true)]

[assembly: LinkWith("libavdevice.a", LinkTarget.Arm64 | LinkTarget.x86_64, SmartLink = true, ForceLoad = true)]

[assembly: LinkWith("libswscale.a", LinkTarget.Arm64 | LinkTarget.x86_64, SmartLink = true, ForceLoad = true)]

[assembly: LinkWith("libswresample.a", LinkTarget.Arm64 | LinkTarget.x86_64, SmartLink = true, ForceLoad = true)]

#elif __IOS__
using ObjCRuntime;

[assembly: LinkWith("libavutil.a", LinkTarget.Arm64 | LinkTarget.x86_64| LinkTarget.Simulator64, SmartLink = true, ForceLoad = true)]


[assembly: LinkWith("libavcodec.a", LinkTarget.Arm64 | LinkTarget.x86_64, SmartLink = true, ForceLoad = true)]

//problems with bzip2 functions not found
//[assembly: LinkWith("libavformat.a", LinkTarget.Arm64 | LinkTarget.x86_64, SmartLink = true, ForceLoad = true)]

[assembly: LinkWith("libavfilter.a", LinkTarget.Arm64 | LinkTarget.x86_64, SmartLink = true, ForceLoad = true)]

[assembly: LinkWith("libavdevice.a", LinkTarget.Arm64 | LinkTarget.x86_64, SmartLink = true, ForceLoad = true)]

[assembly: LinkWith("libswscale.a", LinkTarget.Arm64 | LinkTarget.x86_64, SmartLink = true, ForceLoad = true)]

[assembly: LinkWith("libswresample.a", LinkTarget.Arm64 | LinkTarget.x86_64, SmartLink = true, ForceLoad = true)]


#endif