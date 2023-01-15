using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class SmartPhone : IGadget
    {
        public void Messenger()
        {
            Console.WriteLine("Вы вошли в мессенджер!");
        }
    }
}
