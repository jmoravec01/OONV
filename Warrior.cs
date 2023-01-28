using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OONV
{
    public class Warrior : Hero
    {
        public Warrior (string name) : base (name)
        {
            this.dmg = 50;
            this.hp = 500;
            this.def = 40;
        }
    }
}