using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Car : IVehicle
    {
        public string ShowPrice() => "300.000 for car";
    }
}
