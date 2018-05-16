using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework001
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 47; i++)
            {
                Console.WriteLine(F(i));
            }
            Console.ReadLine();
        }

        private static long F(long n)
        {
            if (n <= 2)
            { return 1; }
            else
            { return F(n - 1) + F(n - 2); }
        }
    }
}









//int[] nums = new int[] { 1,2,3,4,5,6,7,8,9,10
//                       ,11,12,13,14,15,16,17,18,19,20
//                       ,21,22,23,24,25,26,27,28,29,30
//                       ,31,32,33,34,35,36,37,38,39,40
//                       ,41,42,43,44,45,46 };
//long[] fib = new long[100];
//fib[0] = 0;
//fib[1] = 1;
//for (int i = 2; i < fib.Count(); i++)
//{
//    fib[i] = fib[i - 1] + fib[i - 2];
//}

//for (int j = 0; j < nums.Count(); j++)
//{
//    Console.WriteLine("F({0}) = {1}", nums[j], fib[nums[j]]);
//}
