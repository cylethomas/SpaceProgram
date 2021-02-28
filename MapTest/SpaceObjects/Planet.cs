using System;
using System.Collections.Generic;
using System.Text;

namespace MapTest.SpaceObjects
{
    public class Planet
    {
        private int _position;
        private int _minPosition = 1;
        private int _maxPosition = 9;

        private string _atmosphere;
        private string _water;

        public int Position { get => _position; set => _position = value; }
        

        public AtmosphereType AtmosphereType { get; set; }
        public WaterType WaterType { get; set; }
        public AnimalType AnimalType { get; set;}
        public LifeType LifeType { get; set; }

        

        public string AtmosphereName
        {
            get
            {
                string atmosphereName = $"{AtmosphereType.ToString()}";
                return atmosphereName;
            }
        }

        public string WaterName
        {
            get
            {
                string waterName = $"{WaterType.ToString()}";
                return waterName;
            }
        }

        public string AnimalName
        {
            get
            {
                string animalName = $"{AnimalType.ToString()}";
                return animalName;
            }
        }

        public string LifeName
        {
            get
            {
                string lifeName = $"{LifeType.ToString()}";
                return lifeName;
            }
        }

        

        



    }
}
