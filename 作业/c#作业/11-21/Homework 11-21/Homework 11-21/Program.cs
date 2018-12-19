using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 时间：2016年11月21日
/// </summary>
namespace Homework_11_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            bool y, y1, y2;
            string str;
            
            //奇数
            Console.WriteLine("判断是否为奇数");
            Console.Write("请输入一个数字：");
            y = int.TryParse(Console.ReadLine(), out a);
            while (!y)
            {
                Console.Write("您输入的格式不正确，请重新输入：");
                y = int.TryParse(Console.ReadLine(), out a);
            }
            str = Functions.OddNumber(a);
            Console.WriteLine(str);
            Console.WriteLine();

            //对称数
            Console.WriteLine("判断是否为对称数");
            Console.Write("请输入一个五位数：");
            y = int.TryParse(Console.ReadLine(), out a);
            while (!y || a < 10000 || a > 99999)
            {
                Console.Write("您输入的格式不正确，请重新输入：");
                y = int.TryParse(Console.ReadLine(), out a);
            }
            str = Functions.SymmetricNumber(a);
            Console.WriteLine(str);
            Console.WriteLine();

            //倒着输出
            Console.WriteLine("倒着输出一个五位数");
            Console.Write("请输入一个五位数：");
            y = int.TryParse(Console.ReadLine(), out a);
            while (!y || a < 10000 || a > 99999)
            {
                Console.Write("您输入的格式不正确，请重新输入：");
                y = int.TryParse(Console.ReadLine(), out a);
            }
            Console.WriteLine("倒着输出为：" + Functions.Reverse(a));
            Console.WriteLine();

            //长方形的周长
            Console.WriteLine("长方形的周长");
            Console.Write("请输入长方形的长：");
            y = int.TryParse(Console.ReadLine(), out a);
            while (!y)
            {
                Console.Write("您输入的格式不正确，请重新输入：");
                y = int.TryParse(Console.ReadLine(), out a);
            }
            Console.Write("请输入长方形的宽：");
            y1 = int.TryParse(Console.ReadLine(), out b);
            while (!y1)
            {
                Console.Write("您输入的格式不正确，请重新输入：");
                y1 = int.TryParse(Console.ReadLine(), out b);
            }
            Console.WriteLine("周长为：" + Functions.Perimeter(a, b));
            Console.WriteLine();

            //质数
            Console.WriteLine("判断是否为质数");
            Console.Write("请输入一个整数：");
            y = int.TryParse(Console.ReadLine(), out a);
            while (!y)
            {
                Console.Write("您输入的格式不正确，请重新输入：");
                y = int.TryParse(Console.ReadLine(), out a);
            }
            Console.WriteLine(Functions.Prime(a));
            Console.WriteLine();

            //字符串长度
            Console.WriteLine("计算字符串长度");
            Console.Write("请输入一个字符串：");
            str = Console.ReadLine();
            Console.WriteLine("字符串长度为：" + Functions.Length(str));
            Console.WriteLine();

            //两个整数最大值
            Console.WriteLine("两个整数最大值");
            Console.Write("请输入第一个数：");
            y = int.TryParse(Console.ReadLine(), out a);
            while (!y)
            {
                Console.Write("您输入的格式不正确，请重新输入：");
                y = int.TryParse(Console.ReadLine(), out a);
            }
            Console.Write("请输入第二个数：");
            y1 = int.TryParse(Console.ReadLine(), out b);
            while (!y1)
            {
                Console.Write("您输入的格式不正确，请重新输入：");
                y1 = int.TryParse(Console.ReadLine(), out a);
            }
            Console.WriteLine("最大值是：" + Functions.Max(a, b));
            Console.WriteLine();

            //三个数最大
            Console.WriteLine("三个整数最大值");
            Console.Write("请输入第一个数：");
            y = int.TryParse(Console.ReadLine(), out a);
            while (!y)
            {
                Console.Write("您输入的格式不正确，请重新输入：");
                y = int.TryParse(Console.ReadLine(), out a);
            }
            Console.Write("请输入第二个数：");
            y1 = int.TryParse(Console.ReadLine(), out b);
            while (!y1)
            {
                Console.Write("您输入的格式不正确，请重新输入：");
                y1 = int.TryParse(Console.ReadLine(), out a);
            }
            Console.Write("请输入第三个数：");
            y2 = int.TryParse(Console.ReadLine(), out c);
            while (!y2)
            {
                Console.Write("您输入的格式不正确，请重新输入：");
                y2 = int.TryParse(Console.ReadLine(), out a);
            }
            Console.WriteLine("最大值是：" + Functions.Max2(a, b, c));
        }
    }
}
