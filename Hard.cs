using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OONV
{
    public class Hard : Enemy
    {
        public Hard (string jmeno) : base (jmeno)
        {
            this.dmg = 60;
            this.hp = 350;
            this.def = 30;
        }
    }
}