using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlideGame.SlideGame
{
    internal class SUpdate
    {
        public void supdate(int[,] a, int player, int input,Playerspace playerspace)//1:up,2:down,3left,4:right
        {

            int newplayer;
            int place1 = playerspace.y;
            int place2 = playerspace.x;
            if (input == 1)
            {
                playerspace.y--;
            }
            else if (input == 2)
            {
                playerspace.y++;
            }
            else if (input == 3)
            {
                playerspace.x--;
            }
            else if (input == 4)
            {
                playerspace.x++;
            }


            if (playerspace.y == 5 || playerspace.y == -1)
            {
                playerspace.y = place1;
                playerspace.x = place2;
                newplayer = a[playerspace.y, playerspace.x];
                a[playerspace.y, playerspace.x] = player;
                a[place1, place2] = newplayer;
            }
            else if (playerspace.x == 5 || playerspace.x == -1)
            {
                playerspace.y = place1;
                playerspace.x = place2;
                newplayer = a[playerspace.y, playerspace.x];
                a[playerspace.y, playerspace.x] = player;
                a[place1, place2] = newplayer;
            }
            else
            {
                newplayer = a[playerspace.y, playerspace.x];
                a[playerspace.y, playerspace.x] = player;
                a[place1, place2] = newplayer;
            }

        }
    }
}
