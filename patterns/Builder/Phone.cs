using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Phone
    {
        public string name;
        public int price;

        public void PrintInfo()
        {
            if (name != null)
                Console.WriteLine(name);
            if (price != 0)
                Console.WriteLine(price);
        }
    }
}
