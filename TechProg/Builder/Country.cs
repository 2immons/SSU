using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Country
    {
        public int Steel { get; set; }
        public int Food { get; set; }
        public int Ammo { get; set; }
        virtual public int Art { get; set; }
        public int Soldiers { get; set; }
        public int Tanks { get; set; }

        public Country(int steel, int food, int ammo)
        {
            Steel = steel;
            Food = food;
            Ammo = ammo;
        }

        virtual public void CreateArt(int n) { }
        virtual public void CreateSoldier(int n) { }
        virtual public void CreateTank(int n) { }
    }
}
