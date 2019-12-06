using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class TwoDeckShip : OneDeckShip
    {
        readonly Vector vector = new Vector();

        public override bool CheckSpace(int number, string[,] array, int i, int j)
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
