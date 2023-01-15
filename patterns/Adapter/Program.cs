using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Program
    {
        static public void Main()
        {
            OldPhoneAdapter oldPhone = new OldPhoneAdapter();
            SmartPhone smartPhone = new SmartPhone();

            oldPhone.Messenger();
            smartPhone.Messenger();
        }
    }
}
