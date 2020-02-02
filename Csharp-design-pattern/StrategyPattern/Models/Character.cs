using Csharp_design_pattern.StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_design_pattern.StrategyPattern.Models
{
    public abstract class Character
    {
        private IWeaponBehavior weapon;

        public Character()
        {
            weapon = new KnifeBehavior();
        }

        public void Fight()
        {
            weapon.UseWeapon();
        }

        public void SetWeapon(IWeaponBehavior w)
        {
            weapon = w;
        }
    }
}
