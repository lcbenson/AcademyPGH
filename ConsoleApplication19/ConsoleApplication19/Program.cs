using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)


        {
            string response;
            int numeral;
            string printout = "";


            Console.WriteLine("Please enter a number");
            response = Console.ReadLine();
            if (int.TryParse(response, out numeral))
            {
                while (numeral > 0)
                //M = 1000 C = 100 L = 50 X = 10 V = 5 I = 1
                {
                    if (numeral >= 1000)
                    {
                        printout += "M";
                        numeral -= 1000;
                    }
                    else if (numeral >= 500)
                        {
                        printout += "D";
                        numeral -= 500;
                    }
                    else if (numeral >= 100)
                    {
                        printout += "C";
                        numeral -= 100;
                    }
                    else if (numeral >= 50)
                    {
                        printout += "L";
                        numeral -= 50;
                    }
                    else if (numeral >= 10)
                    {
                        printout += "X";
                        numeral -= 10;
                    }
                    else if (numeral >= 5)
                    {
                        if (numeral == 9)
                        {
                            printout += "IX";
                            numeral -= 9;
                        }
                        else
                        {
                            printout += "V";
                            numeral -= 5;
                        }
                    }
                    else if (numeral >= 1)
                    {
                        if (numeral == 4)
                        {
                            printout += "IV";
                            numeral -= 4;
                        }
                        else
                        {
                            printout += "I";
                            numeral -= 1;
                        }
                         }
                    }
                Console.WriteLine("This converts to " + printout + ".");

                }

            Console.ReadLine();
            }
           

        }
    }

