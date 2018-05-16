using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterHomework007
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入四位數的阿拉伯數字");
            string input = Console.ReadLine();
            var a = input.Replace("1", "壹").Replace("2", "貳").Replace("3", "參").Replace("4", "肆").Replace("5", "伍").Replace("6", "陸").Replace("7", "柒").Replace("8", "捌").Replace("9", "玖").Replace("0", "零");
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
