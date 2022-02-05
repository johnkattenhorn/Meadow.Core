﻿using System;
using Meadow.Hardware;

namespace Meadow.Devices
{
    public abstract partial class F7MicroBase
    {
        /// <summary>
        /// Creates a SPI bus instance for the requested bus speed with the Meadow- default IPins for CLK, COPI and CIPO
        /// </summary>
        /// <returns>An instance of an IISpiBus</returns>
        public ISpiBus CreateSpiBus()            
        {
            return CreateSpiBus(IMeadowDevice.DefaultSpiBusSpeed);
        }

        public ISpiBus CreateSpiBus(
            Units.Frequency speed
        )
        {
            return CreateSpiBus(Pins.SCK, Pins.COPI, Pins.CIPO, speed);
        }

        /// <summary>
        /// Creates a SPI bus instance for the requested control pins and bus speed
        /// </summary>
        /// <param name="pins">IPin instances used for (in this order) CLK, COPI, CIPO</param>
        /// <param name="speed">The bus speed (in kHz)</param>
        /// <returns>An instance of an IISpiBus</returns>
        public ISpiBus CreateSpiBus(
            IPin[] pins,
            Units.Frequency speed
        )
        {
            return CreateSpiBus(pins[0], pins[1], pins[2], speed);
        }

        public ISpiBus CreateSpiBus(
            IPin clock,
            IPin copi,
            IPin cipo
        )
        {
            return CreateSpiBus(clock, copi, cipo, IMeadowDevice.DefaultSpiBusSpeed);
        }

        /// <summary>
        /// Creates a SPI bus instance for the requested control pins and bus speed
        /// </summary>
        /// <param name="clock">The IPin instance to use as the bus clock</param>
        /// <param name="copi">The IPin instance to use for data transmit (controller out/peripheral in)</param>
        /// <param name="cipo">The IPin instance to use for data receive (controller in/peripheral out)</param>
        /// <param name="speed">The bus speed</param>
        /// <returns>An instance of an IISpiBus</returns>
        public ISpiBus CreateSpiBus(
            IPin clock,
            IPin copi,
            IPin cipo,
            Units.Frequency speed
        )
        {
            var bus = SpiBus.From(clock, copi, cipo);
            bus.BusNumber = GetSpiBusNumberForPins(clock, copi, cipo);
            bus.Configuration.Speed = speed;
            return bus;
        }

        /// <summary>
        /// Creates a SPI bus instance for the requested control pins and bus speed
        /// </summary>
        /// <param name="clock">The IPin instance to use as the bus clock</param>
        /// <param name="copi">The IPin instance to use for data transmit (controller out/peripheral in)</param>
        /// <param name="cipo">The IPin instance to use for data receive (controller in/peripheral out)</param>
        /// <param name="config">The bus clock configuration parameters</param>
        /// <returns>An instance of an IISpiBus</returns>
        public ISpiBus CreateSpiBus(
            IPin clock,
            IPin copi,
            IPin cipo,
            SpiClockConfiguration config
        )
        {
            var bus = SpiBus.From(clock, copi, cipo);
            bus.BusNumber = GetSpiBusNumberForPins(clock, copi, cipo);
            bus.Configuration = config;
            return bus;
        }

        protected int GetSpiBusNumberForPins(IPin clock, IPin copi, IPin cipo)
        {
            // we're only looking at clock pin.  
            // For the F7 meadow it's enough to know and any attempt to use other pins will get caught by other sanity checks
            // HACK NOTE: can't compare directly here, so we're comparing the name.
            // might be able to cast and compare?
            if (clock.Name == (Pins as IF7MicroPinout)?.ESP_CLK.Name) {
                return 2;
            } else if (clock.Name == (Pins as IF7MicroPinout)?.SCK.Name) {
                return 3;
            }

            // this is an unsupported bus, but will get caught elsewhere
            return -1;
        }
    }
}
