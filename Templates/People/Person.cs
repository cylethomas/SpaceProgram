using System;
using System.Collections.Generic;
using System.Text;

namespace Templates.People
{
    public class Person
    {
        // properties 
        public int Age { get; set; }
        public string Name;
        public bool HasPet;
        public string FavoriteFood;

        

        // method 
        public void Greeting()
        {
            Console.WriteLine("Hello " + Name + ", your " + Age + " is years old");
        }

    }
}
