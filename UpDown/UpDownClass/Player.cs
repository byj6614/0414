using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpDown.UpDownClass
{
    internal static class Player
    {
        public static void player() 
        {
            UpDown upDown= new UpDown();
            int num = NumRand.Num();
            int me;
            string retry;
            r:
            Console.Clear();
            for (int i = 0; i <= 4; i++)
            {

                if (i == 4)
                {
                    Console.WriteLine("You Lose");
                    Console.WriteLine("Re Try?");
                    Console.WriteLine("YES:R   NO:N");
                    retry= Console.ReadLine();
                    if(retry=="r")
                    {
                        goto r;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    me = int.Parse(Console.ReadLine());
                    if (upDown.updown(me, num) == 0)
                    {
                        Console.WriteLine("Clear");
                        break;
                    }
                    else if (upDown.updown(me, num) == 1)
                    {
                        Console.WriteLine("Down");
                    }
                    else if (upDown.updown(me, num) == -1)
                    {
                        Console.WriteLine("Up");
                    }
                }

            }
        }
    }
}
