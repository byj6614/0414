using SlideGame.SlideGame;
using System;

namespace SlideGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Initial initial = new Initial();
            Playerspace playerspace = new Playerspace(0, 0);
            Sinput sinput = new Sinput();
            SUpdate sUpdate = new SUpdate();
            SRender sRender = new SRender();
            int player = 0;
            int input = 0;
            int[,] array = new int[,] { };
            array = initial.Value();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int y = 0; y < array.GetLength(1); y++)
                {
                    if (array[i, y] == 0 )
                    {
                        player = array[i, y];
                        playerspace.y = i;
                        playerspace.x = y;
                    }
                    Console.Write(array[i, y] + "    ");
                }
                Console.WriteLine();
            }
            while (true)
            {
                //input
                input = sinput.sinput();
                //update
                sUpdate.supdate(array, player, input, playerspace);
                //sreder
                sRender.srender(array);
            }
            
           
        }
    }
}