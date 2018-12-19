using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 2016年11月2日 作业 02-2
/// 目的：判断一个数是否是奇数
/// </summary>
namespace Homework02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入一个数：");
            string str=Console.ReadLine();
            int i = int.Parse(str);
            if (i % 2 == 0)
                Console.WriteLine("不是奇数");
            else
                Console.WriteLine("是奇数");
        }
    }
}
