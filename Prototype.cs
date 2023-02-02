using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OONV
{
    public abstract class Prototype : ICharacter
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

        public int DealDmg()
        {
            Random r = new Random();
            int rInt = r.Next(0, 100);

            if (rInt > 75) // critical chance 25%
            {
                return 2*Dmg;
            }
            else
            {
                return Dmg;
            }
        }
        public void GetDmg(int dmg)
        {
            this.Hp -= dmg;
        }

        public void Heal()
        {
            this.Hp += 40;
        }

        public void PrintStats()
        {
            Console.WriteLine("|{0}|`s stats: {1}⚔️ / {2}❤️ / {3}🛡️", Name, Dmg, Hp, Def);
        }

        public void PrintHP()
        {
            Console.WriteLine("|{0}| has {1}❤️", Name, Hp);
        }
    }

    class Varyor : Prototype
    {
        int enteredNumber;
        public Varyor(string name, int dmg = 50, int hp = 500, int def = 40) : base(name, dmg, hp, def) { }

        public override Prototype Clone()
        {
            enteredNumber = int.Parse(Console.ReadLine());
            this.Hp = enteredNumber;
            return new Varyor(this.Name, this.Hp, this.Dmg, this.Def); //je this nutný?
        }
    }

    class Arcr : Prototype
    {
        public Arcr(string name, int dmg = 80, int hp = 350, int def = 30) : base(name, dmg, hp, def) { }

        public override Prototype Clone()
        {
            return (Arcr)this.MemberwiseClone();
        }
    }

    class Mejdz : Prototype
    {
        public Mejdz(string name, int dmg = 120, int hp = 200, int def = 20) : base(name, dmg, hp, def) { }

        public override Prototype Clone()
        {
            return (Mejdz)this.MemberwiseClone();
        }
    }

    class WeakK : Prototype
    {
        public WeakK(string name, int dmg = 20, int hp = 150, int def = 10) : base(name, dmg, hp, def) { }

        public override Prototype Clone()
        {
            return (WeakK)this.MemberwiseClone();
        }
    }

    class NormalL : Prototype
    {
        public NormalL(string name, int dmg = 40, int hp = 250, int def = 20) : base(name, dmg, hp, def) { }

        public override Prototype Clone()
        {
            return (NormalL)this.MemberwiseClone();
        }
    }

    class HardD : Prototype
    {
        public HardD(string name, int dmg = 60, int hp = 350, int def = 30) : base(name, dmg, hp, def) { }

        public override Prototype Clone()
        {
            return (HardD)this.MemberwiseClone();
        }
    }
}