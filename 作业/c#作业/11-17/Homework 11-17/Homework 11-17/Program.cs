using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 时间：2016年11月17日
/// 内容：1.制作一个Functions类,包括的方法如下，并在程序入口中使用它。
///        1)
///         参数：一个整数
///         返回：判断其是否是奇数
///        2)
///         参数：一个五位数字，
///         返回：判断其是否为对称数(即个位数和万位数相等，十位数和千位数相等)
///        3)
///         参数：一个五位数字，
///         返回：倒着其数字
///        4)
///         参数：长方形的长和宽，
///         返回：长方形的周长
///        5)
///         参数：一个整数
///         返回：判断其是否是质数
///        6)
///         参数：一个字符串
///         返回：字符串的长度
///        7)
///         参数：两个整数
///         返回：较大的值
///        8)
///         参数：三个整数
///         返回：最大的值
/// </summary>
namespace Homework_11_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Functions f = new Functions();
            //奇数
            Console.Write("请输入一个整数：");
            int odd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(f.OddNumber(odd));
            Console.WriteLine();

            //对称数
            Console.Write("请输入一个五位数：");
            int sy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(f.SymmetricNumber(sy));
            Console.WriteLine();

            //倒着输出
            Console.Write("请输入一个五位数：");
            int reverse = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("倒着输出为：" + f.Reverse(reverse));
            Console.WriteLine();

            //长方形的周长
            Console.Write("请输入长方形的长：");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("请输入长方形的宽：");
            int wide = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("周长为：" + f.Perimeter(length, wide));
            Console.WriteLine();

            //质数
            Console.Write("请输入一个整数：");
            int pri = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(f.Prime(pri));
            Console.WriteLine();

            //字符串长度
            Console.WriteLine("请输入一个字符串：");
            string str = Console.ReadLine();
            Console.WriteLine("字符串长度为：" + f.Length(str));
            Console.WriteLine();

            //两个整数最大值
            Console.Write("请输入第一个数：");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("请输入第二个数：");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("最大值是：" + f.Max(num1, num2));
            Console.WriteLine();

            //三个数最大
            Console.Write("请输入第一个数：");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("请输入第二个数：");
            int s2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("请输入第三个数：");
            int s3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("最大值是：" + f.Max2(s1, s2, s3));
        }
    }
}
