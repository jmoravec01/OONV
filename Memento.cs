using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OONV
{
    public class Memento
    {
        private string _MementoName;
        private int _MementoDmg;
        private int _MementoHp;
        private int _MementoDef;

        public Memento(string name, int dmg, int hp, int def)
        {
            this._MementoName = name;
            this._MementoDmg = dmg;
            this._MementoHp = hp;
            this._MementoDef = def;
        }

        public string getMementoName()
        {
            return this._MementoName;
        }
        public int getMementoDmg()
        {
            return this._MementoDmg;
        }
        public int getMementoHp()
        {
            return this._MementoHp;
        }
        public int getMementoDef()
        {
            return this._MementoDef;
        }
    }

    public class MementoCareTaker
    {
        public Memento backup { get; set; }
    }
}