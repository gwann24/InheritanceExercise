using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {

        }
        public bool Flightless { get; set; }
        public string Diet { get; set; }
        public bool HasTeeth { get; set; }
        public bool Migrates { get; set; }

    }
}
