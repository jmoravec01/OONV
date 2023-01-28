using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OONV
{
    public class Game
    {
        // checks HP of all characters in list
        public static List<Character> ListHPCheck(List<Character> list)
        {
            foreach(Character postava in list)
            {
                if (postava.hp <= 0)
                {
                    list.Remove(postava);
                    break;
                }
            }
            return list;
        }

        // checks if list is empty (0)
        public static bool CheckWin (List<Character> list)
        {
            if (list.Count == 0)
            {
                return true;
            } 
            else 
            {
                return false;
            }
        }


        // method for DMG DEAL
        public static void Fight (Character character1, Character character2)
        {
            System.Console.WriteLine("{0} is fighting {1}.", character1.Name, character2.Name);
            int dmgCalc = character1.DealDmg() - character2.def;
            if (dmgCalc > 0)
            {
                character2.GetDmg(dmgCalc);
                Console.WriteLine("Champion {0} dealt {1}⚔️!", character1.Name, dmgCalc);
                Console.WriteLine("{0}`s HPs went down to {1}", character2.Name, character2.hp);
            }
            else
            {
                Console.WriteLine("Champion {0} did not give any damage!", character1.Name);
            }
        }

        public static void Run (List<Character> Heroes, List<Character> Enemies)
        {
            while(CheckWin(Heroes) == false)
            {
                Fight(Heroes[0], Enemies[0]);
                ListHPCheck(Heroes);
                ListHPCheck(Enemies);

                if (CheckWin(Enemies))
                {
                    Console.WriteLine("Winner is HERO!");
                    break;
                }
                if (CheckWin(Heroes))
                {
                    Console.WriteLine("Winner is ENEMY!");
                    break;
                }
            }
        }
    }
}