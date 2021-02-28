using System;
using MapTest.Mapping;
using MapTest.SpaceObjects;


namespace MapTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Map gameMap = new Map();

            foreach (var item in Map.arr2d)
            {
                Console.WriteLine(item.ToString());
            }

            Map.ConsoleMap();

            Planet planetOne = PlanetGenerator.GetPlanet();

            
            Console.WriteLine(planetOne.AnimalType);
            Console.WriteLine(planetOne.WaterType);
            Console.WriteLine(planetOne.LifeType);
            Console.WriteLine(planetOne.AtmosphereType);

            Planet newPlanetTwo = PlanetGenerator.GetPlanet();

            Console.WriteLine(newPlanetTwo.AnimalType);
            Console.WriteLine(newPlanetTwo.WaterType);
            Console.WriteLine(newPlanetTwo.LifeType);
            Console.WriteLine(newPlanetTwo.AtmosphereType);





        } 



    }



 }

       
    

