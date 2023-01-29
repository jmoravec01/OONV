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
            Console.WriteLine("------------------------");
            Console.WriteLine("1. Write possible heroes.");
            Console.WriteLine("2. Write all about heroes.");
            Console.WriteLine("3. Choose hero.");
            Console.WriteLine("4. Write all about characters.");
            Console.WriteLine("5. Write possible enemies.");
            Console.WriteLine("6. Write all about enemies.");
            Console.WriteLine("------------------------");
            
            int enteredNumber;
            bool success = false;
            while (!success) 
            {
                try
                {
                    Console.Write("What is your choice: ");
                    enteredNumber = int.Parse(Console.ReadLine());
                    if (1 <= enteredNumber && enteredNumber <= 6)
                    {
                        success = true;
                    }
                } 
                catch (FormatException) 
                {
                    Console.WriteLine("That`s not an option! Try it again!");
                }
            }
            
        }

        public static void AIMenu ()
        {
        }

        public static void printCharacters (List<Character> list)
        {
            for (int x = 0; x < list.Count; x++)
            {
                Console.WriteLine("Name: |{0}|, class: |{1}|", list[x].Name, list[x].GetType().Name);
            }
        }

        public static void printCharactersWithStats (List<Character> list)
        {
            for (int x = 0; x < list.Count; x++)
            {
                Console.WriteLine("Name: |{0}|, class: |{1}|, stats: |{2}DMG||{3}HP||{4}DEF|", list[x].Name, list[x].GetType().Name, list[x].Dmg, list[x].Hp, list[x].Def);
            }
        }

        // input matters
        public static void GameWelcome ()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Welcome to the RPG GAME!");
            int desiredNumber = 111;
            int quitNumber = 999;
            int enteredNumber;
            int counter = 0;
            bool success = false;

            while (!success) 
            {
                if (counter == 5)
                {
                    Console.WriteLine("Okey, you are trolling. I am shutting down myself.");
                    System.Environment.Exit(0);
                }
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
                    counter += 1;
                    Console.WriteLine("It`s just 111/999. Try it again!");
                }
                } 
                catch (FormatException) 
                {
                    counter += 1;
                    Console.WriteLine("It`s just 111/999. Try it again!");
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