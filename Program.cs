// JAKUB MORAVEC ST96122
// seminárka -> MEMENTO, BUILDER
// main postava Sandman, příšery, nepřátelé
// třídy: válečník, lukostřelec, mág
//      válečník countruje mága, staty HP/DMG/OBRANA: 100/20
//      lukostřelec countruje válečníka, staty HP/DMG/OBRANA: 75/
//      mág countruje lukostřelce, staty HP/DMG/OBRANA: 50/

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
            Archer Josef = new Archer("Josef");
            Hard Minecraft = new Hard("Minecraft");
            Hard Minecraft2 = new Hard("Minecraft2");
            Hard Minecraft3 = new Hard("Minecraft3");

            Heroes.Add(Gandalf);
            Heroes.Add(Pepa);
            Enemies.Add(Minecraft);
            Enemies.Add(Minecraft2);
            Enemies.Add(Minecraft3);

            // Game.GameWelcome();
            // Game.Run(Heroes, Enemies);
            // Game.printCharactersWithStats(Heroes);
            Game.PlayerMenu();
        }
    }
}