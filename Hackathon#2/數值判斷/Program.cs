﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon001
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if(i % 15 != 0)
                {
                    Console.Write(i+",");
                }
            }
            Console.ReadLine();
            
        }
    }
}
