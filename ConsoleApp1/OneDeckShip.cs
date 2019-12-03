using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class OneDeckShip 
    {
        public int count = 2;

        public void GenerateShip(string[,] array, Random random)
        {
            for (int m = 0; m < count; m++)
            {
                GenerateCoordinats(array, out int i, out int j, random);
                CheckCoordinate(i, j, array, random);
            }
        }

        public void GenerateCoordinats(string[,] array, out int i, out int j, Random random)
        {
            i = random.Next(0, array.GetLength(0));
            j = random.Next(0, array.GetLength(1));
        }

        public virtual void CheckCoordinate(int i, int j, string[,] array, Random random)
        {
            if (CheckAroundIsFree(i, j, array))
            {
                array[i, j] = "x";
                return;
            }

            GenerateCoordinats(array, out int m, out int n, random);
            CheckCoordinate(m, n, array, random);
        }

        public bool CheckAroundIsFree(int i, int j, string[,] array)
        {
            bool mark = true;

            if (i >= 1 && i != array.GetLength(0) - 1 && j != array.GetLength(1) - 1 && j >= 1)
            {
                for (int k = i - 1; k <= i + 1; k++)
                {
                    for (int m = j - 1; m < j + 1; m++)
                    {
                        if (k == i && j == m)
                        {
                            continue;
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
            return false;


        }
    }
}
