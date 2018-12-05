using System;
using System.Collections;
using System.Collections.Generic;

namespace Amethyst.Domain.Devices
{
    public class BaseHub
    {
        private List<IBaseDevice> _devices;

        public BaseHub()
        {
            _devices = new List<IBaseDevice>();
        }

        public void RegisterDevice(IBaseDevice device)
        {
            _devices.Add(device);
        }
    }
}
