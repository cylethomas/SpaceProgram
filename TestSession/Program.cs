using System;
using System.Collections.Generic;
using System.Linq;
using TestSession.Sample_Classes;
//Newtonsoft.JSON

namespace TestSession
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IMapObject> mapObjects = new List<IMapObject>();
            
            Random dice = new Random();

            int mapSizeX = 30;
            int mapSizeY = 30;
            int populationModifier = 50;

            
            for(int i = 0; i < mapSizeX; i++)
            {
                for(int j = 0; j < mapSizeY; j++)
                {
                    var diceRoll = dice.Next(1, populationModifier);

                    if (diceRoll == 1)
                    {
                        mapObjects.Add(
                            new Planet(x: i, y: j, name: $"Planet {i} {j}")
                            );
                    }
                    else if (diceRoll == 2)
                    {
                        mapObjects.Add(
                            new Ship(x: i, y: j, $"Ship {i} {j}") { CrewCount = 0 }
                            );
                    }
                }
            }

            foreach(var mapObj in mapObjects)
            {
                for(int i = 0; i < mapSizeX; i++)
                {
                    for(int j = 0; j < mapSizeY; j++)
                    {
                        IMapObject mapObject = mapObjects.FirstOrDefault(m => m.X == i && m.Y == j);
                        if(mapObject != null)
                        {
                            var objectType = mapObject.GetType();
                            if(objectType == typeof(Planet))
                            {
                                Console.Write("P");
                            }
                            else if (objectType == typeof(Ship))
                            {
                                Console.Write("S");
                            }
                        }
                        else
                        {
                            Console.Write("-");
                        }
                    }
                    Console.Write(Environment.NewLine);
                }
            }

            Console.ReadLine();
        }

        static void GetMapObjects(int seed)
        {

        }
    }
}
