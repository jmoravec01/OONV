using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OONV
{
    public class Weak : Enemy
    {
        public Weak (string jmeno) : base (jmeno)
        {
            this.dmg = 20;
            this.hp = 150;
            this.def = 10;
        }
    }
}