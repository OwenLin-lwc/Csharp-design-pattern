using Csharp_design_pattern.FatoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_design_pattern.FatoryPattern
{
    class FactoryPatternTest
    {
        public void BuyCheesePizza()
        {
            SimplePizzaFactory factory = new SimplePizzaFactory();
            PizzaStore store = new PizzaStore(factory);
            Pizza cheesePizza = store.OrderPizza("cheese");
            Pizza clamPizza = new PizzaStore(new SimplePizzaFactory()).OrderPizza("clam");
        }
    }
}
