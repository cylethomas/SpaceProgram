using System;
using System.Collections.Generic;
using Templates.People;
using Templates.Text2;

namespace Templates
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Person person = new Person();
            Text textChange = new Text();

            Console.WriteLine("Hello recruit... Welcome to the Collective Orginization Galaxies. AKA C.O.G.");
            Console.WriteLine("Please respond to the following prompts... As we begin your application process.");
            Console.WriteLine("Once you are ready, [ R ] type the letter R into the console to conifrm.");
            while (Console.ReadKey().Key != ConsoleKey.R) { }

            
            Console.Clear();
                                 
            Console.WriteLine("Please enter your name...");
            person.Name = Console.ReadLine();

            
            while (int.TryParse(person.Name, out int n) || String.IsNullOrEmpty(person.Name)) // if person.Name is int, we ask for you to input a name again
            {
                Console.WriteLine("I'm sorry your input was invalid.");
                Console.WriteLine("Again, Please input your name:");
                person.Name = Console.ReadLine();

            }
            


            

            Console.Clear();
                       
            Console.WriteLine("Please input your age:");
            var checkNumber = Console.ReadLine();

                     
            if (int.TryParse(checkNumber, out int firstCheck))
            {
                person.Age = firstCheck;
            }
            else while (!int.TryParse(checkNumber, out int secondCheck))
            {
                    Console.WriteLine("Please enter your age, and use a whole number.");
                    checkNumber = Console.ReadLine();
                    if (int.TryParse(checkNumber, out int secondCheckIsTrue))
                    {
                        person.Age = secondCheckIsTrue;
                    }
                    // not working becaue the else does not add value to seconde check. it is not a number
            }
                 

            
            Console.Clear();




            textChange.LetterByLetter("Hello " + person.Name + ", you are " + person.Age + " years old.");
            
                       


            textChange.LetterByLetter("Is this information correct? Enter Y to confirm. ");
            
            while (Console.ReadKey().Key != ConsoleKey.Y) { }

            Console.ReadLine(); // Ends






        }
    }
}
