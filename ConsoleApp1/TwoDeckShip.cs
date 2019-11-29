using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TwoDeckShip : IShipGenerator
    {
        public void CheckCoordinats(int i, int j, string[,] array, Random random)
        {
            Vector vector = new Vector();

            if (i >= 1 && i != array.GetLength(0) - 1 && j != array.GetLength(1) - 1 && j >= 1)
            {
                if (array[i, j] == " " && array[i, j - 1] == " " && array[i - 1, j] == " " && array[i + 1, j] == " " && array[i, j + 1] == " " &&
                   array[i, j - 2] == " " && array[i - 2, j] == " " && array[i + 2, j] == " " && array[i, j + 2] == " ")
                {
                    array[i, j] = "x";
                    int count =vector.GenerateDirection(random);
                    vector.ChooseDirection(count, i,j, random);
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

            for (int x = 0; x < 4; x++)
            {
                GenerateCoordinats(array, out int m, out int n, random);
                CheckCoordinats(m, n, array, random);
            }
        }

     
    }
}
