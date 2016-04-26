using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {

            //i =1 
            //v=5
            //x=10
            //L=50
            //C=100
            //D=500
            //M=1000

            //4 =iv
            //9=ix
            //8=vii
            //80=lxxx
            //139=cxxxix

            //int response;
            // int char


            Console.WriteLine("Please tell me your name and I will tell you it in Roman Numerals");
            //answer = Console.ReadLine();

            string answer = Console.ReadLine();
            //string answer:
            int number = Convert.ToInt16(answer);



            while (number > 10)
            {
                Console.Write("X");
                number -= 10;
            }
            while (number > 5)
            {
                Console.Write("V");
                number -= 5;
            }
            while (number > 1)
            {
                Console.Write("I");
                number -= 1;
            }
            Console.ReadLine();
            while (number >= 4)
            {
                Console.Write("4");
                number -= 4;
            }
        }
    }
    }
