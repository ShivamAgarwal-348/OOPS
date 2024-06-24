using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Patterns
{
    public sealed class Singleton
    {
        

        public static Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton() { Value = new Random().Next()});
        public static Singleton Instance => instance.Value;
        public int Value { get; set; }
        private Singleton()
        {
            
        }
    }
}
