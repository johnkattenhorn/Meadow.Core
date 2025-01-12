﻿using Meadow.Hardware;
using System;
using static Meadow.Gpiod.Interop;

namespace Meadow
{
    public class GpiodDigitalInputPort : DigitalInputPortBase
    {
        private Gpiod Driver { get; }
        private LineInfo Line { get; }

        public override bool State => Line.GetValue();

        internal GpiodDigitalInputPort(
            Gpiod driver,
            IPin pin,
            GpiodDigitalChannelInfo channel,
            ResistorMode resistorMode)
            : base(pin, channel)
        {
            Driver = driver;
            Pin = pin;

            line_request_flags flags = line_request_flags.None;

            if (pin is GpiodPin { } gp)
            {
                Line = Driver.GetLine(gp);
                switch (resistorMode)
                {
                    case ResistorMode.InternalPullUp:
                        flags = line_request_flags.GPIOD_LINE_REQUEST_FLAG_BIAS_PULL_UP;
                        break;
                    case ResistorMode.InternalPullDown:
                        flags = line_request_flags.GPIOD_LINE_REQUEST_FLAG_BIAS_PULL_DOWN;
                        break;
                    default:
                        flags = line_request_flags.GPIOD_LINE_REQUEST_FLAG_BIAS_DISABLE;
                        break;
                }

                Line.RequestInput(flags);

            }
            else
            {
                throw new NativeException($"Pin {pin.Name} does not support GPIOD operations");
            }
        }

        protected override void Dispose(bool disposing)
        {
            Line.Release();
            base.Dispose(disposing);
        }

        public override ResistorMode Resistor
        {
            get => ResistorMode.Disabled;
            set => throw new NotSupportedException("Resistor Mode not supported on this platform");
        }
    }
}
