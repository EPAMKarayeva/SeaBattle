﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class OneDeckShip : IShipGenerator
    {
        readonly int count = 4;

        public void CheckCoordinats(int i, int j, string[,] array, Random random)
        {
            if (i >= 1 && i != array.GetLength(0) - 1 && j != array.GetLength(1) - 1 && j >= 1)
            {
                if (array[i, j] == " " && array[i, j - 1] == " " && array[i - 1, j] == " " && array[i + 1, j] == " " && array[i, j + 1] == " ")
                {
                    array[i, j] = "x";
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
          
            for (int m = 0; m < count; m++)
            {
                GenerateCoordinats(array, out int i, out int j, random);
                CheckCoordinats(i, j, array, random);
            }
        }

        //public void FillArray(string[,] array, int i, int j, Random random)
        //{
        //    if (array[i, j] == " " || array[i, j - 1] == " " || array[i - 1, j] == " " || array[i + 1, j] == " " || array[i, j + 1] == " ")
        //    {
        //        array[i, j] = "x";
        //        return;
        //    }
        //}
    }
}
