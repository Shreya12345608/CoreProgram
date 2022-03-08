using System;

namespace CoreProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PerfectNumber perfect = new PerfectNumber();
            perfect.CheckPerfectNumber();

            //Fibonacci Series
            FibonacciSeries fibonacciSeries = new FibonacciSeries();
            fibonacciSeries.CheckFibonacciSeries();
        }
    }
}
