namespace OOPS
{
    public class S1 : Car
    {
        public S1()
        {
            Make = "Toyota";
            Model = "Innova";
            EngineControlModule = new IceControlModule();
        }
    }
}
