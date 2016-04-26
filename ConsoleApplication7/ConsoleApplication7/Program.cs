using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {

            string response = "r";
            while (response != "exit")
            {
                Console.WriteLine("Please type in your name?");
               
                response = Console.ReadLine();
                if (response =="exit")
                {
                    Console.WriteLine("Goodbye...");
                }


                else
                {
                    Console.WriteLine("Your name is " + response);

                }

            }



        }
    }
}
