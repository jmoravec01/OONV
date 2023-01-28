using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OONV
{
    public class BoxingBag : Enemy
    {
        public BoxingBag (string name) : base (name)
        {
            this.dmg = 0;
            this.hp = 1000;
            this.def = 40;
        }
    }
}