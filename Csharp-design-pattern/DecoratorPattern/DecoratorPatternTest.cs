using Csharp_design_pattern.DecoratorPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_design_pattern.DecoratorPattern
{
    class DecoratorPatternTest
    {
        public void StarBuzzCoffee()
        {
            Beverage espresso = new Espresso();
            Console.WriteLine(espresso.GetDescription() + " $" + espresso.Cost());

            Beverage houseBlend = new HouseBlend();
            houseBlend = new Soy(houseBlend);
            houseBlend = new Mocha(houseBlend);
            houseBlend = new Whip(houseBlend);
            Console.WriteLine(houseBlend.GetDescription() + " $" + houseBlend.Cost());
        }
    }
}
