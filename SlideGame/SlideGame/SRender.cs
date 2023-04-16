using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlideGame.SlideGame
{
    internal class SRender
    {
        public void srender(int[,] a)
        {
            Console.Clear();
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int y=0;y<a.GetLength(1);y++)
                {
                    Console.Write(a[i,y]+"    ");
                }
                Console.WriteLine();
            }
        }
    }
}
