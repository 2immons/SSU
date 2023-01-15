using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    public class VendingMachine
    {
        private Dictionary<DrinkType, IDrink> drinks = new Dictionary<DrinkType, IDrink>();

        public IDrink SelectDrink(DrinkType type)
        {
            if (drinks.ContainsKey(type))
                return drinks[type];
            else
            {
                IDrink drink = MakeDrink(type);
                drinks[type] = drink;
                return drink;
            }
        }
        private IDrink MakeDrink(DrinkType type)
        {
            IDrink drink = null;
            if (type == DrinkType.Coffee)
                drink = new Coffee();
            else if (type == DrinkType.Tea)
                drink = new Tea();
            return drink;
        }

    }
}
