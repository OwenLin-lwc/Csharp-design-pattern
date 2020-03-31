using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_design_pattern.FatoryPattern.Models
{
    class VeggiePizza : Pizza
    {
        public override void Bake()
        {
            Console.WriteLine("Baking veggie pizza");
        }

        public override void Box()
        {
            Console.WriteLine("Boxing veggie pizza");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting veggie pizza");
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing veggie pizza");
        }
    }
}
