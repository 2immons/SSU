using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class ArcherBuilder : UnitBuilder
    {
        override public void SetType()
        {
            unit.Type = "Archer";
        }
        override public void SetAttack(int x)
        {
            unit.Attack = x;
        }
        override public void SetDefence(int x)
        {
            unit.Defence = x;
        }
        override public void SetLongDistAttack(int x)
        {
            unit.LongDistAttack = x;
        }
        override public void GetUnit()
        {
            Console.WriteLine($"{unit.Type} has: attack = {unit.Attack}, defence = {unit.Defence} and long distance attack = {unit.LongDistAttack}");
        }
    }
}
