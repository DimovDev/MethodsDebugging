using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English_Name_Of_The_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            Console.WriteLine(GetNameOfLastDigit(a));
        }

        private static string GetNameOfLastDigit(long a)
        {
            long lastDigit = Math.Abs(a % 10);
            string nameOfDigit = null;
            switch (lastDigit)
            {
                case 1:
                    nameOfDigit = ("one");
                    break;
                case 2:
                    nameOfDigit = ("two");
                    break;
                case 3:
                    nameOfDigit = ("three");
                    break;
                case 4:
                    nameOfDigit = ("four");
                    break;
                case 5:
                    nameOfDigit = ("five");
                    break;
                case 6:
                    nameOfDigit = ("six");
                    break;
                case 7:
                    nameOfDigit = ("seven");
                    break;
                case 8:
                    nameOfDigit = ("eight");
                    break;
                case 9:
                    nameOfDigit = ("nine");
                    break;
                case 0:
                    nameOfDigit = ("zero");
                    break;

            }
            return nameOfDigit;
        }
    }
}
