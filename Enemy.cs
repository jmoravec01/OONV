using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OONV
{
    public class Enemy : Character, ICharacter
    {
        public Enemy (string name) : base (name)
        {
        }
    }
}