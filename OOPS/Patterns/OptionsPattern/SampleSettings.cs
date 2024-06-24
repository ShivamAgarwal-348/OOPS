using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Patterns.OptionsPattern
{
    public class SampleSettings
    {
        public const string SectionName = "SampleSettings";

        public string StringSetting { get; set; } = null!;
        public int IntSetting { get; set; }
    }
}
