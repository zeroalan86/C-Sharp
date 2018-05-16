using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterHomework003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入整數數字");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {
                string a = "";
                for (int j = 0; j <= i; j++)
                {
                    a += num - i;
                }
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}
