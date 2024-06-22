using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public abstract class EngineControlModule
    {
        protected ThrottlePositionSensor ThrottlePositionSensor = new ThrottlePositionSensor();
        public int status;
        internal abstract void Start();
        internal abstract void Stop();
        
    }


}
