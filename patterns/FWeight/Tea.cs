using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    public class Tea : IDrink
    {
        public void BuyDrink()
        {
            Console.WriteLine("Your tea");
        }
    }
}
