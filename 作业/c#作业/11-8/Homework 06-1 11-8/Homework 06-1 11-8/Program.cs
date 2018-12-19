using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 时间：2016年11月8日
/// 作业：06-1
/// 内容：输出9x9乘法表
/// </summary>
namespace Homework_06_1_11_8
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <= 9; a++)
            {
                for (int i = 1; i <= a; i++)
                {
                    Console.Write("{0}*{1}={2}\t", i, a, a * i);
                }
                Console.WriteLine();
            }
        }
    }
}

