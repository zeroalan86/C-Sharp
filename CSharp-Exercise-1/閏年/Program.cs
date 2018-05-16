using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterHomework005
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入中華民國年份");
            string input = Console.ReadLine();
            int year = int.Parse(input) + 1911;
            if(year % 4 != 0)
            {
                Console.WriteLine("平年");
            }
            else
            {
                if(year % 100 != 0)
                {
                    Console.WriteLine("閏年");
                }
                else if(year % 400 == 0)
                {
                    Console.WriteLine("閏年");
                }
                else
                {
                    Console.WriteLine("平年");
                }
            }
            Console.ReadLine();

        }
    }
}
