using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OONV
{
    public class Morpheus : Hero
    {
        public Morpheus (string name) : base (name)
        {
            this.dmg = 120;
            this.hp = 500;
            this.def = 20;
        }
    } 
}