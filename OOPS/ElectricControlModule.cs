namespace OOPS
{
    public class ElectricControlModule : EngineControlModule
    {
        internal override void Start()
        {
            status = 1;
        }
        internal override void Stop()
        {
            status = 0;
        }

    }


}
