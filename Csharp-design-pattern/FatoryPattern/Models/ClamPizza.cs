using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_design_pattern.FatoryPattern.Models
{
    class ClamPizza : Pizza
    {
        public override void Bake()
        {
            Console.WriteLine("Baking clam pizza");
        }

        public override void Box()
        {
            Console.WriteLine("Boxing clam pizza");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting clam pizza");
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing clam pizza");
        }
    }
}
