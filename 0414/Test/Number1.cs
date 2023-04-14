using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0414.Test
{
    internal class Number1
    {
        public static void Test1()
        {
            Console.Write("문장을 입력 : ");
            string str = Console.ReadLine();
            Console.Write("단어를 입력 : ");
            string str2 = Console.ReadLine();
            int num = str.IndexOf(str2);
            Console.Write("단어가 들어간 공간 : {0}", num);
        }
    }
}
