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
                Console.WriteLine("Winners are HEROES!");
                System.Environment.Exit(0);
            }
            else if (CheckList(Heroes))
            {
                Console.WriteLine("Winners are ENEMIES!");
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
                Console.WriteLine("Champion |{0}| dealt [{1}]DMG!", character1.Name, dmgCalc);
                Console.WriteLine("|{0}| HPs went down to [{1}]HP", character2.Name, character2.hp);
                Console.WriteLine("---------------------------------");
            }
            else
            {
                Console.WriteLine("Champion |{0}| did not give any damage!", character1.Name);
                Console.WriteLine("---------------------------------------");
            }
        }

        public static void PlayerMenu ()
        {

        }

        public static void AIMenu ()
        {

        }

        public static void GameWelcome ()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Welcome to the RPG GAME!");
            int desiredNumber = 111;
            int quitNumber = 999;
            int enteredNumber;
            bool success = false;

            while (!success) 
            {
                Console.Write("To START the game -> enter number 111. To QUIT -> enter number 999: ");
                try
                {
                enteredNumber = int.Parse(Console.ReadLine());
                if (enteredNumber == desiredNumber)
                {
                    success = true;
                }
                else if (enteredNumber == quitNumber)
                {
                    Console.WriteLine("Okey, have a nice day. Bye!");
                    System.Environment.Exit(0);
                } 
                else 
                {
                    Console.WriteLine("It´s just 111/999. Try it again!");
                }
                } 
                catch (FormatException) 
                {
                    Console.WriteLine("It´s just 111/999. Try it again!");
                }
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