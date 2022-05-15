using Library.BLL;
using Library.DAL;
using Library.PLL;

namespace Library;

public class Program
{
    static void Main(string[] args)
    {
        IBookRepo bookRepo = new BookInMemoryRepo();
        IBookLogic bookLogic = new BookLogicImpl(bookRepo);
        ConsoleInterface consoleInterface = new ConsoleInterface(bookLogic);
        consoleInterface.Start();
    }
}