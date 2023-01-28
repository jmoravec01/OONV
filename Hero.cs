using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OONV
{
    public class Hero : Character, ICharacter
    {
        public Hero (string name) : base (name)
        {
        }
    }
}