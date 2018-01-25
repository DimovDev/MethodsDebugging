using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNumbers
{
    static class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (IsPalindrome(i) && SumOfDigits(i) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool IsPalindrome(int i)
        {
            var number = i;
            var result = 0;
            while (i>0)
            {
                int lastDigit = i % 10;
                result = result * 10 + lastDigit;
                i /= 10;
            }
            if (number == result) { return true; }
            else
            {
                return false;

            }
        }


        static bool SumOfDigits(int num)
        {
            string number = num.ToString();
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum += int.Parse(number[i].ToString());
            }
            if (sum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool ContainsEvenDigit(int num)
        {
            string number = num.ToString();
            for (int i = 0; i < number.Length; i++)
            {
                int rem = int.Parse(number[i].ToString());
                if (rem % 2 == 0)
                {
                    return true;
                }

            }
            return false;
        }

    }

}


    

