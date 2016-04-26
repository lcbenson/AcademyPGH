using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ask for name
            //name > 10 letters
            //if name between 3-8 letters say "your name is short"
            //if your name is longer than 15 say "your name is long"


            Console.WriteLine("Please type in your name");
            string response;
            response = Console.ReadLine();
            int name = response.Length;

           if (name >= 3 && name <= 8)
            {
                Console.WriteLine ("Your name is short");
            }
            else if (name >= 9 && name <= 15)
            {
                Console.WriteLine("Your name is average in length");
            }
           else if (name >=15)
            {
                Console.WriteLine("Your name is loooonnnnggg");
            }
            Console.ReadLine();

        }
    }
}
