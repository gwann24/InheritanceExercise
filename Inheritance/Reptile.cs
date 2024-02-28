using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            
        }
        public bool Poisonous { get; set; }
        public bool Constrictor { get; set; }
        public bool HasShell { get; set; }
        public string Habitat {  get; set; }

    }
}
