using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathons
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                string a = i.ToString();
                a = a.Replace("3", "A").Replace("5", "B").Replace("9", "C").Replace("0", "D");
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }

    }
    
}
