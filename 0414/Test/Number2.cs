using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0414.Test
{
    internal class Number2
    {
        public static void Test2()
        {
            Console.Write("문자열 입력 : ");
            string a = Console.ReadLine();
            Console.Write("문자열 갯수 : ");
            char c = ' ';
            int b = a.Count(f => f == c) + 1;
            Console.WriteLine(b);
        }
    }
}
