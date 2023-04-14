using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0414.Test
{
    internal class Number5
    {
        static int[] Test5(int[] arr1, int[] arr2, int[] arr3)
        {
            int[] arr4 = new int[] { };
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int y = 0; y < arr2.Length; y++)
                {
                    if (arr1[i] == arr2[y])
                    {
                        for (int x = 0; x < arr3.Length; x++)
                        {
                            if (arr2[y] == arr3[x])
                            {
                                arr4[i] = arr3[x];
                                continue;
                            }
                            else
                                continue;
                        }
                    }
                    else
                        continue;
                }
            }
            return arr4;
        }
    }
}
