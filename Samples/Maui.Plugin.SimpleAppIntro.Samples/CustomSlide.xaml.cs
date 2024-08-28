using Maui.Plugin.SimpleAppIntro.Interface;

namespace Maui.Plugin.SimpleAppIntro.Samples;

public partial class CustomSlide : ContentView, IValidate, ISave
{
    public CustomSlide()
    {
        InitializeComponent();
    }
    
    public void Save()
    {
        Console.Write("Data Saved");
    }

    public bool Validate()
    {
        return true;
    }
}