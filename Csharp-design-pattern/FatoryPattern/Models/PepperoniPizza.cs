using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_design_pattern.FatoryPattern.Models
{
    class PepperoniPizza : Pizza
    {
        public override void Bake()
        {
            Console.WriteLine("Baking pepperoni pizza");
        }

        public override void Box()
        {
            Console.WriteLine("Boxing pepperoni pizza");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting pepperoni pizza");
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing pepperoni pizza");
        }
    }
}
