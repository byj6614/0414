using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlideGame.SlideGame
{
    internal class Sinput
    {
        public static int sinput()
        {
            ConsoleKeyInfo info= Console.ReadKey();
            int a;
            switch(info.Key)
            {
                case ConsoleKey.UpArrow:
                    a = 1;
                    break;
                    case ConsoleKey.DownArrow:
                    a = 2;
                    break;
                    case ConsoleKey.LeftArrow:
                    a = 3;
                    break;
                    case ConsoleKey.RightArrow:
                    a = 4;
                    break;
                    default:
                    a = 0;
                    break;
            }
            return a;
        }
    }
}
