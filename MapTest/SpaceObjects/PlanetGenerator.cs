using System;
using System.Collections.Generic;
using System.Text;

namespace MapTest.SpaceObjects
{
    public static class PlanetGenerator
    {
        public static Planet GetPlanet()
        {
            Planet newPlanet = new Planet();

            //create a random number gen
            Random planetRandom = new Random();
            

            // figure out what type of atmosphere
            int numberOfAtmosphereTypes = Enum.GetValues(typeof(AtmosphereType)).Length;

            // Generate a random number between 0 and the number of atmosphere types ( enums )
            int atmosphereType = planetRandom.Next(0, numberOfAtmosphereTypes - 1);

            // Convert the integer atmosphereType into an Enum of the AtmosphereType type ( could this be an array or list? )
            newPlanet.AtmosphereType = (AtmosphereType)atmosphereType;

            // water gen
            int numberOfWaterTypes = Enum.GetValues(typeof(WaterType)).Length;
            
            int waterType = planetRandom.Next(0, numberOfWaterTypes - 1);
            
            newPlanet.WaterType = (WaterType)waterType;

            // animal gen

            int numberOfAnimalTypes = Enum.GetValues(typeof(AnimalType)).Length;

            int animalType = planetRandom.Next(0, numberOfAnimalTypes - 1);

            newPlanet.AnimalType = (AnimalType)animalType;

            // life gen

            int numberOfLifeTypes = Enum.GetValues(typeof(LifeType)).Length;

            int lifeType = planetRandom.Next(0, numberOfLifeTypes - 1);

            newPlanet.LifeType = (LifeType)lifeType;



            return newPlanet;
        }
    }
}
