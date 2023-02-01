using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OONV
{
    public abstract class Prototype
    {
        public string Name { get; set; }
        public int Dmg { get; set; }
        public int Hp { get; set; }
        public int Def { get; set; }

        public Prototype (string name, int dmg, int hp, int def)
        {
            this.Name = name;
            this.Dmg = dmg;
            this.Hp = hp;
            this.Def = def;
        }

        public abstract Prototype Clone();
    }

    class Varyor : Prototype
    {
        public Varyor(string name, int dmg = 50, int hp = 500, int def = 40) : base(name, dmg, hp, def) { }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }

    class Arcr : Prototype
    {
        public Arcr(string name, int dmg = 80, int hp = 350, int def = 30) : base(name, dmg, hp, def) { }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }

    class Mejdz : Prototype
    {
        public Mejdz(string name, int dmg = 120, int hp = 200, int def = 20) : base(name, dmg, hp, def) { }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }

    class WeakK : Prototype
    {
        public WeakK(string name, int dmg = 20, int hp = 150, int def = 10) : base(name, dmg, hp, def) { }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }

    class NormalL : Prototype
    {
        public NormalL(string name, int dmg = 40, int hp = 250, int def = 20) : base(name, dmg, hp, def) { }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }

    class HardD : Prototype
    {
        public HardD(string name, int dmg = 60, int hp = 350, int def = 30) : base(name, dmg, hp, def) { }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}