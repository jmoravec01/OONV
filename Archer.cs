using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OONV
{
    public class Archer : Hero
    {
        public Archer (string name) : base (name)
        {
            this.dmg = 80;
            this.hp = 350;
            this.def = 30;
        }
    }
}