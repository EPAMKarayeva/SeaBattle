using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class ThreeDeckShip : Ship
    {

        public override bool CheckSpace(int number, string[,] array, int i, int j)
        {
            bool flag = true;

            for (int k = 0; k < 2; k++)
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
            }

            return flag;
        }

        public override void FillArray(string[,] array, int i, int j, int number, Random random)
        {

            array[i, j] = "x";

            vector.ChooseDirection(number, i, j);
            array[vector.x, vector.y] = "x";

            var check = DoZigzag(array, vector, random);

            while (!check)
            {
                check = DoZigzag(array, vector, random);
            }

        }


        public bool DoZigzag(string[,] array, Vector vector, Random random)
        {
            int number = vector.GenerateDirection(random);

            vector.ChooseDirection(number, vector.x, vector.y);

            if (array[vector.x, vector.y] == "x")
            {
                return false;
            }

            if (vector.x <= 0 || vector.y <= 0 || vector.x > array.GetLength(0) - 1 || vector.y > array.GetLength(1) - 1)
            {
                return false;
            }

            else
            {
                array[vector.x, vector.y] = "x";
                return true;
            }
        }
    }
}
