using System;
using introduction_to_algorithms.src.algorithms;

namespace introduction_to_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = args[0];
            System.Console.WriteLine(FibonacciRecursive.Fibonacci(int.Parse(input)));
        }
    }
}
