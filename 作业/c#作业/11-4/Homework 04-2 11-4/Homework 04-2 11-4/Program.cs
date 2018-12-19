using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary> 
/// 时间：2016年11月4日
/// 作业：04-2
/// 内容：根据用户输入的五位数字，判断其是否为对称数(即个位数和万位数相等，十位数和千位数相等)
///       随后提示"您是否想要再来一次？（y/n）"
/// </summary>
namespace Homework_04_2_11_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            do
            {
                Console.Write("请输入五个数：");
                int num = Convert.ToInt32(Console.ReadLine());

                int g, s, q, w;           //提取各个位上的数
                g = num % 10;
                s = num / 10 % 10;
                q = num / 1000 % 10;
                w = num / 10000 % 10;

                if (s == q && g == w)
                {
                    Console.WriteLine("是对称数");
                }
                else
                {
                    Console.WriteLine("不是对称数");
                }

                Console.Write("您是否想要再来一次？（y/n）：");
                str = Console.ReadLine();
            }
            while (str == "y");
        }
    }
}
