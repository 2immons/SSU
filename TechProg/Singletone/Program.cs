using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main()
        {
            ZombieBuilder zombieBuilder = new ZombieBuilder();
            BaseUnit baseUnit = new BaseUnit(zombieBuilder);
            baseUnit.CreateUnit();

            ArcherBuilder archerBuilder = new ArcherBuilder();
            BaseUnit baseUnit1 = new BaseUnit(archerBuilder);
            baseUnit1.CreateUnit();
        }
    }
}
