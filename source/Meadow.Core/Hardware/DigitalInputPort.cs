﻿using System;

namespace Meadow.Hardware
{
    public class DigitalInputPort : DigitalInputPortBase
    {
        public bool GlitchFilter { get; set; }
        public ResistorMode Resistor { get; set; }

        public DigitalInputPort(IDigitalChannel pin, bool glitchFilter, ResistorMode resistorMode)
        {

        }

        public DigitalInputPort()
        {

        }

        public override bool Value => throw new NotImplementedException();
    }
}