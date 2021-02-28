using System;
using System.Collections.Generic;
using System.Text;

namespace TestSession.Sample_Classes
{
    public class Planet : IMapObject
    {
        public Planet()
        {
            // Lets leave this
        }

        public Planet(string name, int size = 0, int x = 0, int y = 0)
        {
            Name = name;
            X = x;
            Y = y;
            Size = size;
        }
        public int Size { get; set; }
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
