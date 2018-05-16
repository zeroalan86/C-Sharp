using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_LED
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var LED = new ConsoleLED();
            LED.DisplayLED(input);
            Console.ReadLine();
        }
    }
}
