using SkiaSharp.Views.Maui.Controls.Hosting;

namespace Maui.Plugin.SimpleAppIntro;

public static class MauiAppBuilderExtensions
{
    public static MauiAppBuilder UseSimpleAppIntro(this MauiAppBuilder self)
    {
        self.UseSkiaSharp();
        return self;
    }
}