﻿// JAKUB MORAVEC ST96122
// seminárka -> MEMENTO
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

            Pepa.PrintStats();
            Gandalf.PrintHP();
        }
    }
}