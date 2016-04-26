using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {

          
            int answer;
            //bool keeplooping = true;
            string response = prompt();
            int number1 = GetMeANumber();
            int number2 = GetMeANumber();
            int answer = AddNumbers(otherNumber1, otherNumber2);

            switch (response)
            {
                case a:
                    
                    
            }
            }


        
        static string prompt()
        {
                Console.WriteLine ("What would you like to do? \n a) Add \n b) Subtract \n c) Multiply \n d) Divide ");
                string response;
                response = Console.ReadLine();
                return response;
        }

    

    static int GetMeANumber()
                {
                    bool loop = true;
    int number = 0;
                    while (loop)
                    {
                        Console.WriteLine("Type in a number");
                        string answer = Console.ReadLine();
                        if (int.TryParse(answer, out number))
                        {
                            loop = false; // not needed because return leaves a function immediately
                                          // return number;
                        }
                    }
                    return number;

        static int AddNumbers(int number1, int number2)
        {
            int result = number1 + number2;
            return result;
        }
        static int SubtractNumbers(int number1, int number2)
        {
            int result = number1 + number2;
            return result;
        }
        static int MultiplyNumbers(int number1, int number2)
        {
            int result = number1 + number2;
            return result;
        }
        static int DivideNumbers(int number1, int number2)
        {
            int result = number1 + number2;
            return result;
        }
        }
    }
}


}