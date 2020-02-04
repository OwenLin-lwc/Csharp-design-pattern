using Csharp_design_pattern.ObserverPattern;
using Csharp_design_pattern.StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_design_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            StrategyPatternTest strategyPattern = new StrategyPatternTest();
            strategyPattern.MiniDuckSimulator();
            strategyPattern.RPGSimulator();

            ObserverPatternTest observerPattern = new ObserverPatternTest();
            observerPattern.WeatherStation();

            Console.ReadLine();
        }
    }
}
