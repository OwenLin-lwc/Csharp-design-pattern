using Csharp_design_pattern.StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_design_pattern.StrategyPattern.Models
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            SetFlyBehavior(new FlyNoWay());
            SetQuackBehavior(new Quack());
        }
        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
