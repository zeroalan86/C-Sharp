using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterHomework002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入數字");
            string input = Console.ReadLine();
            Console.WriteLine("結果 :");
            var reversed = input.Reverse().ToArray();
            foreach (var item in reversed)
            {
                Console.Write(item);
            }
            Console.ReadLine();
        }
    }
}
