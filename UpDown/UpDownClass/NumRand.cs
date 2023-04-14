using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpDown.UpDownClass
{
    internal static class NumRand
    {
        public static int Num()
        {
            Random random = new Random();
            int randnum = random.Next(0, 999);
            return randnum;
        }
       
        
    }
}
