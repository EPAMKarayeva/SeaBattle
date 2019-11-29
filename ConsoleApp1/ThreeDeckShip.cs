﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ThreeDeckShip : IShipGenerator
    {
        Vector vector = new Vector();

        public void CheckCoordinats(int i, int j, string[,] array, Random random)
        {
            
            if (i >= 1 && i != array.GetLength(0) - 1 && j != array.GetLength(1) - 1 && j >= 1)
            {
                if (array[i, j] == " " && array[i, j - 1] == " " && array[i - 1, j] == " " && array[i + 1, j] == " " && array[i, j + 1] == " " &&
                   array[i, j - 2] == " " && array[i - 2, j] == " " && array[i + 2, j] == " " && array[i, j + 2] == " " && array[i + 1, j + 1] == " " &&
                   array[i, j - 3] == " " && array[i - 3, j] == " " && array[i + 3, j] == " " && array[i, j + 3] == " " && array[i - 1,j - 1]==" ")
                {
                    int count = vector.GenerateDirection(random);

                    array[i, j] = "x";   
                    vector.ChooseDirection(count, i, j, random);
                    array[vector.x, vector.y] = "x";
                    vector.ChooseDirection(count, vector.x, vector.y, random);
                    array[vector.x, vector.y] = "x";

                    return;
                }
            }

            GenerateCoordinats(array, out int m, out int n, random);
            CheckCoordinats(m, n, array, random);
        }

        public void GenerateCoordinats(string[,] array, out int i, out int j, Random random)
        {
            i = random.Next(0, array.GetLength(0));
            j = random.Next(0, array.GetLength(1));
        }

        public void GenerateShip(string[,] array, Random random)
        {
            for (int x = 0; x < 3; x++)
            {
                GenerateCoordinats(array, out int m, out int n, random);
                CheckCoordinats(m, n, array, random);
            }
        }
    }
}
