﻿using System;
namespace Meadow.Hardware
{
    /// <summary>
    /// Provides a base implementation for an analog pin.
    /// </summary>
    public abstract class AnalogPinBase : PinBase, IAnalogChannel
    {
        protected AnalogPinBase(string name, uint address, byte precision) : base(name, address)
        {
            this.Precision = precision;
        }

        public byte Precision { get; protected set; }
    }
}
