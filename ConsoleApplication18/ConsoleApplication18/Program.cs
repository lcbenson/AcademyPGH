using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Program
    {
        static int AddFunction(int number1, int number2)
        {
            int sum;
            sum = number1 + number2;
            return sum;
        }
        static void Main(string[] args)
        {
            string response = "";
            int answer1;
            int answer2;
            int result = 0;

            Console.WriteLine("Would you like to add or subtract today?");
            response = Console.ReadLine();
            if (response=="add")      //double equals to compare input
            {
                Console.WriteLine("Please enter your first number:");
                response = Console.ReadLine();
                if (int.TryParse(response, out answer1))
                {
                    Console.WriteLine("Please enter your second number:");
                    response = Console.ReadLine();
                    if (int.TryParse(response, out answer2))
                    {
                        result = AddFunction(answer1, answer2);
                    }
                }
            }
            Console.WriteLine("Your answer is " + result + ".");
            Console.ReadLine();
        }
    }
}
