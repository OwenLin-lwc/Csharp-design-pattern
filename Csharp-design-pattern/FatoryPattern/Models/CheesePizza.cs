﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_design_pattern.FatoryPattern.Models
{
    class CheesePizza : Pizza
    {
        public override void Bake()
        {
            Console.WriteLine("Baking cheese pizza");
        }

        public override void Box()
        {
            Console.WriteLine("Boxing cheese pizza");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting cheese pizza");
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing cheese pizza");
        }
    }
}
