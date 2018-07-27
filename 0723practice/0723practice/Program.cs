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
            //变量练习
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


            //No.4
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


            //No.5
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

            //No.6
            /*double a, b, c;
            Console.WriteLine("Enter a number:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number:");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine($"{a,10:f3}");
            Console.WriteLine("{0,10:f3}", b);
            Console.WriteLine($"{c,10:f3}");
            */

            //No.7
            /*
            const double Pi = 3.14159265;
            double r, s;
            Console.WriteLine("请输入圆的半径:");
            r = double.Parse(Console.ReadLine());
            s = Pi * r * r;
            Console.WriteLine($"圆的面积是{s}");
            */

            //结构练习
            //No.1
            /*
            float a, b, c, second = 0;
            Console.WriteLine("请输入三个float类型的值");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            c = float.Parse(Console.ReadLine());
            if ((a > b && a < c) || (a > c && a < b))
            {
                second = a;
            }
            else if ((b > a && b < c) || (b > c && b < a))
            {
                second = b;
            }
            else {
                second = c;
            }
            Console.WriteLine("中间数是：");
            Console.Write(second);
            */

            //No.2
            /*
            float a, b, c, min = 0;
            Console.WriteLine("请输入三个float类型的值");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            c = float.Parse(Console.ReadLine());
            if (a < b && a < c)
            {
                min = a;
            }
            else if (b < a && b < c)
            {
                min = b;
            }
            else {
                min = c;
            }
            Console.WriteLine("最小的数是：");
            Console.Write(min);
            */

            //No.3
            /*
            double a;
            int a1, b;
            Console.WriteLine("请输入一个数：");
            a = double.Parse(Console.ReadLine());
            a1 = (int)a;
            if (a - a1 < 0.5)
            {
                b = a1;
            }
            else {
                b = a1 + 1;
            }
            Console.WriteLine("四舍五入后的数为：{0}", b);

            */

            //No.4
            /*
            Console.WriteLine("请输入一个整数：");
            int i = int.Parse(Console.ReadLine());
            if (i > 0)
            {
                Console.WriteLine("这个数大于0");
            }
            else if (i == 0)
            {
                Console.WriteLine("这个数等于0");
            }
            else 
            {
                Console.WriteLine("这个数小于0");
            }
            */



            Console.ReadKey();
        }
    }
}
