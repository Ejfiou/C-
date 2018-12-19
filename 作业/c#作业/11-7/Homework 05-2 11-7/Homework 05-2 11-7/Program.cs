using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 时间：2016年11月7日
/// 作业：05-2
/// 内容：计算100以内所有质数之和。
/// </summary>
namespace Homework_05_2_11_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 2; i < 100; i++)
            {
                bool flag = true;    //用于标志是否为素数
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
