using System;
using System.Collections.Generic;
using System.Text;

namespace MapTest.Mapping
{
    public class Map
    {
        // a map is = to a collection of positons aka an array or list
        // if pos 1 == 1 than print posONE ( some string )
        // each string type will have to be assigned a numerical value somehow

        // test map 1

        public int MapPosOne = 1;
        public int MapPosTwo = 2;
        public int MapPosThree = 3;
        public int MapPosFour = 4;
        public int MapPosFive = 5;
        public int MapPosSix = 6;
        public int MapPosSeven = 7;
        public int MapPosEight = 8;
        public int MapPosNine = 9;

        

            // now we make a if statement that is if user position is = to map pos then change this collections of strings
            // that make up the console.

            // for this void, i need to do all of the logic that will have public images
            // of what will go into ShowCurrentPosition()
            // EG planet = " (0) " - enums types like before?

        public StarType StarType { get; set; }

        public string StarName
        {
            get
            {
                string starName = $"{StarType.ToString()}";
                return starName;
            }
        }
















        public static int[,] arr2d = new int[3, 3]
            {
                                        {1, 2, 3},
                                        {4, 5, 6},
                                        {7, 8, 9}
            };

        public static string myString = arr2d.ToString();
        private static int posOne = arr2d[0, 0];
        private static int posTwo = arr2d[0, 1];
        private static int posThree = arr2d[0, 2];

        public static int PosOne { get => posOne; set => posOne = value; }
        public static int PosTwo { get => posTwo; set => posTwo = value; }
        public static int PosThree { get => posThree; set => posThree = value; }

        public static void ConsoleMap()
        {
            // collects the strings and prints in 3 lines
            // Can be static because it is not being instantinated => 
            // not sure I can "collect" string in a static class
            Console.Write(PosOne);
            Console.Write(PosTwo);
            Console.Write(PosThree);
            Console.WriteLine();
            Console.Write(PosOne);
            Console.Write(PosTwo);
            Console.Write(PosThree);
            Console.WriteLine();
            Console.Write(PosOne);
            Console.Write(PosTwo);
            Console.Write(PosThree);
            Console.WriteLine();





        }
    }


        

    

}
