using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Ship
    {
        public Vector vector = new Vector();

        public void GenerateShip(int count, string[,] array, Random random)
        {
            for (int m = 0; m < count; m++)
            {

                GenerateCoordinats(array, out int i, out int j, random);
                var test = CheckCoordinate(i, j, array, count, out int number, random);

                while (!test)
                {
                    GenerateCoordinats(array, out i, out j, random);
                    test = CheckCoordinate(i, j, array, count, out number, random);
                }
                FillArray(array, i, j, number, random);


            }
        }

        public void GenerateCoordinats(string[,] array, out int i, out int j, Random random)
        {
            i = random.Next(0, array.GetLength(0));
            j = random.Next(0, array.GetLength(1));
        }

        public virtual bool CheckCoordinate(int i, int j, string[,] array, int count, out int number, Random random)
        {

            number = vector.GenerateDirection(random);

            if (CheckAroundIsFree(i, j, array))
            {
                if (CheckSpace(number, array, i, j))
                {
                    return true;
                }
            }

            return false;
        }

        public abstract void FillArray(string[,] array, int i, int j, int number, Random random);

        public bool CheckAroundIsFree(int i, int j, string[,] array)
        {
            bool mark = true;

            for (int k = i - 1; k <= i + 1; k++)
            {
                for (int m = j - 1; m <= j + 1; m++)
                {
                    if (k == i && j == m)
                    {
                        continue;
                    }

                    if (k < 0 || k >= array.GetLength(0) - 1 || m >= array.GetLength(1) - 1 || m < 0)
                    {
                        mark = false;
                        break;
                    }

                    if (array[k, m] == "x")
                    {
                        mark = false;
                        break;
                    }
                }

            }

            return mark;

        }

        public virtual bool CheckSpace(int number, string[,] array, int i, int j)
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
