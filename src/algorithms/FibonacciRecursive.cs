namespace introduction_to_algorithms.src.algorithms
{
    public class FibonacciRecursive
    {
        public static long Fibonacci(long x)
        {
            if (x == 0)
                return 0;
            if (x == 1)
                return 1;

            return Fibonacci(x - 1) + Fibonacci(x - 2);
        }
    }
}