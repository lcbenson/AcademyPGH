using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] threewords = { "fizz","fizzy","fuzz"};
            string [] fivewords = { "buzz","buzzy","bizz"};
            string[] bothwords = { "fizzbuzz", "buzzyfizz", "fizzitybuzz" };

            Random rnd = new Random();
            // int number = 1; //int to name the integer as 1 and go forward
            for (int number = 0; number < 100; number++)

            {

                if (number % 3 == 0 && number % 5 == 0)
                {
                    int bothwordsID = rnd.Next(3);
                    Console.WriteLine(bothwords[bothwordsID]);
                }

                else if (number % 3 == 0) 
                {
                    int threewordsID = rnd.Next(3);
                    Console.WriteLine(threewords[threewordsID]);
                }

                else if (number % 5 == 0)         //no ; needed after if's
                {
                    int fivewordsID = rnd.Next(3);
                    Console.WriteLine(fivewords[fivewordsID]);
                }
                else             //this is neccesary to start the first number, otherwise no output
                {                //because it wil continue through the if statments then repeat otherwse
                    Console.WriteLine(number);
                }
            }

            Console.ReadLine();
        }

    }
}
