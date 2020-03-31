using Csharp_design_pattern.DecoratorPattern;
using Csharp_design_pattern.FatoryPattern;
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
            Console.WriteLine();

            ObserverPatternTest observerPattern = new ObserverPatternTest();
            observerPattern.WeatherStation();
            Console.WriteLine();

            DecoratorPatternTest decoratorPattern = new DecoratorPatternTest();
            decoratorPattern.StarBuzzCoffee();
            Console.WriteLine();

            FactoryPatternTest factoryPattern = new FactoryPatternTest();
            factoryPattern.BuyCheesePizza();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
