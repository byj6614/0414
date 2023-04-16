using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlideGame.SlideGame
{
    internal class Initial
    {
        public static int[,] Value()
        {
            int[] a =new int[25];
            int stack = -1; 
            int ran = 0;
            int[,] array = new int[5, 5];   //필드 배열 생성
            Random random= new Random();    //랜덤 함수

            for(int i=0;i<a.Length;i++)
            {
                a[i] = i;
            }

            for(int i=0;i<a.Length; i++)
            {
                int temp = a[i];
                ran = random.Next(0, 25);
                a[i] = a[ran];
                a[ran] = temp;
            }

            for(int i=0;i<array.GetLength(0);i++)
            {
                for(int y=0;y<array.GetLength(1);y++)
                {
                    stack++;
                    array[i,y] = a[stack];
                }
            }
            return array;
        }
    }
}
