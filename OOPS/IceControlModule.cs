namespace OOPS
{
    public class IceControlModule : EngineControlModule
    {
        private CrankPositionSensor CrankPositionSensor = new CrankPositionSensor();

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
