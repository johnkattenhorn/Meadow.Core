﻿using System;
using Meadow;
using Meadow.Bases;
using Meadow.Units;

namespace CompositeTest
{
    //public class Bmp180 : FilterableChangeObservableBase<AtmosphericConditionChangeResult, AtmosphericConditions>,
    //    IAtmosphericSensor, IBarometricPressureSensor, ITemperatureSensor

    public class BME999 :
        FilterableChangeObservable<CompositeChangeResult<Mass, Pressure, Temperature>, Mass, Pressure, Temperature>
      //  , IBarometricPressureSensor, ITemperatureSensor
    {
        public float Pressure => 100;

        public float Temperature => 50;

        public float Mass => 0;

        public event EventHandler<CompositeChangeResult<Mass, Pressure, Temperature>> Updated;

        public IDisposable Subscribe(IObserver<CompositeChangeResult<Mass, Pressure, Temperature>> observer)
        {
            throw new NotImplementedException();
        }

        /*
        public FilterableChangeObserver<CompositeChangeResult<Mass, Pressure, Temperature>,
                (Mass, Pressure, Temperature)> 
            GetObserver(Action<CompositeChangeResult<Mass, Pressure, Temperature>> handler, 
                        Predicate<CompositeChangeResult<Mass, Pressure, Temperature>> filter = null)
        {
            return new FilterableChangeObserver<CompositeChangeResult<Mass, Pressure, Temperature>,
                (Mass, Pressure, Temperature)>
            (handler, filter);
        }*/
    }
}
