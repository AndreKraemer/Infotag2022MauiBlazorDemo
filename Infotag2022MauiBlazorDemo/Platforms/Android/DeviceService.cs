using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infotag2022MauiBlazorDemo;

public class DeviceService
{
    public string GetDeviceName()
    {
        return Android.OS.Build.Model;
    }
}
