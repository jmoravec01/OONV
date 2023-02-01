// JAKUB MORAVEC ST96122
// seminárka -> MEMENTO, BUILDER
// třídy: válečník, lukostřelec, mág, Morpheus (OP)

using System;

namespace OONV
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            List<Character> Heroes = new List<Character>();
            List<Character> Enemies = new List<Character>();

            Warrior Pepa = new Warrior("Pepa");
            Morpheus Gandalf = new Morpheus("Gandalf");
            Archer Geralt = new Archer("Josef");
            Hard Minecraft = new Hard("Fischer");
            Hard Minecraft2 = new Hard("Bodiusu Maxius");
            Hard Minecraft3 = new Hard("Škvorex");

            Heroes.Add(Gandalf);
            Heroes.Add(Pepa);
            Enemies.Add(Minecraft);
            Enemies.Add(Minecraft2);
            Enemies.Add(Minecraft3);

            // HRA
//-------------------------------------------
            Game.GameWelcome();
            Game.Run(Heroes, Enemies);
//-------------------------------------------


            // MEMENTO ASI?
//-----------------------------------------------------------------------
            // MementoCareTaker _careTaker = new MementoCareTaker();
            // _careTaker.backup = Gandalf.CreateMemento();
            // System.Console.WriteLine(_careTaker.backup.getMementoName());
            // System.Console.WriteLine(" ");
            // System.Console.WriteLine(_careTaker.backup.getMementoDmg() + " uložený dmg");
            // System.Console.WriteLine(Gandalf.Dmg + " aktuální dmg");
            // Game.printCharactersWithStats(Heroes);
            // System.Console.WriteLine(" ");
            // Gandalf.Dmg = 555;
            // System.Console.WriteLine(Gandalf.Dmg + " změnený dmg");
            // System.Console.WriteLine(_careTaker.backup.getMementoDmg() + " uložený dmg");
            // Game.printCharactersWithStats(Heroes);
            // System.Console.WriteLine(" ");
            // System.Console.WriteLine(Gandalf.Dmg + " změněný dmg");
            // Gandalf.MementoRollback(_careTaker.backup);
            // System.Console.WriteLine(Gandalf.Dmg + " dmg po rollbacku");
//-----------------------------------------------------------------------

            // PROTOTYPE
//-----------------------------------------------------------------------
            // Prototype prototype1 = new Varyor("Chemsyčák");
            // Arcr prototype3 = new Arcr("Káčysmehc");
            // Prototype prototype2 = prototype1.Clone();
            // System.Console.WriteLine(prototype1.Dmg);
            // System.Console.WriteLine(prototype2.Dmg);
            // System.Console.WriteLine(prototype3.Dmg);
            // Varyor prototype12 = new Varyor("pepa");
//-----------------------------------------------------------------------
        }
    }
}