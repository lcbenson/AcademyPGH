using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal first;
            decimal second;
            decimal difference;
            string response;

            Console.WriteLine("Please enter item cost");
            response = Console.ReadLine();

            decimal.TryParse(response, out first);

            Console.WriteLine("Please enter payment");
            response = Console.ReadLine();

            decimal.TryParse(response, out second);

            difference = second - first;
            CashDrawer(difference);
             
        }

        static void CashDrawer (decimal change)
        {
            int Twenty = 0;
            int Ten = 0;
            int Fives = 0;
            int Ones = 0;
            int Quarters = 0;
            int Dimes = 0;
            int Nickels = 0;
            int Pennies = 0;

            string result = "";
            while (change > 0)
            {
                if (change >= 20)
                {
                    Twenty++;
                    change -= 20;
                }
                else if (change >= 10)
                {
                    Ten++;
                    change -= 10;
                }
                else if (change >= 5)
                {
                    Fives++;
                    change -= 5;
                }
                else if (change >= 1)
                {
                    Ones++;
                    change -= 1;
                }
                else if (change >= .25m)
                {
                    Quarters++;
                    change -= .25m;
                }
                else if (change > .09m) 
                {
                    Dimes++;
                    change -= .10m;
                }
                else if (change >= .05m)
                {
                    Nickels++;
                    change -= .05m;
                }
                else if (change >= .01m)
                {
                    Pennies++;
                    change -= .01m;

                }
                //Console.WriteLine(change);

                //Console.ReadLine();
            }

                Console.WriteLine(" Your change is $" + Twenty + " Twentie(s)");
                Console.WriteLine(" Your change is $" + Ten + " Ten(s)");
                Console.WriteLine(" Your change is $" + Fives + " Five(s)");
                Console.WriteLine(" Your change is $" + Ones + " One(s)");
                Console.WriteLine(" Your change is $" + Quarters + " Quarter(s)");
                Console.WriteLine(" Your change is $" + Dimes + " Dimes(s)");
                Console.WriteLine(" Your change is $" + Nickels + " Nickel(s)");
                Console.WriteLine(" Your change is $" + Pennies + " Pennies(s)");

            Console.ReadLine();
        }

       

    }
   
}
