using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 时间：2016年11月5日
/// 作业：04-4
/// 内容：计算100以内所有偶数之和。
/// </summary>
namespace Homework_04_4_11_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, s = 0;

            while (i <= 100)
            {
                s += i;
                i += 2;
            }
            Console.WriteLine("100以内所有偶数之和为：" + s);
        }
    }
}
