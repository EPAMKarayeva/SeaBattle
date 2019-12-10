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
            const int row = 12;
            const int column = 12;
            string[,] array = new string[row, column];

            CreateBorder(array);
            Random random = new Random();

            FourDeckShip fourDeckShip = new FourDeckShip();
            fourDeckShip.GenerateShip(1, array, random);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j]);
                }

                Console.WriteLine("");
            }


            ThreeDeckShip threeDeckShip = new ThreeDeckShip();
            threeDeckShip.GenerateShip(2, array, random);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j]);
                }

                Console.WriteLine("");
            }

            OneDeckShip ship = new OneDeckShip();
            ship.GenerateShip(4, array, random);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j]);
                }

                Console.WriteLine("");
            }

            TwoDeckShip twoDeskShip = new TwoDeckShip();
            twoDeskShip.GenerateShip(3, array, random);

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


        static void CreateBorder(string[,] array)
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

                    if (i != 0 && i != array.GetLength(0) - 1 && j != 0 && j != array.GetLength(1) - 1)
                    {
                        array[i, j] = " ";
                    }
                }

            }

        }

    }
}
