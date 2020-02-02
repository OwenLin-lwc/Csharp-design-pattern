using Csharp_design_pattern.StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_design_pattern.StrategyPattern.Models
{
    public class Queen : Character
    {
        public Queen()
        {
            SetWeapon(new SwordBehavior());
        }
    }
}
