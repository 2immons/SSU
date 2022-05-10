using System;
using Task1_Round.BLL;

namespace Task1_Round.PLL
{
    public class ConsoleInterface
    {
        public static void Start()
        {
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1) Add");
                Console.WriteLine("2) GetAll");
                Console.WriteLine("3) Get");
                Console.WriteLine("4) Update");
                Console.WriteLine("5) Delete");

                Console.Write("Your choice = "); int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.Write("\tRadius: "); int radius = int.Parse(Console.ReadLine());
                        Console.Write("\tCenter x: "); int x = int.Parse(Console.ReadLine());
                        Console.Write("\tCenter y: "); int y = int.Parse(Console.ReadLine());
                        Console.WriteLine(RoundLogicImpl.Create(radius, x, y));
                        break;
                    case 2:
                        Console.WriteLine(String.Join("\n", RoundLogicImpl.FindAll()));
                        break;
                    case 3:
                        Console.Write("\tID: "); int id = int.Parse(Console.ReadLine());
                        Console.WriteLine(RoundLogicImpl.Find(id));
                        break;
                    case 4:
                        Console.Write("\tID: "); id = int.Parse(Console.ReadLine());
                        Console.Write("\tRadius: "); radius = int.Parse(Console.ReadLine());
                        Console.Write("\tCenter x: "); x = int.Parse(Console.ReadLine());
                        Console.Write("\tCenter y: "); y = int.Parse(Console.ReadLine());
                        Console.WriteLine(RoundLogicImpl.Update(id, radius, x, y));
                        break;
                    case 5:
                        Console.Write("\tID: "); id = int.Parse(Console.ReadLine());
                        Console.WriteLine(RoundLogicImpl.Delete(id));
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
