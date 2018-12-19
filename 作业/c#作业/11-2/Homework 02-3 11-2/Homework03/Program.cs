using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 2016年11月2日 作业 02-3
/// 目的：根据用户输入的长方形的长和宽，计算该长方形的周长和面积
/// </summary>
namespace Homework03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入长方形的长：");
            string length = Console.ReadLine();
            Console.Write("请输入长方形的宽：");
            string wide = Console.ReadLine();

            int l = int.Parse(length);
            int w = int.Parse(wide);
            int perimeter, area;

            perimeter = (l + w) * 2;
            area = l * w;

            Console.WriteLine("=======================================");
            Console.WriteLine("该长方形的周长为：" + perimeter);
            Console.WriteLine("该长方形的面积为：" + area);
        }
    }
}
