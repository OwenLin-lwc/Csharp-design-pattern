using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_design_pattern.StrategyPattern.Interfaces
{
    public interface IFlyBehavior
    {
        void Fly();
    }

    public class FlyWithWings :　IFlyBehavior
    {
        void IFlyBehavior.Fly()
        {
            Console.WriteLine("I'm Flying");
        }
    }

    public class FlyNoWay : IFlyBehavior
    {
        void IFlyBehavior.Fly()
        {
            Console.WriteLine("I can't flying");
        }
    }

    public class FlyRocketPowered : IFlyBehavior
    {
        void IFlyBehavior.Fly()
        {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }
}
