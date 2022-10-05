using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class BaseUnit
    {
        UnitBuilder unitBuilder;

        public BaseUnit(UnitBuilder unitBuilder)
        {
            this.unitBuilder = unitBuilder;
        }

        public void CreateUnit()
        {
            unitBuilder.SetType();
            unitBuilder.SetDefence(10);
            unitBuilder.SetAttack(10);
            unitBuilder.SetLongDistAttack(0);
            unitBuilder.GetUnit();
        }
    }
}
