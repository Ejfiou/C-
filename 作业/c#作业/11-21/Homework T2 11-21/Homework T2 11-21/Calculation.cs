using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_T2_11_21
{
    class Calculation
    {
        public static void Area(double a)
        {
            const double pi = 3.14;
            Console.WriteLine("圆的面积为：" + (pi * a * a));
        }

        public static void Area(int length, int wide)
        {
            Console.WriteLine("矩形的面积为：" + (length * wide));
        }
    }
}
