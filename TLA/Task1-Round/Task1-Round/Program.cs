using Task1_Round.BLL;
using Task1_Round.DAL;
using Task1_Round.PLL;

namespace Task1_Round
{
    class Program
    {
        static void Main()
        {
            IRoundRepo roundRepo = new RoundInMemoryRepo();
            IRoundLogic roundLogic = new RoundLogiclmpl(roundRepo);
            ConsoleInterface consoleInterface = new ConsoleInterface(roundLogic);
            consoleInterface.Start();
        }
    }
}
