using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int answer;
            bool keeplooping = true;
            Console.WriteLine("What would you like to do? \n a) Add \n b) Subtract");
            string response;
            response = Console.ReadLine();
           // while (keeplooping)
           // {

                if (response == "a")

                {
                    Console.WriteLine("What is the first number?");
                    response = Console.ReadLine();
                    if (int.TryParse(response, out number1))
                        keeplooping = false;
                }
                keeplooping = true;
                while (keeplooping) ;
                {

                    Console.WriteLine("What is the second number?");
                    response = Console.ReadLine();
                    if (int.TryParse(response, out number2))
                        answer = number1 + number2;
                    Console.WriteLine("Your answer is " + answer + "!");

                //}

                Console.ReadLine();
            }
        }
    }
}
