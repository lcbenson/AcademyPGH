using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            int w, x, y, z;
            string[,] strShip;
            string[,] strShipLoc;
            string[,,] shipsink;
            String line = "";
            string response;
            bool keeplooping = true;
            bool keepattacking = true;
            string message;

            strShip = new string[8, 8];
            strShipLoc = new string[8, 8];
            shipsink = new string[5, 8, 8];

      

            w = 0;
            message = "";

            while (keepattacking)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Battleship!");
                Console.WriteLine("\n");

                x = 0;
                y = 0;

                Console.Write("    X     0     1     2     3     4     5     6     7" + "\n");
                Console.Write("\n");
                Console.Write("Y\n");
                Console.Write("\n");

                z = 0;

                while (y <= 7)
                {
                    while (x <= 7)
                    {
                        line = line + "     " + strShip[y, x];
                        x = x + 1;
                    }

                    Console.Write(z + "    " + line + "\n");
                    Console.Write("\n");
                    line = "";
                    y = y + 1;
                    x = 0;
                    z = z + 1;
                }

                System.IO.StreamReader file = new System.IO.StreamReader("./TextFile1.txt");
                while ((line = file.ReadLine()) != null)
                {

                    Console.Write("\n");

                    Console.WriteLine(message);
                    Console.Write("\n");

                    Console.WriteLine("Please enter x coordinate to attack ship!");
                    response = Console.ReadLine();

                    keeplooping = true;

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

                    if (strShipLoc[y, x] == "*")
                    {
                        message = "It's a hit!";
                        strShip[y, x] = "*";

                        //C - Cruiser 2 Squares
                        strShipLoc[0, 0] = "*";
                        strShipLoc[0, 1] = "*";

                        //D - Destroyer Three Squares
                        strShipLoc[4, 0] = "*";
                        strShipLoc[5, 0] = "*";
                        strShipLoc[6, 0] = "*";

                        //S - Sub Three Squares
                        strShipLoc[7, 1] = "*";
                        strShipLoc[7, 2] = "*";
                        strShipLoc[7, 3] = "*";

                        //C - Battleship Four Squares
                        strShipLoc[2, 4] = "*";
                        strShipLoc[3, 4] = "*";
                        strShipLoc[4, 4] = "*";
                        strShipLoc[5, 4] = "*";

                        //A - Aircraft Carrier - Five Squares
                        strShipLoc[3, 6] = "*";
                        strShipLoc[4, 6] = "*";
                        strShipLoc[5, 6] = "*";
                        strShipLoc[6, 6] = "*";
                        strShipLoc[7, 6] = "*";
                    }
                    else
                    {
                        message = "You missed!";
                        strShip[y, x] = "0";

                        x = 0;
                        y = 0;

                    }

                    while (x <= 7)
                    {
                        while (y <= 7)
                        {
                            if (strShipLoc[y, x] == "*" && strShip[y, x] == "*")
                            {
                                w = w + 1;
                            }
                            y = y + 1;
                        }
                        x = x + 1;
                        y = 0;
                    }

                    if (w == 2)
                    {
                        keepattacking = false;
                    }
                }
            }

            Console.WriteLine("Gameover!!!");
            Console.ReadLine();
        }
    }
}
