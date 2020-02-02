using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_design_pattern.StrategyPattern.Interfaces
{
    public interface IWeaponBehavior
    {
        void UseWeapon();
    }

    public class KnifeBehavior : IWeaponBehavior
    {
        void IWeaponBehavior.UseWeapon()
        {
            Console.WriteLine("Poking the knife");
        }
    }

    public class BowAndArrowBehavior : IWeaponBehavior
    {
        void IWeaponBehavior.UseWeapon()
        {
            Console.WriteLine("Shooting");
        }
    }

    public class AxeBehavior : IWeaponBehavior
    {
        void IWeaponBehavior.UseWeapon()
        {
            Console.WriteLine("Waving the axe");
        }
    }

    public class SwordBehavior : IWeaponBehavior
    {
        void IWeaponBehavior.UseWeapon()
        {
            Console.WriteLine("Waving the sword");
        }
    }
}
