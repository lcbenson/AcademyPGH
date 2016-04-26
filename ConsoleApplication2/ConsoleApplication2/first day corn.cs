using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int area;
            int perimeter;
            int boxlength;
            int boxwidth;

            string w = "What is the length of your garden box?";
            string l = "what is the width of your box?";
            string carrots = "Carrots to be planted are ";
            string corn = "Corn to be planted is ";
            string beets = "Beets to be planted are ";
            string food = "Food makes me hungry, what do you want to plant?";

            Console.WriteLine(w);
            string length= Console.ReadLine();
            boxlength = Convert.ToInt16(length);

            Console.WriteLine(l);
            string width = Console.ReadLine();
            boxwidth = Convert.ToInt16(width);

            area = boxlength * boxwidth;
            perimeter = (boxlength * 2) + (boxwidth * 2);

            Console.WriteLine("Your area is " +area+ ". your perimeter is " +perimeter+".");

            Console.WriteLine(carrots + area);
            Console.WriteLine(corn + area * (3.0 / 16));
            Console.WriteLine(beets + area * (9.0/16));

            Console.WriteLine(food);

            string response = Console.ReadLine();
            if (response == "carrots")
            {
                Console.WriteLine(carrots + area);
            }

            if (response == "corn")
            {
                Console.WriteLine(corn + area * (3.0 / 16));
            }

            if (response == "beets")
            {
                Console.WriteLine(beets + area * (9.0 / 16));
            }

            Console.ReadLine();


            
             
        }
    }
}
