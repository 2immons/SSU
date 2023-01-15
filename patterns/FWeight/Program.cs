using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    public class Program
    {
        public static void Main()
        {
            VendingMachine machine = new VendingMachine();
            
            IDrink drink = machine.SelectDrink(DrinkType.Coffee);
            
            drink.BuyDrink();
        }
    }
}
