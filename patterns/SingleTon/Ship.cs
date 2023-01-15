using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon
{
    public class Ship
    {
        protected string name;
        static Ship ship;
        protected Ship(string name)
        {
            this.name = name;
        }

        public static Ship Instance(string name)
        {
            if (ship == null)
                ship = new Ship(name);
            return ship;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{name}");
        }
    }
}
