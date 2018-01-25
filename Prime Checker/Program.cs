using System;

namespace Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());
            Console.WriteLine( IsPrime(input));
        }
        static bool IsPrime(long inputNumber)
        {
            if (inputNumber == 0 || inputNumber == 1)
            {
                return false;
            }
            else
            {
                bool IsPrime = true;
                for (long i = 2; i <= Math.Sqrt(inputNumber); i++)
                {
                    if (inputNumber % i ==0)
                    {
                        IsPrime = false;
                        break;
                    }
                }
                return IsPrime;
            }
        }
    }
}
