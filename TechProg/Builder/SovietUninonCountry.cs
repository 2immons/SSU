using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class SovietUninonCountry : Country
    {
        public SovietUninonCountry(int steel, int food, int ammo) : base(steel, food, ammo)
        {
            Steel = steel;
            Food = food;
            Ammo = ammo;
        }

        public override void CreateSoldier(int n)
        {
            this.Food = Food - n;
            this.Ammo = Ammo - n;
            this.Soldiers = Soldiers + n;
            Console.WriteLine($"Созданы солдаты в количестве: {n}. На это затрачено: {2 * n} еды, {2 * n} патрона");
        }

        public override void CreateTank(int n)
        {
            this.Steel = Steel - 2 * n;
            this.Ammo = Ammo - 2 * n;
            this.Tanks = Tanks + n;
            Console.WriteLine($"Созданы танки в количестве: {n}. На это затрачено: {2 * n} стали, {2 * n} патрона");
        }
    }
}
