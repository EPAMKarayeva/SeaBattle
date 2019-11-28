using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IShipGenerator
    {
        void GenerateShip(string[,] array, Random random);

        void GenerateCoordinats(string[,] array, out int i, out int j, Random random);

        void CheckCoordinats(int i, int j, string[,] array, Random random);
        
    }
}
