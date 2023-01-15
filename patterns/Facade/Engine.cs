using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Engine
    {
        public void StartEngine()
        {
            Console.WriteLine("Engine started");
        }
        public void TurnOffEngine()
        {
            Console.WriteLine("Engine turned off");
        }
    }
}
