using Task7Library.BLL;
using Task7Library.DAL;
using Task7Library.PLL;

namespace Task7Library;

public class Program
{
    static void Main()
    {
        IBookRepo bookRepo = new BookInMemoryRepo();
        IBookLogic bookLogic = new BookLogicImpl(bookRepo);
        ConsoleInterface consoleInterface = new ConsoleInterface(bookLogic);
        consoleInterface.Start();
    }
}