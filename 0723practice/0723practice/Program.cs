using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0723practice
{
    class Program
    {
        static void Main(string[] args)
        {
            const double Pi= 3.1415;
            double r = 1.5,h=3.6;
            double c, s, v;
            c = 2 * Pi * r;
            s = Pi * r * r;
            v = s * h;
            Console.WriteLine("圆的周长是：{0:f2}", c);
            Console.WriteLine("圆的面积是：{0:0.00}", s);
            Console.WriteLine($"圆的体积是:{v:f2}");
            Console.ReadLine();

        }
    }
}
