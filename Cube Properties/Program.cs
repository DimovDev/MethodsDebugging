using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            switch (type)
            {
                case "face":
                    GetFace(side); break;
                case "space":
                    GetSpace(side); break;
                case "volume":
                    GetVolume(side); break;
                case "area":
                    GetArea(side); break;

            }
        }
        private static void GetFace(double side)
        {
            double fase = Math.Sqrt(2 * Math.Pow(side, 2));
            Console.WriteLine($"{fase:f2}");
        }
        private static void GetSpace(double side)
        {
            double space=Math.Sqrt(3 * Math.Pow(side, 2));
            Console.WriteLine($"{space:f2}");
        }
        private static void GetVolume(double side)
        {
            double volume =Math.Pow(side, 3);
            Console.WriteLine($"{volume:f2}");
        }
        private static void GetArea(double side)
        {
            double area = 6 * Math.Pow(side, 2);
            Console.WriteLine($"{area:f2}");
        }
    }
}
