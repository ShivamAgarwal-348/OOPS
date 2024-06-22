using System.Reflection;

namespace OOPS
{
    public class EC1 : Car
    {
        public EC1()
        {
            Make = "Tata";
            Model = "Nexon";
            EngineControlModule = new ElectricControlModule();
        }
    }
}
