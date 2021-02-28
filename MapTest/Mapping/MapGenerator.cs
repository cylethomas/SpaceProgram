using System;
using System.Collections.Generic;
using System.Text;

namespace MapTest.Mapping
{
    public class MapGenerator
    {
        public static Map GetMap()
        {
            Map newMap = new Map();

            //create a random number gen
            Random mapRandom = new Random();


            int numberOfStarTypes = Enum.GetValues(typeof(StarType)).Length;

            
            int starType = mapRandom.Next(0, numberOfStarTypes - 1);

            
            newMap.StarType = (StarType)starType; // saves an int starType

            // now we need to attach the newMap.StarType to a list of images and save taht.
            // we need to connect a "picture to maybe picStarType and save it to new map as 
            // newMap.picStarType
            // then attach pic star type to the map coords

            return newMap;

           
        }
    }
}
