using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_LED
{
    class ConsoleLED
    {
        public ConsoleLED() // constructor
        {
            CreateList();
        }

       Dictionary<int, string> list1 = new Dictionary<int, string>();
       Dictionary<int, string> list2 = new Dictionary<int, string>();
       Dictionary<int, string> list3 = new Dictionary<int, string>();
       public void CreateList() // 建立LED顯示字串
        {
            list1.Add(0, " _ ");
            list2.Add(0, "| |");
            list3.Add(0, "|_|");
            list1.Add(1, "   ");
            list2.Add(1, " | ");
            list3.Add(1, " | ");
            list1.Add(2, " _ ");
            list2.Add(2, " _|");
            list3.Add(2, "|_ ");
            list1.Add(3, " _ ");
            list2.Add(3, " _|");
            list3.Add(3, " _|");
            list1.Add(4, "   ");
            list2.Add(4, "|_|");
            list3.Add(4, "  |");
            list1.Add(5, " _ ");
            list2.Add(5, "|_ ");
            list3.Add(5, " _|");
            list1.Add(6, " _ ");
            list2.Add(6, "|_ ");
            list3.Add(6, "|_|");
            list1.Add(7, " _ ");
            list2.Add(7, "| |");
            list3.Add(7, "  |");
            list1.Add(8, " _ ");
            list2.Add(8, "|_|");
            list3.Add(8, "|_|");
            list1.Add(9, " _ ");
            list2.Add(9, "|_|");
            list3.Add(9, " _|");
        }

        // 處理顯示LED數字
        public void DisplayLED(string input)
        {
            // 取出所有位數
            var a = input.ToArray();
            foreach (var item in a)
            {
                var key = item - '0'; //ASCII 內碼相減  '1'-'0'= 1 
                Console.Write(list1[key]);
            }
            Console.WriteLine();
            foreach (var item in a)
            {
                var key = Convert.ToInt32(item.ToString());
                Console.Write(list2[key]);
            }
            Console.WriteLine();
            foreach (var item in a)
            {
                var key = item - '0';
                Console.Write(list3[key]);
            }
        }
    }
}
