using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProperGOL
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] somearray = new int[10] { 2, 6, 3, 7, 1, 4, 8, 0, 3, 5 };
            Array.Sort(somearray);
            
            foreach (int newint in somearray)
            {
               Console.WriteLine(newint);
            }

           



            Console.ReadLine();
           
        }
    }
}
