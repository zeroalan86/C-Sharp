using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using Hackathon007.Models;

namespace Hackathon007
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "test03.txt";
            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                foreach (var item in lines)
                {
                    if (item.StartsWith("695") || item.StartsWith("525"))
                    {
                        if ((DateTime.TryParseExact(item.Substring(13, 8), "yyyyMMdd", null, DateTimeStyles.None, out DateTime result) &&
                           (DateTime.TryParseExact(item.Substring(21, 8), "yyyyMMdd", null, DateTimeStyles.None, out DateTime result1))))
                        {
                            ReadtestTable data = new ReadtestTable()
                            {
                                TickNumber = item,
                                Flying_Day = result,
                                Birthday = result1
                            };
                            try
                            {
                                ReadtestModel datas = new ReadtestModel();
                                datas.ReadtestTable.Add(data);
                                datas.SaveChanges();
                                Console.WriteLine(result);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"發生錯誤{ex.ToString()}");
                            }
                        }
                    }
                }
            }
            else
            { Console.WriteLine("檔案不存在"); }
            Console.ReadLine();
        }
    }
}
