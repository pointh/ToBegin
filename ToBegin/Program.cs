﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToBegin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Argumenty příkazového řádku:");
            foreach (string s in args)
                Console.WriteLine(s);

            Console.ReadLine();
        }
    }
}
