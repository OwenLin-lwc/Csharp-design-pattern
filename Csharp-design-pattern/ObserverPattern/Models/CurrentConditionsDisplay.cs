﻿using Csharp_design_pattern.ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_design_pattern.ObserverPattern.Models
{
    class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float _temperature;
        private float _humidity;
        private readonly ISubject _weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Update(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Current conditions:" + _temperature + "F degrees and " + _humidity + "% humidity");
        }
    }
}
