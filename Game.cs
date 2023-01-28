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
        public static bool CheckList (List<Character> list)
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

        public static void CheckEndgame (List<Character> Heroes, List<Character> Enemies)
        {
            if (CheckList(Enemies))
            {
                Console.WriteLine("Winner is HERO!");
                System.Environment.Exit(0);
            }
            else if (CheckList(Heroes))
            {
                Console.WriteLine("Winner is ENEMY!");
                System.Environment.Exit(0);
            }
        }


        // method for DMG DEAL
        public static void Fight (Character character1, Character character2)
        {
            Console.WriteLine("|{0}| is fighting |{1}|", character1.Name, character2.Name);
            int dmgCalc = character1.DealDmg() - character2.def;
            if (dmgCalc > 0)
            {
                character2.GetDmg(dmgCalc);
                Console.WriteLine("Champion |{0}| dealt {1}DMG!", character1.Name, dmgCalc);
                Console.WriteLine("|{0}| HPs went down to {1}HP", character2.Name, character2.hp);
                Console.WriteLine("---------------------------------");
            }
            else
            {
                Console.WriteLine("Champion |{0}| did not give any damage!", character1.Name);
            }
        }

        public static void Run (List<Character> Heroes, List<Character> Enemies)
        {
            bool end = false;
            int controlNumber = 0;
            while(end == false)
            {
                CheckEndgame(Heroes, Enemies);

                if (controlNumber == 0)
                {
                    Fight(Heroes[0], Enemies[0]);
                    ListHPCheck(Enemies);
                    controlNumber = 1;
                    continue;
                }
                else if (controlNumber == 1)
                {
                    Fight(Enemies[0], Heroes[0]);
                    ListHPCheck(Heroes);
                    controlNumber = 0;
                    continue;
                }

                CheckEndgame(Heroes, Enemies);           
            }
        }
    }
}