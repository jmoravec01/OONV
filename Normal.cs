using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OONV
{
    public class Normal : Enemy
    {
        public Normal (string jmeno) : base (jmeno)
        {
            this.dmg = 40;
            this.hp = 250;
            this.def = 20;
        }
    }
}