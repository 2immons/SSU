using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Program
    {
        public static void Main()
        {
            IVehicle car = new Car();
            IVehicle carSportWithAT = new vehicleCarSportDecorator(new vehicleCarWithATDecorator(car));

            Console.WriteLine(car.ShowPrice());
            Console.WriteLine(carSportWithAT.ShowPrice());
        }
    }
}
