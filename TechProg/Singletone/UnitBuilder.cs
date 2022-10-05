using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class UnitBuilder
    {
        protected Unit unit = new Unit();
        virtual public void SetType() { }
        virtual public void SetAttack(int x) { }
        virtual public void SetDefence(int x) { }
        virtual public void SetLongDistAttack(int x) { }
        virtual public void GetUnit() { }
    }
}
