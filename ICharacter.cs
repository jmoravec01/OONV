using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OONV
{
    public interface ICharacter
    {
        public int DealDmg();
        public void GetDmg(int dmg);
        public void Heal();
        public void PrintStats();
        public void PrintHP();
    }
}