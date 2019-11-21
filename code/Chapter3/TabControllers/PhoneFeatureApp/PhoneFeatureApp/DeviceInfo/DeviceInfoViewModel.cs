﻿using System;
using MVVMBase;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace PhoneFeatureApp.DeviceInfo
{
    public class DeviceInfoViewModel : ViewModelCommon
    {
        // Device Model
        private readonly string _device = Xamarin.Essentials.DeviceInfo.Model;
        public string Device => _device;

        // Manufacturer
        private readonly string _manufacturer = Xamarin.Essentials.DeviceInfo.Manufacturer;
        public string Manufacturer => _manufacturer;

        // Device Name 
        private readonly string _deviceName = Xamarin.Essentials.DeviceInfo.Name;
        public string DeviceName => _deviceName;

        // Operating System Version Number (7.0)
        private readonly string _version = Xamarin.Essentials.DeviceInfo.VersionString;
        public string Version => _version;

        // Platform 
        private readonly DevicePlatform _platform = Xamarin.Essentials.DeviceInfo.Platform;
        public string Platform => _platform.ToString();

        // Idiom (type of device)
        private readonly DeviceIdiom _idiom = Xamarin.Essentials.DeviceInfo.Idiom;
        public string Idiom => _idiom.ToString();

        // Device Type 
        private readonly DeviceType _deviceType = Xamarin.Essentials.DeviceInfo.DeviceType;
        public string DeviceType => _deviceType.ToString();

        public DeviceInfoViewModel()
        {
            subscribeToBackgroundColChange();
        }

        
    }
}
