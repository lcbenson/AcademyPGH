using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
      
            

            string whatcircle = "What is the radius of the circle?";
            //string whatcolor = "What color would you like to paint your circle?";



            // Red = 100 sq ft/bucket              
            // Blue = 120 sq ft/bucket    
            // Green = 90 sq ft/bucket   
            // Yellow = 70 sq ft/bucket 
            //area=radius*math.PI

            int length;
            Console.WriteLine(whatcircle);
            string radius = Console.ReadLine();
            length = Convert.ToInt16(radius);

           // Console.WriteLine(whatcolor);
            //string color = Console.ReadLine();

            double circle;
            circle = length * length  * Math.PI;

            double buckets;
            buckets = Math.Ceiling(circle / 100);

            //.WriteLine("You will need " + buckets + " buckets to paint your circle.");

            Console.WriteLine("Some colors are more expensive than others,\n"
            +"Red = 100 sq ft / $25 bucket \nBlue = 120 sq ft / $28 bucket \n" 
                + "Green = 90 sq ft / $33 bucket \nYellow = 70 sq ft / $22 bucket");
            

            Console.WriteLine("Color Choices: 1=Red 2=Blue 3=Green 4=Yellow");
            Console.Write("Please enter your selection: ");
            string str = Console.ReadLine();

            double red = Math.Ceiling (circle / 100);
            double blue = Math.Ceiling (circle / 120);
            double green = Math.Ceiling (circle / 90);
            double yellow = Math.Ceiling (circle / 70);


            switch (str)
            {
                case "1":
                case "red":
                    Console.WriteLine("If you paint with red paint you will need " + red
                        + " buckets and it will cost $ " + (red * 25));
                    break;

                case "2":
                case "blue":
                    Console.WriteLine("If you paint with blue paint you will need " + blue
                        + " buckets and it will cost $ " + (blue * 28));
                    break;

                case "3":
                case "green":
                    Console.WriteLine("If you paint with green paint you will need " + green
                        + " buckets and it will cost $ " + (green * 33));
                    break;

                case "4":
                case "yellow":
                    Console.WriteLine("If you paint with yellow paint you will need " + yellow
                        + " buckets and it will cost $ " + (yellow * 22));
                    break;


                default:
                    Console.WriteLine("Please try again");
                    break;
            }


            Console.ReadLine();
        }
    }
}
