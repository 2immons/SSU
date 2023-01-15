using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Program
    {
        public static void Main()
        {
            PhoneBuilder phoneBuilder = new PhoneBuilder();
            phoneBuilder.SetName("Samsung");
            Phone phone = phoneBuilder.Build();
            phone.PrintInfo();

            Console.WriteLine();

            phoneBuilder.SetPrice(13000);
            phone = phoneBuilder.Build();
            phone.PrintInfo();
        }
    }
}
