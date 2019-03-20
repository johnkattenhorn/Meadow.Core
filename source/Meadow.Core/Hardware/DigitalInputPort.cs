﻿using System;
using System.Linq;

namespace Meadow.Hardware
{
    /// <summary>
    /// Represents a port that is capable of reading digital input.
    /// </summary>
    public class DigitalInputPort : DigitalInputPortBase
    {
        protected IIOController IOController { get; set; }

        public bool GlitchFilter { get; set; }
        public ResistorMode Resistor { get; set; }

        protected DigitalInputPort(
            IPin pin,
            IIOController ioController,
            IDigitalChannelInfo channel,
            bool interruptEnabled = true,
            bool glitchFilter = false,
            ResistorMode resistorMode = ResistorMode.Disabled
            ) : base(pin, channel, interruptEnabled )
        {
            this.IOController = ioController;
            this.IOController.Interrupt += OnInterrupt;

            // attempt to reserve
            var success = DeviceChannelManager.ReservePin(pin, ChannelConfigurationType.DigitalInput);
            if (success.Item1)
            {
                // make sure the pin is configured as a digital output with the proper state
                ioController.ConfigureInput(pin, glitchFilter, resistorMode, interruptEnabled);
            }
            else
            {
                throw new PortInUseException();
            }
        }

        void OnInterrupt(IPin pin)
        {
            if(pin == this.Pin)
            {
                RaiseChanged(true);
            }
        }


        public static DigitalInputPort From(
            IPin pin,
            IIOController ioController,
            bool interruptEnabled = true,
            bool glitchFilter = false,
            ResistorMode resistorMode = ResistorMode.Disabled
            )
        {
            var chan = pin.SupportedChannels.OfType<IDigitalChannelInfo>().FirstOrDefault();
            if (chan != null) {
                //TODO: need other checks here.
                if(interruptEnabled && (!chan.InterrruptCapable)) {
                    throw new Exception("Unable to create input; channel is not capable of interrupts");
                }
                return new DigitalInputPort(pin, ioController, chan, interruptEnabled, glitchFilter, resistorMode);
            } else {
                throw new Exception("Unable to create an output port on the pin, because it doesn't have a digital channel");
            }
        }

        public override void Dispose()
        {
            //TODO: implement full pattern
        }

        public override bool State
        {
            //get => _pin.GPIOManager.GetDiscrete(_pin);
            get => false;
            //protected set { throw new Exception(); }
        }

    }
}