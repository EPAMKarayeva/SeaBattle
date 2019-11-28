﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            const int row = 15;
            const int column = 30;
            string[,] array = new string[row, column];

            DrawBorder(array);
            OneDeckShip ship = new OneDeckShip();
            ship.GenerateShip(array);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j]);
                }

                Console.WriteLine("");
            }

            Console.ReadKey();
        }

     
        static void DrawBorder(string[,] array)
        {
          
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    if (i == 0 || i == array.GetLength(0) - 1)
                    {
                        array[i, j] = "=";
                    }

                    if (j == 0 || j == array.GetLength(1) - 1)
                    {
                        array[i, j] = "|";
                    }


                    if (i != 0 && i != array.GetLength(0) - 1 && j != 0 && j != array.GetLength(1) - 1)
                    {
                        array[i, j] = " ";
                    }

                }        

            }      

        }

    }
}