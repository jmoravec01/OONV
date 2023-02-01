using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OONV
{
    public class Character : ICharacter
{
        public string name = "noname";
        public int dmg;
        public int hp;
        public int def;

        // GETTERS & SETTERS
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Dmg
        {
            get { return dmg; }
            set { dmg = value; }
        }
        public int Hp
        {
            get { return hp; }
            set { hp = value; }
        }
        public int Def
        {
            get { return def; }
            set { def = value; }
        }
        
        public Character(string name) 
        {
            this.name = name;
        }
        
//-----------------------------------------------------------------------------------
        public Memento CreateMemento ()
        {
            return new Memento(Name, Dmg, Hp, Def);
        }

        public void MementoRollback(Memento backup)
        {
            Console.WriteLine("Starting rollback... ");
            this.Name = backup.getMementoName();
            this.Dmg = backup.getMementoDmg();
            this.Hp = backup.getMementoHp();
            this.Def = backup.getMementoDef();
            Console.Write("Rollback done. ");
        }
//-----------------------------------------------------------------------------------

        public int DealDmg()
        {
            Random r = new Random();
            int rInt = r.Next(0, 100);

            if (rInt > 75) // critical chance 25%
            {
                return 2*dmg;
            }
            else
            {
                return dmg;
            }
        }

        public void GetDmg(int dmg)
        {
            this.hp -= dmg;
        }

        public void Heal()
        {
            this.hp += 40;
        }

        public void PrintStats()
        {
            Console.WriteLine("Champion stats: {0}⚔️ / {1}❤️ / {2}🛡️", dmg, hp, def);
        }

        public void PrintHP()
        {
            Console.WriteLine("Champion has {0}❤️", hp);
        }
    }
}