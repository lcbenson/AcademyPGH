using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

                //Create a grid(an array with two dimensions) that is 8 by 8.

                //This grid will hold whether there is a ship in a given square or not.
                //You can use a bool or an int for this.You will need to be able to display this grid, with
                //00000000
                //0000*000
                //00**0000
                //00000000
                //000**000
                //*0*00000
                //00000**0
                //00****00


                //Let the user try to "shoot" a ship by selecting two coordinates (the column and the row)

                //When users shoot an enemy, clear the ship in that cell

                //When all enemies are gone, make the "game" end.

                // Bonus:

                // If user picks a cell next to a ship, say "close!"


                    //Create a grid(an array with two dimensions) that is 8 by 8.

                    //This grid will hold whether there is a ship in a given square or not.You can use a bool or an int for this.
                    //You will need to be able to display this grid, with
                    //00000000
                    //0000*000
                    //00**0000
                    //00000000
                    //000**000
                    //*0*00000
                    //00000**0
                    //00****00


                    //Let the user try to "shoot" a ship by selecting two coordinates (the column and the row)

                    //When users shoot an enemy, clear the ship in that cell

                    //When all enemies are gone, make the "game" end.

                    // Bonus:

                    // If user picks a cell next to a ship, say "close!"

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