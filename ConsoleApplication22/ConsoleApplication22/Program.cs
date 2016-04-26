using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;
            int answer;
            Random rnd = new Random();
            int guess;
            int counter = 0;
            bool keeprunning = true;
            guess = rnd.Next(101);
            Console.WriteLine("Let's play a game!\nPick a number from 1-100 and if you are close, I will tell you higher or lower!");

            while  (keeprunning)
            {
                response = Console.ReadLine();
                if (int.TryParse(response, out answer))
                {

                    {
                        if (answer == guess)
                        {
                            Console.WriteLine("You are amazing!");
                            keeprunning = false;
                        }
                        else if (answer > guess)
                        {
                            Console.WriteLine("You guessed too high!");
                        }
                        else if (answer < guess)
                        {
                            Console.WriteLine("You guessed too low!");
                        }
                        counter++;
                        Console.WriteLine("It took you " + counter + " guesses!");
                    }
                }

            }


            Console.ReadLine();
        }


        
    }
}
