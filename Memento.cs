using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OONV
{
    public class Memento
    {
        public string MementoName;
        public int MementoDmg;
        public int MementoHp;
        public int MementoDef;

        public Memento(string name, int dmg, int hp, int def)
        {
            this.MementoName = name;
            this.MementoDmg = dmg;
            this.MementoHp = hp;
            this.MementoDef = def;
        }
    }

    public class MementoCareTaker
    {
        public Memento backup { get; set; }
    }
}