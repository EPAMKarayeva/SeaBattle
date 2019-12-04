using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

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

                if (CheckSpace(number, array, i, j, random))
                {
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
            }


            GenerateCoordinats(array, out int m, out int n, random);
            CheckCoordinate(m, n, array, random);
        }


        public bool CheckSpace(int number, string[,] array, int i, int j, Random random)
        {

            bool flag = true;

            for (int k = 0; k < 3; k++)
            {
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
                    break;
                }
                else
                {
                    flag = true;
                }
            }

            return flag;
        }

    }
}
