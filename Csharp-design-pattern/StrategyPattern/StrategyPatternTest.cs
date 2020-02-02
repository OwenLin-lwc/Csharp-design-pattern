using Csharp_design_pattern.StrategyPattern.Interfaces;
using Csharp_design_pattern.StrategyPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_design_pattern.StrategyPattern
{
    public class StrategyPatternTest
    {
        public void MiniDuckSimulator()
        {
            Duck mallard = new MallardDuck();
            mallard.Display();
            mallard.PerformFly();
            mallard.PerformQuack();

            Duck model = new ModelDuck();
            mallard.Display();
            mallard.PerformFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            mallard.PerformQuack();
        }
        public void RPGSimulator()
        {
            Character queen = new Queen();
            queen.Fight();
            queen.SetWeapon(new BowAndArrowBehavior());
            queen.Fight();
        }
    }
}
