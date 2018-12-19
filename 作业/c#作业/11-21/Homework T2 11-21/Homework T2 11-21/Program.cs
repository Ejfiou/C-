using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 时间：2016年11月21日
/// </summary>
namespace Homework_T2_11_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            double c;
            bool f, f1;
            Console.Write("请输入圆的半径：");
            f = double.TryParse(Console.ReadLine(), out c);
            while (!f)
            {
                Console.Write("输入格式错误，请重新输入：");
                f = double.TryParse(Console.ReadLine(), out c);
            }
            Calculation.Area(c);

            Console.Write("请输入矩形的长：");
            f1 = int.TryParse(Console.ReadLine(), out a);
            while (!f1)
            {
                Console.Write("输入的长格式错误，请重新输入：");
                f1 = int.TryParse(Console.ReadLine(), out a);
            }

            Console.Write("请输入矩形的宽：");
            f = int.TryParse(Console.ReadLine(), out b);
            while (!f)
            {
                Console.Write("输入的宽格式错误，请重新输入：");
                f = int.TryParse(Console.ReadLine(), out b);
            }
            Calculation.Area(a, b);
        }
    }
}
