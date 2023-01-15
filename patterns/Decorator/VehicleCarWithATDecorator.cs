using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class vehicleCarWithATDecorator : IVehicle
    {
        protected IVehicle vehicle;
        public vehicleCarWithATDecorator(IVehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        public string ShowPrice() => (vehicle.ShowPrice() + " + 100.000 for Sport");
    }
}
