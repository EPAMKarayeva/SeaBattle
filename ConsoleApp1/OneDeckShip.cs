using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class OneDeckShip
    {
        public int count = 4;

        public void GenerateShip(string[,] array, Random random)
        {
            for (int m = 0; m < count; m++)
            {
                GenerateCoordinats(array, out int i, out int j, random);
                var test = CheckCoordinate(i, j, array, random);

                while (!test)
                {
                    GenerateCoordinats(array, out i, out j, random);
                    test = CheckCoordinate(i, j, array, random);
                }

                //CheckCoordinate(i, j, array, random);
            }
        }

        public void GenerateCoordinats(string[,] array, out int i, out int j, Random random)
        {
            i = random.Next(0, array.GetLength(0));
            j = random.Next(0, array.GetLength(1));
        }

        public virtual bool CheckCoordinate(int i, int j, string[,] array, Random random)
        {
            if (CheckAroundIsFree(i, j, array))
            {
                array[i, j] = "x";

                return true;
            }

            //GenerateCoordinats(array, out int m, out int n, random);
            //CheckCoordinate(m, n, array, random);

            return false;
        }

        public bool CheckAroundIsFree(int i, int j, string[,] array)
        {
            bool mark = true;

            array[10, 10] = "x";
            i = 9;
            j = 11;

            for (int k = i - 1; k <= i + 1; k++)
            {
                for (int m = j - 1; m <= j + 1; m++)
                {
                    if (k == i && j == m)
                    {
                        continue;
                    }

                    if (k <= 1 || k >= array.GetLength(0) - 1 || m >= array.GetLength(1) - 1 || m <= 1)
                    {
                        mark = false;
                        break;
                    }

                    if (array[k, j] != " ")
                    {
                        mark = false;
                        break;
                    }
                }

                j--;
            }

            return mark;

        }
    }
}
