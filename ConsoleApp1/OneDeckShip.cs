using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class OneDeckShip : IShipGenerator
    {
        public void CheckCoordinats(int i, int j, string[,] array)
        {
            if (i >= 1 && i != array.GetLength(0) - 1 && j != array.GetLength(1) - 1 && j >= 1)
            {
                array[i, j] = "x";
                Console.WriteLine("i:" + i + "\n" + "j: " + j);
                Thread.Sleep(100);
            }
            else
            {
                GenerateCoordinats(array, out int m, out int n);
                CheckCoordinats(m, n, array);
            }
        }

        public void GenerateCoordinats(string[,] array, out int i, out int j)
        {
            Random random = new Random();

            i = random.Next(0, array.GetLength(0));
            j = random.Next(0, array.GetLength(1));

        }

        public void GenerateShip(string[,] array)
        {
            for (int m = 0; m < 4; m++)
            {

                GenerateCoordinats(array, out int i, out int j);
                CheckCoordinats(i, j, array);
                //Console.WriteLine("i:" + i + "\n" + "j: " + j);
            }
        }
    }
}
