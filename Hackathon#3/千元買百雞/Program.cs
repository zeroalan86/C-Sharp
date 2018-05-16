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
            int x = 0;
            int y = 0;
            int z = 0;
            while(60 * x+30 * y+z !=1000 && x+y+z !=100)
            {
                x++;
                if((900-59 * x)%29 == 0)
                {
                    y = (900 - 59 * x) / 29;
                    z = 100 - y - x;
                }
            }
            Console.WriteLine($"公雞為 :{x},母雞為{y},小雞為{z}");
            Console.ReadLine();
        }
    }
}
