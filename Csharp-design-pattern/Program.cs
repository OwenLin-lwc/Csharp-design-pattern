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
            // Strategy Pattern
            StrategyPatternTest strategyPattern = new StrategyPatternTest();
            strategyPattern.MiniDuckSimulator();
            strategyPattern.RPGSimulator();

            Console.ReadLine();
        }
    }
}
