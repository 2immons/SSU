using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class vehicleCarSportDecorator : IVehicle
    {
        protected IVehicle vehicle;
        public vehicleCarSportDecorator(IVehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        public string ShowPrice() => (vehicle.ShowPrice() + " + 50.000 for AT");
    }
}
