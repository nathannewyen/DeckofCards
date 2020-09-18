using System;
using System.Collections.Generic;
using DeckofCards.Models;

namespace DeckofCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Set s1 = new Set();
            s1.Shuffle();
            List<Tile> Hand = s1.Deal();
            foreach (Tile t in s1.Tiles)
            {
                t.Display();
            }
        }
    }
}