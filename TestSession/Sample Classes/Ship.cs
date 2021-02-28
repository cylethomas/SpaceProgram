using System;
using System.Collections.Generic;
using System.Text;

namespace TestSession.Sample_Classes
{
    public class Ship : IMapObject
    {
        public Ship(int x, int y, string name)
        {
            Name = name;
            X = x;
            Y = y;
        }
        
        public int Speed { get; set; }
        public int CrewCount { get; set; }
        public string Name { get; set; }

        public int X { get; set; }
        public int Y { get; set; }
    }
}
