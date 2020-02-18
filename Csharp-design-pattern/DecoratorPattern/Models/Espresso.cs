using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_design_pattern.DecoratorPattern.Models
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            _description = "Espresso 2";
        }

        public override double Cost()
        {
            return 2;
        }
    }
}
