using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class PhoneBuilder
    {
        Phone phone = new Phone();
        public PhoneBuilder SetName(string name)
        {
            phone.name = name;
            return this;
        }

        public PhoneBuilder SetPrice(int price)
        {
            phone.price = price;
            return this;
        }

        public Phone Build()
        {
            return phone;
        }
    }
}
