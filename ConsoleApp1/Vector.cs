using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Vector
    {
        public int x;
        public int y;

        public int GenerateDirection(Random random)
        {
            int count = random.Next(1, 4);

            return count;
        }

        public void ChooseDirection(int count, int i, int j, Random random)
        {
            this.x = i;
            this.y = j;

            switch (count)
            {
                case 1:
                    x += 1;
                    break;
                case 2:
                    x -= 1;
                    break;
                case 3:
                    y += 1;
                    break;
                case 4:
                    y -= 1;
                    break;
            }


        }

        public void DontComeback(int number, int i, int j)
        {

        }

    }
}
