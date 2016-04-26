using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            name = Console.ReadLine();
            if (name.Contains("a"))
            {
                Console.WriteLine("You have an 'a' in your name.");
            }
        
            if (name.Contains("a") ==false) 
            {
                Console.WriteLine("You do not have an 'a' in your name.");
            }

            if (name.Length < 10)

            { Console.WriteLine("Your name is less than 10 letters!"); }
            Console.ReadLine();

        }
    }
}
