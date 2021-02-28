using System;
using System.Collections.Generic;
using System.Text;

namespace Templates.Text2

{
    public class Text 
    {
        public string sentence;


        public void LetterByLetter(string sentence)
        {
            // we need to count the letters in a string?
            // we need to take each character slot and put it into a list?
            // we need to individually take each character and put it into a void? 
            // where it will break each character down into that line of code below
            // but the P will be replaced with each item from a list.

            Random numberRandom = new Random();

            
            char[] charArr = sentence.ToCharArray();  // c_ cy_ cyl_ cyle_ 0 01 012 0123 lenth = 4 lenth 
            foreach (char ch in charArr)
            {
                Console.Write(ch);

                System.Threading.Thread.Sleep(numberRandom.Next(50, 120));

            }
            Console.WriteLine();
        }
    }



        
}


