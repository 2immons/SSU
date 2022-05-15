using System;
using Task1_Round.BLL;
using Task1_Round.Entities;

namespace Task1_Round.PLL
{

    public class ConsoleInterface
    {
        private readonly IRoundLogic roundLogic;

        public ConsoleInterface(IRoundLogic roundLogic)
        {
            this.roundLogic = roundLogic;
        }
        public void Start()
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
                        Point center = new Point(x, y);
                        Console.WriteLine(roundLogic.Create(center, radius));
                        break;
                    case 2:
                        Console.WriteLine(String.Join("\n", roundLogic.FindAll()));
                        break;
                    case 3:
                        Console.Write("\tID: "); int id = int.Parse(Console.ReadLine());
                        Console.WriteLine(roundLogic.Find(id));
                        break;
                    case 4:
                        Console.Write("\tID: "); id = int.Parse(Console.ReadLine());
                        Console.Write("\tRadius: "); radius = int.Parse(Console.ReadLine());
                        Console.Write("\tCenter x: "); x = int.Parse(Console.ReadLine());
                        Console.Write("\tCenter y: "); y = int.Parse(Console.ReadLine());
                        center = new Point(x, y);
                        Console.WriteLine(roundLogic.Update(id, center, radius));
                        break;
                    case 5:
                        Console.Write("\tID: "); id = int.Parse(Console.ReadLine());
                        Console.WriteLine(roundLogic.Delete(id));
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
