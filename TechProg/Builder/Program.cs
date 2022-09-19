using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            GermanyCountry germany = new GermanyCountry(100, 100, 100);
            SovietUninonCountry sovietUnion = new SovietUninonCountry(100, 100, 100);

            Console.WriteLine("Запасы Германии сейчас:");
            Console.Write($"\tЕды: {germany.Food}, стали: {germany.Steel}, патронов: {germany.Ammo}\n");

            Console.WriteLine("Запасы СССР сейчас:");
            Console.Write($"\tЕды: {sovietUnion.Food}, стали: {sovietUnion.Steel}, патронов: {sovietUnion.Ammo}\n");

            Console.WriteLine();

            Console.Write("Сколько артиллерии на рельсах создать Германии? : ");
            int n = int.Parse(Console.ReadLine());
            germany.CreateArt(n);

            Console.Write("Сколько танков создать Германии? : ");
            n = int.Parse(Console.ReadLine());
            germany.CreateTank(n);

            Console.Write("Сколько солдатов создать Германии? : ");
            n = int.Parse(Console.ReadLine());
            germany.CreateSoldier(n);

            Console.Write("Сколько танков создать СССР? : ");
            n = int.Parse(Console.ReadLine());
            sovietUnion.CreateTank(n);

            Console.Write("Сколько солдатов создать СССР? : ");
            n = int.Parse(Console.ReadLine());
            sovietUnion.CreateSoldier(n);

            Console.WriteLine("\nПринято...\n");

            Console.WriteLine("Запасы Германии сейчас:");
            Console.Write($"\tЕды: {germany.Food}, стали: {germany.Steel}, патронов: {germany.Ammo}\n");
            Console.Write($"\tТанков: {germany.Tanks}, солдатов: {germany.Soldiers}\n");

            Console.WriteLine("Запасы СССР сейчас:");
            Console.Write($"\tЕды: {sovietUnion.Food}, стали: {sovietUnion.Steel}, патронов: {sovietUnion.Ammo}\n");
            Console.Write($"\tТанков: {sovietUnion.Tanks}, солдатов: {sovietUnion.Soldiers}\n");
        }
    }
}
