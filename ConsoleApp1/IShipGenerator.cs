using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IShipGenerator
    {
        void GenerateShip(string[,] array);

        void GenerateCoordinats(string[,] array, out int i, out int j);

        void CheckCoordinats(int i, int j, string[,] array);
    }
}
