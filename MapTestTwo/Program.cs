using System;

namespace MapTestTwo
{
    class Program
    {
        private int minStat = 0;
        private int maxStat = 2;
        int xCord = 0;
        int yCord = 0;
        public int Xcord
        {
            get => xCord;
            set => xCord = SetStat(value);
        }

        public int Ycord
        {
            get => yCord;
            set => yCord = SetStat(value);
        }

        private int SetStat(int value)
        {
            if (value < minStat) return minStat;
            if (value > maxStat) return maxStat;
            return value;
        }

        static int[] GetInput(string keyBoard)
        {
            int[] coords = new int[] { 0, 0 };  // this is what we'll return as a result and it'll store the X movement or Y movement as [X,Y]
            string ucKeyBoard = keyBoard.ToUpper();  // We'll set it ToUpper() so we only have to consider the uppercase options.

            switch (ucKeyBoard)
            {
                case "S":
                    coords[0] = 1;
                    return coords;
                case "W":
                    coords[0] = -1;
                    return coords;
                case "D":
                    coords[1] = 1;
                    return coords;
                case "A":
                    coords[1] = -1;
                    return coords;
                default:
                    return coords;
            }
        }


        static void Main(string[] args)
        {

            Program test = new Program();

            string keyBoard;
            int xCord = 0;
            int yCord = 0;






            // Part A: create 2D array of strings.
            string[,] array = new string[,]
            {
            {" | a | ", " | b | ", " | c | ", },
            {" | d | ", " | e | ", " | f | ", },
            {" | g | ", " | h | ", " | i | " }
            };
            // Part B: access (and print) values.


            Console.Write(array[0, 0]);
            Console.Write(array[0, 1]);
            Console.Write(array[0, 2]);
            Console.WriteLine();
            Console.Write(array[1, 0]);
            Console.Write(array[1, 1]);
            Console.Write(array[1, 2]);
            Console.WriteLine();
            Console.Write(array[2, 0]);
            Console.Write(array[2, 1]);
            Console.Write(array[2, 2]);

            Console.Read();
            Console.Clear();
            keyBoard = Console.ReadLine();

            int[] movement = GetInput(keyBoard);
            test.Xcord += movement[0];
            test.Ycord += movement[1];


            while ( keyBoard != "g")
            {
                keyBoard = Console.ReadLine();
                if (keyBoard == "W") { test.Xcord = test.Xcord + 1; }
                if (keyBoard == "w") { test.Xcord = test.Xcord + 1; }
                if (keyBoard == "S") { test.Xcord = test.Xcord - 1; }
                if (keyBoard == "s") { test.Xcord = test.Xcord - 1; }
                if (keyBoard == "D") { test.Ycord = test.Ycord +1; }
                if (keyBoard == "d") { test.Ycord = test.Ycord +1; }
                if (keyBoard == "A") { test.Ycord = test.Ycord -1; }
                if (keyBoard == "a") { test.Ycord = test.Ycord -1; };
                Console.Clear();

                Console.WriteLine(array[test.Xcord, test.Ycord]);

            }
            

           

            

        }
    }
}
