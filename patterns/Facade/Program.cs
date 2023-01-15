using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Program
    {
        public static void Main()
        {
            CarFacade car = new CarFacade();
            car.StartCar();
            car.TurnOffCar();
        }
    }
}
