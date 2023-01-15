using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    public class Coffee : IDrink
    {
        public void BuyDrink()
        {
            Console.WriteLine("Your coffee");
        }
    }
}
