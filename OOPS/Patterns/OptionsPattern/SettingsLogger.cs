using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Patterns.OptionsPattern
{
    internal class SettingsLogger
    {
        private readonly SampleSettings sampleSettings;

        public SettingsLogger(SampleSettings sampleSettings)
        {
            this.sampleSettings = sampleSettings;
        }

        public void Log()
        {
            Console.WriteLine($"String Setting : {sampleSettings.StringSetting}");
            Console.WriteLine($"Int Setting : {sampleSettings.IntSetting}");
        }
    }
}
