﻿using System;
using System.Threading;
using Meadow;

namespace HelloLED
{

    class MainClass
    {
        static IApp _app;

        static void Main(string[] args)
        {
            // instantiate and run new meadow app
            _app = new LEDApp();
            _app.Run();
        }
    }
}