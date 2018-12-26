﻿using System;
namespace Meadow.Gateways.Bluetooth
{
    public class BluetoothAdapter
    {
        public string DeviceID { get; protected set; }
        public ulong Address { get; protected set; }
        public AdapterCapabilities Capabilities { get; set; }

        public BluetoothAdapter(string deviceID, ulong address, AdapterCapabilities capabilities)
        {
            this.DeviceID = deviceID;
            this.Address = address;
            this.Capabilities = capabilities;
        }
    }
}