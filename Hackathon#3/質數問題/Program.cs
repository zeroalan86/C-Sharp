using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon001
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 101; i <= 200; i++)
            {
                for (int j = 2; j <= Convert.ToInt32(Math.Sqrt(i)); j++)
                {
                    if (i % j == 0)
                    { break; }
                    else if(i % j !=0 && j == Convert.ToInt32(Math.Sqrt(i)))//消除重複的質數
                    { Console.WriteLine(i); }
                }
            }
            Console.ReadLine();
        }
    }
}
