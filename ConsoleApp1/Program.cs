using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            const int row = 15;
            const int column = 30;
            string[,] array = new string[row, column];

            DrawBorder(array);
            GenerateOneDeckShip(array);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j]);
                }

                Console.WriteLine("");
            }

            Console.ReadKey();
        }

        static void GenerateOneDeckShip(string[,] array)
        {

            for (int m = 0; m < 4; m++)
            {

                GenerateCoordinats(array, out int i, out int j);
                CheckCoordinats(i, j, array);
                //Console.WriteLine("i:" + i + "\n" + "j: " + j);
            }

        }

        static void CheckCoordinats(int i, int j, string[,] array)
        {
            if (i >= 1 && i != array.GetLength(0) - 1 && j != array.GetLength(1) - 1 && j >= 1)
            {
                array[i, j] = "x";
                Console.WriteLine("i:" + i + "\n" + "j: " + j);
                Thread.Sleep(100);
            }
            else
            {
                GenerateCoordinats(array, out int m, out int n);
                CheckCoordinats(m, n, array);
            }
        }


        static void GenerateCoordinats(string[,] array, out int i, out int j)
        {

            Random random = new Random();
            
            i = random.Next(0, array.GetLength(0));
            j = random.Next(0, array.GetLength(1));

        }


        static void DrawBorder(string[,] array)
        {
          

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    if (i == 0 || i == array.GetLength(0) - 1)
                    {
                        array[i, j] = "=";
                    }

                    if (j == 0 || j == array.GetLength(1) - 1)
                    {
                        array[i, j] = "|";
                    }

                    //if (i == 1 || i == array.GetLength(0) - 2)
                    //{
                    //    DrawCircle(array);
                    //}

                    if (i != 0 && i != array.GetLength(0) - 1 && j != 0 && j != array.GetLength(1) - 1)
                    {
                        array[i, j] = " ";
                    }


                }
              

            }

        

        }

        //static void DrawCircle(string[,] array)
        //{

        //    for (int i = 0; i < array.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < array.GetLength(1); j++)
        //        {

        //            if ((i == 1 && j != 0 && j != (array.GetLength(1)) - 1) ||
        //                (i == array.GetLength(0) - 2 && j != (array.GetLength(1)) - 1) && j != 0)
        //            {
        //                array[i, j] = "o";
        //            }


        //            if ((j == 1 && i != 0 && i != array.GetLength(1) - 2) ||
        //                ((j == array.GetLength(1) - 2) && i != 0 && i != array.GetLength(1) - 1))
        //            {
        //                array[i, j] = "o";
        //            }
        //        }

        //    }

        //}
    }
}
