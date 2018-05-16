using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon002
{
    class Program
    {
        static void Main(string[] args)
        {
            int wanteat = 0;
            int buy = 0;
            int change = 0;
            Console.Write("輸入想吃糖果數量 :");
            string input = Console.ReadLine();
            wanteat = int.Parse(input);
            while(wanteat > 0)
            {
                wanteat -= 1;
                buy += 1;
                change += 1;
                if(change % 3 == 0)
                {
                    wanteat -= 1;
                    change += 1;
                }   
            }
            Console.WriteLine("可買顆數 :" + buy);
            Console.WriteLine("可換顆數 :" + change / 3);
            Console.ReadLine();    
        }
    }
}
