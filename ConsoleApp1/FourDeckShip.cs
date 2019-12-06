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
      

        public override bool CheckSpace(int number, string[,] array, int i, int j)
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
            }

            return flag;
        }

    }
}
