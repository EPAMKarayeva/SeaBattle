using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class OneDeckShip
    {
        Vector vector = new Vector();
  
        public void GenerateShip(int count, string[,] array, Random random)
        {
            for (int m = 0; m < count; m++)
            {
                GenerateCoordinats(array, out int i, out int j, random);
                var test = CheckCoordinate(i, j, array, count, random);

                while (!test)
                {
                    GenerateCoordinats(array, out i, out j, random);
                    test = CheckCoordinate(i, j, array,count, random);
                }

            }
        }

        public void GenerateCoordinats(string[,] array, out int i, out int j, Random random)
        {
            i = random.Next(0, array.GetLength(0));
            j = random.Next(0, array.GetLength(1));
        }

        public bool CheckCoordinate(int i, int j, string[,] array, int count, Random random)
        {

            if (CheckAroundIsFree(i, j, array))
            {
                int number = vector.GenerateDirection(random);

                if (count == 4)
                {
                    array[i, j] = "x";
                    return true;
                }
                else
                {

                    if (CheckSpace(number, array, i, j))
                    {
                        array[i, j] = "x";
                        vector.ChooseDirection(number, i, j, random);
                        array[vector.x, vector.y] = "x";

                        if (count == 3)
                        {
                            return true;
                        }

                        if (count == 2)
                        {
                            var check = DoZigzag(count, array, vector, random);
                            while (!check)
                            {
                                check = DoZigzag(count, array, vector, random);
                            }
                            
                        }

                        if (count == 1)
                        {
                            
                            for (int h = 0; h < 2; h++)
                            {
                                var check = DoZigzag(count, array, vector, random);
                                while (!check)
                                {
                                    check=DoZigzag(count, array, vector, random);
                                }
                               
                            }

                        }

                        return true;
                    }
                }
            }

            return false;
        }

        public bool CheckAroundIsFree(int i, int j, string[,] array)
        {
            bool mark = true;

            for ( int k = i - 1; k <= i + 1; k++)
            {
                for (int m = j - 1; m <= j + 1; m++)
                {
                    if (k == i && j == m)
                    {
                        continue;
                    }

                    if (k < 0 || k >= array.GetLength(0)-1 || m >= array.GetLength(1)-1 || m < 0)
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
            return true;
        }


      
        public bool DoZigzag(int count, string [,]array, Vector vector, Random random)
        {
            

            int number = vector.GenerateDirection(random);
            vector.ChooseDirection (number, vector.x, vector.y, random);

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

