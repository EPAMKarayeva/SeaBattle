using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FourDeckShip : OneDeckShip
    {
        readonly Vector vector = new Vector();

        public override void CheckCoordinate(int i, int j, string[,] array, Random random)
        {
            if (CheckAroundIsFree(i, j, array))
            {
                int number = vector.GenerateDirection(random);

                array[i, j] = "x";
                vector.ChooseDirection(number, i, j, random);
                array[vector.x, vector.y] = "x";


                for (int h = 0; h < 2; h++)
                {
                    vector.ChooseDirection(number, vector.x, vector.y, random);
                    array[vector.x, vector.y] = "x";
                }

                return;
            }

            GenerateCoordinats(array, out int m, out int n, random);
            CheckCoordinate(m, n, array, random);
        }


    }
}
