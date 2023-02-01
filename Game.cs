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
                Console.WriteLine(" ");
                Console.WriteLine("------------Survivors------------");
                printCharacters(Heroes);
                Console.ReadKey();
                System.Environment.Exit(0);
            }
            else if (CheckList(Heroes))
            {
                Console.WriteLine("Winners are ENEMIES!");
                Console.WriteLine(" ");
                Console.Write("------------Survivors------------");
                printCharacters(Enemies);
                Console.ReadKey();
                System.Environment.Exit(0);
            }
        }


        // method for DMG DEAL
        public static void Fight (Character character1, Character character2)
        {
            Console.WriteLine(" ");
            Console.WriteLine("---------------------------------");
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

        // maybe fix over-HP-healing?
        public static void HealCharacter (Character character)
        {
            Console.WriteLine("------------------------");
            var oldHP = character.Hp;
            character.Heal();
            Console.WriteLine("|{0}| healed from |{1}|HPs to |{2}|Hps.", character.Name, oldHP, character.Hp);
            Console.WriteLine("------------------------");
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

        public static void YourTurn (List<Character> Heroes, List<Character> Enemies)
        {
            MementoCareTaker _careTaker = new MementoCareTaker();
            int enteredNumber;
            bool success = false;
            while (!success) 
            {
                Console.WriteLine(" ");
                Console.WriteLine("------------------------");
                Console.WriteLine("1. Show possible heroes.");
                Console.WriteLine("2. Show all about heroes.");
                Console.WriteLine("3. Choose hero.");
                Console.WriteLine("4. Fight.");
                Console.WriteLine("5. Heal.");
                Console.WriteLine("6. Show possible enemies.");
                Console.WriteLine("7. Show all about enemies.");
                Console.WriteLine("8. Create MEMENTO.");
                Console.WriteLine("9. Load MEMENTO.");
                Console.WriteLine("------------------------");
                Console.WriteLine(" ");

                try
                {
                    Console.Write("What is your choice: ");
                    enteredNumber = int.Parse(Console.ReadLine());
                    if (1 <= enteredNumber && enteredNumber <= 9)
                    {
                        switch (enteredNumber)
                        {
                            case 1:
                                Console.WriteLine(" ");
                                printCharacters(Heroes);
                                continue;
                            case 2:
                                Console.WriteLine(" ");
                                printCharactersWithStats(Heroes);
                                continue;
                            case 3:
                                Console.WriteLine(" ");
                                SwapCharacters(Heroes);
                                continue;
                            case 4:
                                Fight(Heroes[0], Enemies[0]);
                                success = true;
                                break;
                            case 5:
                                Console.WriteLine(" ");
                                HealCharacter(Heroes[0]);
                                success = true;
                                break;
                            case 6:
                                Console.WriteLine(" ");
                                printCharacters(Enemies);
                                continue;
                            case 7:
                                Console.WriteLine(" ");
                                printCharactersWithStats(Enemies);
                                continue;

                            //JEŽIŠ TO JE SRAČKA
                            case 8:
                                Console.WriteLine(" ");
                                Console.WriteLine("Starting memento...");
                                _careTaker.backup = Heroes[0].CreateMemento();
                                Console.WriteLine("Memento of |{0}| done.", Heroes[0].Name);
                                continue;
                            case 9:
                                System.Console.WriteLine(_careTaker.backup.getMementoName());
                                Console.WriteLine(" ");
                                Console.WriteLine("Rolling memento back...");
                                Heroes[0].MementoRollback(_careTaker.backup);
                                Console.WriteLine("Memento of |{0}| rolled back.", Heroes[0].Name);
                                continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("That`s not an option! Try it again!");
                    }
                }
                catch (FormatException) 
                {
                    Console.WriteLine("That`s not an option! Try it again!");
                }
            }
        }

        public static void AITurn (Character Hero, Character Enemy)
        {
            Fight(Enemy, Hero);
        }

        public static List<Character> SwapCharacters (List<Character> list)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("You chose to swap main character!\n");
            for (int x = 0; x < list.Count; x++)
            {
                Console.WriteLine("{0}. Name: |{1}|, class: |{2}|", x+1, list[x].Name, list[x].GetType().Name);
            }

            int enteredNumber;
            bool success = false;
            int countList = list.Count;
            while (!success) 
            {
                try
                {
                    Console.WriteLine(" ");
                    Console.Write("Which one is it gonna be: ");
                    enteredNumber = int.Parse(Console.ReadLine());
                    if (1 <= enteredNumber && enteredNumber <= countList+1)
                    {
                        Character x;
                        x = list[enteredNumber-1];
                        list.RemoveAt(enteredNumber-1);
                        list.Insert(0, x); 
                        Console.WriteLine(" ");
                        Console.WriteLine("Your main character is now |{0}|", list[0].Name);
                        break;  
                    }
                    else
                    {
                        Console.WriteLine("That`s not an option! Try it again!");
                    }
                }
                catch (FormatException) 
                {
                    Console.WriteLine("That`s not an option! Try it again!");
                }
            }
            return list;
        }

        public static void TurnPrototypeIntoCharacter (Character character, Prototype prototype)
        {
            Character a = new Character(prototype.Name);
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
            int turns = 0;

            while(end == false)
            {
                CheckEndgame(Heroes, Enemies);

                if (controlNumber == 0)
                {
                    YourTurn(Heroes, Enemies);
                    ListHPCheck(Enemies);
                    controlNumber = 1;
                    turns += 1;
                    continue;
                }
                else if (controlNumber == 1)
                {
                    AITurn(Heroes[0], Enemies[0]);
                    ListHPCheck(Heroes);
                    controlNumber = 0;
                    turns += 1;
                    continue;
                }

                CheckEndgame(Heroes, Enemies);           
            }
        }
    }
}