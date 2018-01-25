using System;
using System.Numerics;

namespace Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong input = ulong.Parse(Console.ReadLine());
            Console.WriteLine(Fib(input));
        }

        static BigInteger Fib(ulong input)
        {
            if (input == 1 || input == 0) return 1;
            else
            {
                BigInteger previousTerm = 1;
                BigInteger currentTerm = 1;
                for (ulong i = 2; i <= input; i++)
                {
                    BigInteger oldCurrentTerm = currentTerm;
                    currentTerm += previousTerm;
                    previousTerm = oldCurrentTerm;
                }
                return currentTerm;
            }
        }
    }
}
