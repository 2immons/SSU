namespace Facade
{
    public class CarFacade
    {
        CheckingStystem checking;
        Engine engine;
        public CarFacade()
        {
            checking = new CheckingStystem();
            engine = new Engine();
        }
        public void StartCar()
        {
            checking.StartChecking();
            engine.StartEngine();
        }
        public void TurnOffCar()
        {
            engine.TurnOffEngine();
        }
    }

}
