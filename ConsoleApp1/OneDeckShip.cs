using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class OneDeckShip : Ship
    {
        public override bool CheckCoordinate(int i, int j, string[,] array, int count, out int number, Random random)
        {
            number = 0;

            if (CheckAroundIsFree(i, j, array))
            {
                return true;

            }

            return false;
        }
        public override void FillArray(string[,] array, int i, int j, int number, Random random)
        {
            array[i, j] = "x";
        }
    }
}

