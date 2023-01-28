using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OONV
{
    public class Game
{
        private bool end = false;
        public void Run(List<Character> Heroes, List<Character> Enemies)
        {
            while (end == false)
            {
                if (CheckWin(Heroes))
                {
                    Console.WriteLine("Winners are ENEMIES!");
                }
                else if (CheckWin(Enemies))
                {
                    Console.WriteLine("Winners are HEROES!");
                }
                else
                {

                }
            }
        }

        public static void Utok (Character character1, Character character2)
        {
            int dmgCalc = character1.DealDmg() - character2.def;
            if (dmgCalc > 0)
            {
                character2.GetDmg(dmgCalc);
                Console.WriteLine("Champion {0} dealt {1}⚔️!", character1.Name, dmgCalc);
            }
            else
            {
                Console.WriteLine("Champion {0} did not give you any damage!", character1.Name);
            }
        }
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
        public static List<Character> ListHPCheck(List<Character> list)
        {
            foreach(Character postava in list)
            {
                if(postava.hp <= 0)
                {
                    list.Remove(postava);
                    break;
                }
            }
            return list;
        }
    }
}