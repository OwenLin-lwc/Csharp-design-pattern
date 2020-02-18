using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_design_pattern.DecoratorPattern.Models
{
    public abstract class Beverage
    {
        public string _description = "Unknown Beverage";

        public virtual string GetDescription()
        {
            return _description;
        }

        public abstract double Cost();
    }
}
