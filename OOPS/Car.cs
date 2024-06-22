using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public abstract class Car
    {
        public string Make { get; set; } = "";
        public string Model { get; set; } = "";
        public SteeringWheel SteeringWheel { get; set; } = new SteeringWheel();
        public Throttle Throttle { get; set; } = new Throttle();
        public BrakePedal BrakePedal { get; set; } = new BrakePedal();
        public EngineControlModule EngineControlModule { get; set; }

        public void Start()
        {
            EngineControlModule.Start();
        }
        public void Stop()
        {
            EngineControlModule.Stop();
        }
    }
}
