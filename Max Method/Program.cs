using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int biggestNum = GetMax(firstNum, GetMax(secondNum, thirdNum));
            Console.WriteLine(biggestNum);
        }
        static int GetMax(int firstNum,int secondNum)
        {
            if (firstNum>= secondNum)
            {
                return firstNum;
            }
            else
            {
                return secondNum;
            }
        }
    }
}
