namespace Infotag2022MauiBlazorDemo;

public class DeviceService
{
    public string GetDeviceName()
    {
        return UIKit.UIDevice.CurrentDevice.Name;
    }
}
