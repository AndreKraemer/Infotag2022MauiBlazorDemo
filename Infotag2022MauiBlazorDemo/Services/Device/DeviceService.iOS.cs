namespace Infotag2022MauiBlazorDemo.Services.Device;

public class DeviceService
{
    public string GetDeviceName()
    {
        return UIKit.UIDevice.CurrentDevice.Name;
    }
}
