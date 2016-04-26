using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lifegame1
{
    class Program
    {


        static void Main(string[] args)

        {


            Random rnd = new Random();              //grid created, based on random numbers
            for (int i = 0; i < 20; i++)
            {
                int[,] setupGrid = new int[20, 20];
                int[,] newGrid = new int[20, 20];

                int j = 0;
                for (j = 0; j < 20; j++)
                {

                    int cell = rnd.Next(2);

                    setupGrid[i, j] = cell;

                    int neighbor = 0;


                    if (setupGrid[i, j] == 1)
                    {
                        neighbor = 0;
                    }
                    if ((i > 0) && (i < 19))
                    {
                        if (setupGrid[i - 1, j] == 1)
                        {
                            neighbor++;
                        }
                    }
                    if (i < 19)
                    {
                        if (setupGrid[i + 1, j] == 1)
                        {
                            neighbor++;
                        }
                    }
                    if ((i > 0) && (j > 0))
                    {
                        if (setupGrid[i - 1, j - 1] == 1)
                        {
                            neighbor++;
                        }
                    }
                    if ((i < 19) && (j > 0))
                    {
                        if (setupGrid[i + 1, j - 1] == 1)
                        {
                            neighbor++;
                        }
                    }
                    if (j > 0)
                    {
                        if (setupGrid[i, j - 1] == 1)
                        {
                            neighbor++;
                        }
                    }
                    if ((i > 0) && (j < 19))
                    {
                        if (setupGrid[i - 1, j + 1] == 1)
                        {
                            neighbor++;
                        }
                    }
                    if (j < 19)
                    {
                        if (setupGrid[i, j + 1] == 1)
                        {
                            neighbor++;
                        }
                    }
                    if ((i < 19) && (j < 19))
                    {
                        if (setupGrid[i + 1, j + 1] == 1)
                        {
                            neighbor++;
                        }
                    }

                    if (neighbor < 2)
                    {
                        newGrid[i, j] = 0;
                    }
                    else if (neighbor == 2)
                    {
                        newGrid[i, j] = 1;
                    }
                    else if (neighbor == 3)
                    {
                        newGrid[i, j] = 1;
                    }
                    else if (neighbor > 3)
                    {
                        newGrid[i, j] = 1;
                    }
                    else if ((setupGrid[i, j]) == 0 && (neighbor == 3))
                    {
                        newGrid[i, j] = 1;
                    }

                }
            }
            Console.Clear();
            int output = 0;
            for (int i = 0; i < 20; i++)
            {
                int[,] newGrid = new int[20, 20];

                int j = 0;
                for (j = 0; j < 20; j++)
                {


                    newGrid[i, j] = output;
                    Console.Write(output);

                }
                System.Threading.Thread.Sleep(100);
            }
        }
    }
}

