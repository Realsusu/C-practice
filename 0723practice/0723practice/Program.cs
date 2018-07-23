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

            //No.1
            /*
            const double Pi= 3.1415;
            double r = 1.5,h=3.6;
            double c, s, v;
            c = 2 * Pi * r;
            s = Pi * r * r;
            v = s * h;
            Console.WriteLine("圆的周长是：{0:f2}", c);
            Console.WriteLine("圆的面积是：{0:0.00}", s);
            Console.WriteLine($"圆的体积是:{v:f2}");
            */

            //No.2
            /*
            const double Pi = 3.1414;
            double r = 1.2, h = 1.5;
            double v;
            v = Pi * r * r * h;
            Console.Write("体积为：");
            Console.Write(v);
            */


            //No.3

            /*
            char ch;
            Console.WriteLine("Enter a letter:");
            ch = char.Parse(Console.ReadLine());
            if (ch >= 'A' && ch <= 'Z')
            {
                ch = (char)(ch + 32);
            }
            Console.WriteLine(ch);
            */


            /*
            float x, y, z, temp;
            Console.WriteLine("请输入第一个数：");
            x = float.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个数：");
            y = float.Parse(Console.ReadLine());
            Console.WriteLine("请输入第三个数：");
            z = float.Parse(Console.ReadLine());
            temp = x <= y ? x : y;
            temp = temp <= z ? temp : z;
            Console.WriteLine($"最小的数为{temp}");
            */

            /*
            float x, y, z, temp;
            Console.WriteLine("请输入第一个数：");
            x = float.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个数：");
            y = float.Parse(Console.ReadLine());
            Console.WriteLine("请输入第三个数：");
            z = float.Parse(Console.ReadLine());
            temp = x >= y ? x : y;
            temp = temp >= z ? temp : z;
            Console.WriteLine($"最大的数为{temp}");
            */



            Console.ReadKey();

        }
    }
}
