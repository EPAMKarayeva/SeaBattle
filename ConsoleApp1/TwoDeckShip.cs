using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class TwoDeckShip : OneDeckShip
    {
        readonly Vector vector = new Vector();

        public override bool CheckCoordinate(int i, int j, string[,] array, Random random)
        {
            if (CheckAroundIsFree(i, j, array))
            {
                int number = vector.GenerateDirection(random);
                if (CheckSpace(number, array, i, j))
                {
                    array[i, j] = "x";
                    vector.ChooseDirection(number, i, j, random);
                    array[vector.x, vector.y] = "x";

                    return true;
                }

            }

            //GenerateCoordinats(array, out int m, out int n, random);
            //CheckCoordinate(m, n, array, random);
            return false;
        }

        public bool CheckSpace(int number, string[,] array, int i, int j)
        {
            bool flag = true;

            switch (number)
            {
                case 1:
                    i += 1;
                    break;
                case 2:
                    i -= 1;
                    break;
                case 3:
                    j += 1;
                    break;
                case 4:
                    j -= 1;
                    break;

            }

            if (!CheckAroundIsFree(i, j, array))
            {
               flag = false;
            }
            

            return flag;
        }

    }
}
