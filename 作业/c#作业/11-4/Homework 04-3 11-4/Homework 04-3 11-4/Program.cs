using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 时间：2016年11月5日
/// 作业：04-3
/// 内容：输入任意四个整数，将最大的值输出。随后提示"您是否想要再来一次？（y/n）"
/// </summary>
namespace Homework_04_3_11_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;

            do
            {
                Console.Write("请输入第一个整数：");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("请输入第二个整数：");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.Write("请输入第三个整数：");
                int c = Convert.ToInt32(Console.ReadLine());
                Console.Write("请输入第四个整数：");
                int d = Convert.ToInt32(Console.ReadLine());

                int x = a > b ? a : b;
                int y = c > x ? c : x;
                int max = d > y ? d : y;

                Console.WriteLine("最大的数是：" + max);
                Console.Write("您是否想要再来一次？（y/n）：");
                str = Console.ReadLine();
            }
            while (str == "y");
        }
    }
}
