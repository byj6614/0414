using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0414.Test
{
    internal class Number4
    {
        public static int Test4(int a)
        {
            int b = 0;
            while (a > 0)
            {
                b = b + a % 10;
                a = a / 10;
            }
            return b;
        }
    }
}
