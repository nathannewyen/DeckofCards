using System;
using System.Collections.Generic;
namespace DeckofCards.Models
{
    public class Set
    {
        public List<Tile> Tiles = new List<Tile>();
        public Set()
        {
            // 3 classes - "Bamboo", "Pins", "Characters"
            // 9 values - 1,2,3,4,5,6,7,8,9
            string[] classes = new string[] { "Bamboo", "Pins", "Characters" };
            string[] values = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string[] winds = new string[] { "East", "South", "West", "North" };
            string[] dragons = new string[] { "Red", "Green", "White" };
            foreach (string _class in classes)
            {
                foreach (string value in values)
                {
                    Tiles.Add(new Tile(_class, value, false));
                    Tiles.Add(new Tile(_class, value, false));
                    Tiles.Add(new Tile(_class, value, false));
                    Tiles.Add(new Tile(_class, value, false));
                }
            }

            foreach (string wind in winds)
            {
                Tiles.Add(new Tile("wind", wind, true));
                Tiles.Add(new Tile("wind", wind, true));
                Tiles.Add(new Tile("wind", wind, true));
                Tiles.Add(new Tile("wind", wind, true));
            }

            foreach (string dragon in dragons)
            {
                Tiles.Add(new Tile("wind", dragon, true));
                Tiles.Add(new Tile("wind", dragon, true));
                Tiles.Add(new Tile("wind", dragon, true));
                Tiles.Add(new Tile("wind", dragon, true));
            }
        }
        public void Shuffle()
        {
            Random rand = new Random();
            for (int i = 0; i < Tiles.Count; i++)
            {
                int ranIndex = rand.Next(Tiles.Count);
                Tile temp = Tiles[i];
                Tiles[i] = Tiles[ranIndex];
                Tiles[ranIndex] = temp;
            }
        }
        public List<Tile> Deal(int number = 13)
        {
            List<Tile> Hand = new List<Tile>();
            for (int i = 0; i < number; i++)
            {
                Tile t = Tiles[0];
                Tiles.Remove(t);
                Hand.Add(t);
            }
            return Hand;
        }
    }
}