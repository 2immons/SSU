using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy1
{
    internal class Program
    {
        static void Main()
        {
            Human h1 = new Human(new FirstNation());
            Human h2 = new Human(new FirstNation());

            Console.WriteLine(h1.M);
        }
    }
}
