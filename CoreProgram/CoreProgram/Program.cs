﻿using System;

namespace CoreProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PerfectNumber perfect = new PerfectNumber();
            perfect.CheckPerfectNumber();
        }
    }
}
