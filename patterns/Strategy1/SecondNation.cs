using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy1
{
    public class SecondNation : INation
    {
        public void Shout()
        {
            Console.WriteLine("I'm from Second Nation!");
        }
    }
}
