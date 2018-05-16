using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("猴子隻數 :");
            string input = Console.ReadLine();
            int length = int.Parse(input);
            int[] Monkey = new int[length];
            Console.Write("猴子第幾隻剔除 :");
            string input1 = Console.ReadLine();
            int Kickout = int.Parse(input1);

            for (int i = 0; i < length; i++) //每隻猴子去放值
            {
                Monkey[i] = i + 1;
            }

            int outnumber = 0;    //離開的猴子數量
            int m = 0;            //索引值
            int j = 0;            //數的數量(123,123...)
            while(outnumber < length - 1)
            {
                if(Monkey[m] != 0)
                {
                    j++;
                }

                if(j == Kickout)
                {
                    Monkey[m] = 0;
                    outnumber++;
                    j = 0;        //重新找下個值
                }
                m++;
                if (m == length)
                { m = 0;}         //最後重新數
            }
            for (int i = 0; i < length; i++)
            {
                if(Monkey[i] != 0)
                {
                    int a = i + 1;
                    Console.WriteLine($"第{a.ToString()}隻猴子為大王");
                }
            }
            Console.ReadLine();
        }
        
    }
}











//int M = 100;
//int n = 3;
//int k = 0;
//for (int i = 2; i <= M; i++)
//{
//    k = (k + n) % i;
//}
//++k;
//Console.WriteLine(k);
//Console.ReadLine();


//class KingMonkey
//{
//    int _m;
//    int _n;
//    List<bool> _monkeys;

//    public KingMonkey(int m, int n)
//    {
//        _m = m;
//        _n = n;
//        _monkeys = new List<bool>();
//        for (int i = 0; i < m; i++) // 初始為false(留在圈內)
//        {
//            _monkeys.Add(false);
//        }
//    }

//    public int FindKing()
//    {
//        int left = _m; // 剩下的猴子數
//        int index = 0; // 初始猴子索引編號
//        while (left > 1) // 超過1隻以上繼續玩
//        {
//            int exit = index; // 離開的猴子索引編號
//            for (int i = 0; i < _n;)
//            {
//                if (_monkeys[index] == false) // 圈內猴子
//                {
//                    exit = index;
//                    index = (index + 1) % _m; // 超過_m返回0
//                    i++;
//                }
//                else // 圈外猴子
//                {
//                    index = (index + 1) % _m;
//                }
//            }
//            _monkeys[exit] = true;
//            left--;
//        }

//        for (int i = 0; i < _m; i++)
//        {
//            if (_monkeys[i] == false)
//            {
//                index = i + 1;
//                break;
//            }
//        }

//        return index;
//    }
//}
