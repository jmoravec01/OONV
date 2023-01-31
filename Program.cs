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
            Hard Minecraft = new Hard("Fišer");
            Hard Minecraft2 = new Hard("Beránek");
            Hard Minecraft3 = new Hard("Škvor");

            Heroes.Add(Gandalf);
            Heroes.Add(Pepa);
            Enemies.Add(Minecraft);
            Enemies.Add(Minecraft2);
            Enemies.Add(Minecraft3);

            // HRA
//-------------------------------------------
            // Game.GameWelcome();
            // Game.Run(Heroes, Enemies);
//-------------------------------------------

            // MEMENTO
//-----------------------------------------------------------------------
            MementoCareTaker _careTaker = new MementoCareTaker();
            _careTaker.backup = Gandalf.CreateMemento();
            System.Console.WriteLine(_careTaker.backup.getMementoDmg);
            System.Console.WriteLine(Gandalf.Dmg);
            Gandalf.Dmg = 555;
            System.Console.WriteLine(Gandalf.Dmg);
            Gandalf.MementoRollback(_careTaker.backup);
            System.Console.WriteLine(Gandalf.Dmg);
//-----------------------------------------------------------------------


        }
    }
}