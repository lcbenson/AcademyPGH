using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            string[,] strShip;
            String line = "";
            string response;
            bool keeplooping = true;
            bool keepattacking = true;

            strShip = new string[8, 8];


            x = 0;
            y = 0;

            while (x <= 7)
            {
                while (y <= 7)
                {
                    strShip[x, y] = "0";
                    y = y + 1;
                }
                x = x + 1;
                y = 0;
            }

            x = 0;
            y = 0;

            strShip[0, 0] = "x";
            strShip[0, 3] = "x";
            strShip[0, 4] = "x";
            strShip[0, 5] = "x";
            strShip[0, 6] = "x";
            strShip[1, 0] = "x";
            strShip[1, 7] = "x";
            strShip[2, 7] = "x";
            strShip[3, 2] = "x";
            strShip[3, 3] = "x";
            strShip[3, 4] = "x";
            strShip[4, 5] = "x";
            strShip[4, 7] = "x";
            strShip[5, 5] = "x";
            strShip[5, 7] = "x";
            strShip[6, 5] = "x";
            strShip[6, 7] = "x";
            strShip[7, 5] = "x";

            while (y <= 7)
            {


                while (x <= 7)
                {
                    line = line + "     " + strShip[x, y];
                    x = x + 1;

                }

                Console.Write(line + "\n");
                line = "";
                y = y + 1;
                x = 0;
            }

            while (keepattacking)
            {
                Console.WriteLine("Please enter x coordinate to attack ship!");
                response = Console.ReadLine();


                while (keeplooping)
                {
                    if (int.TryParse(response, out x))
                    {
                        keeplooping = false;
                    }
                }

                Console.WriteLine("Please enter y coordinate to attack ship!");
                response = Console.ReadLine();

                keeplooping = true;

                while (keeplooping)
                {
                    if (int.TryParse(response, out y))
                    {
                        keeplooping = false;
                    }
                }

                if (strShip[y, x] == "0")
                {
                    Console.WriteLine("You missed!");
                }
                else
                {
                    Console.WriteLine("It's a hit!");
                }


                Console.ReadLine();
            }

            //S - Sub 2 Squares
            //D - Destroyer Three Squares
            //C - Cruiser.Four Squares
            //A - Aircraft Carrier - Five Squares
            //B - Battleship - Six Squares
        }
    }
}
       