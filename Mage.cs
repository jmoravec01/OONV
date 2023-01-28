using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OONV
{
    public class Mage : Hero
    {
        public Mage (string name) : base (name)
        {
            this.dmg = 120;
            this.hp = 200;
            this.def = 20;
        }
    }
}