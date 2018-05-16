using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入年收入 :");
            string input = Console.ReadLine();
            decimal value = Convert.ToInt32(input);
            TaxRatelist a = new TaxRatelist();
            a.Tax(value);
            Console.ReadLine();
        }
        
    }
}
