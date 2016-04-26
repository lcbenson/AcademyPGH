using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            int fibo = 1;
            int nacci = 1;
            while (number <= 30)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(fibo);
                    nacci = fibo + nacci;
                }
                else
                {
                    Console.WriteLine(nacci);
                    fibo = nacci + fibo;
                }
                number++;
            }

            Console.ReadLine();
        }
    }

    }

