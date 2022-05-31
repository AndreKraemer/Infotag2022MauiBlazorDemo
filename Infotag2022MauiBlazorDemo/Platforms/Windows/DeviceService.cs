namespace Infotag2022MauiBlazorDemo;

public class DeviceService
{
    public string GetDeviceName()
    {
        var deviceInformation = new Windows.Security.ExchangeActiveSyncProvisioning.EasClientDeviceInformation();
        return deviceInformation.FriendlyName;
    }
}
