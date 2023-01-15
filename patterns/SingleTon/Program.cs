using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon
{
    public class Program
    {
        public static void Main()
        {
            Ship ship = Ship.Instance("Titanic");
            ship.ShowInfo();

            ship = Ship.Instance("Bismark");
            ship.ShowInfo();
        }
    }
}
