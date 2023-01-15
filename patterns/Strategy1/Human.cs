using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy1
{
    public class Human
    {
        private INation attack;

        public Human(INation attack)
        {
            this.attack = attack;
        }

        public void Shout()
        {
            attack.Shout(); 
        }
    }
}
