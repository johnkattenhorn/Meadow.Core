﻿using System;
namespace Meadow.Hardware
{
    public interface ICanChannel : IDigitalChannel, ISerialCommunicationChannel
    {
        //TODO: what else should this have? allowed speeds?
        // what does it share with the other digital comm protocols?
        // if it does, we need an IDigitalCommunicationProtocol or something?
    }
}
