using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class GermanyCountry : Country
    {
        public GermanyCountry(int steel, int food, int ammo) : base(steel, food, ammo)
        {
            Steel = steel;
            Food = food;
            Ammo = ammo;
        }

        public override void CreateArt(int n)
        {
            this.Steel = Steel - 5 * n;
            this.Ammo = Ammo - 5 * n;
            this.Soldiers = Soldiers + n;
            Console.WriteLine($"Создана артиллерия на рельсах в количестве: {n}. На это затрачено: {5 * n} стали, {5 * n} патрона");
        }

        public override void CreateSoldier(int n)
        {
            this.Food = Food - 2 * n;
            this.Ammo = Ammo - 2 * n;
            this.Soldiers = Soldiers + n;
            Console.WriteLine($"Созданы солдаты в количестве: {n}. На это затрачено: {2*n} еды, {2 * n} патрона");
        }

        public override void CreateTank(int n)
        {
            this.Steel = Steel - 3 * n;
            this.Ammo = Ammo - 2 * n;
            this.Tanks = Tanks + n;
            Console.WriteLine($"Созданы танки в количестве: {n}. На это затрачено: {3 * n} стали, {2 * n} патрона");
        }
    }
}
