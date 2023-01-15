using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy1
{
    public class FirstNation : INation
    {
        public void Shout()
        {
            Console.WriteLine("I'm from First Nation!");
        }
    }
}
