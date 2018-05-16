using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon004
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入 :");
            string text = Console.ReadLine();
            Function a = new Function();
            var b = a.Palindrome(text);
            if(b == true)
            { Console.WriteLine("是回文"); }
            else
            { Console.WriteLine("不是回文"); }

            Console.ReadLine();
        }
    }
}
