using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterHomework004
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入一串逗號分隔的整數");
            string input = Console.ReadLine();
            var a = input.Split(',');
            var c = new List<int>();
            foreach (var item in a)
            {
                c.Add(Convert.ToInt32(item));
            }
            var d = c.OrderBy((x) => x);

            List<int> num2 = new List<int>();
            List<int> num1 = new List<int>();
            foreach (var item in d)
            {
                if(item % 2 == 0)
                {
                    num2.Add(item);
                }
                else
                {
                    num1.Add(item);
                }
            }
            Console.Write("偶數為 :");
            foreach (var item in num2)
            {
                Console.Write(item + ",");
            }
            Console.Write("\n奇數為 :");
            foreach (var item in num1)
            {
                Console.Write(item + ",");
            }
            Console.ReadLine();
        }
        
    }
}



          /*var b = new int[a.Length]; // 宣告整數陣列，個數與a陣列相同
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = Convert.ToInt32(a[i]);    //a陣列每個數轉換放b陣列之索引
            }
            Array.Sort(b); // b陣列排序
            // b陣列分為奇偶
            */








          /*var n2 = number2.Split(',');
            var n1 = number1.Split(',');
            var n22 = n2.ToString().ToCharArray();
            var n11 = n1.ToString().ToCharArray();

            
            for (int i = 0; i <= n2.Length; i++)
            {
                for (int j = 0; j < n2.Length-1; j++)
                {
                    if(n22[j]>n22[j+1])
                    {
                        int temp = n22[j];
                        int temp1 = n22[j + 1];
                        n22[j] = n22[j + 1];
                        n22[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine(n22);
            */

















//var a = input.Split(',');
//var os = from o in a
//         where o
//string odds = "";
//string evens = "";
//foreach(string s in a)
// {
//     var n = Convert.ToInt32(s);
//     if(n%2 == 0) // even
//        {
//               evens += n + ",";
//        }
//        else
//        {
//              odds += n + ",";
//        }
//  }
//evens = evens.Substring(0, evens.Length - 1);
//odds = odds.Substring(0, odds.Length - 1);