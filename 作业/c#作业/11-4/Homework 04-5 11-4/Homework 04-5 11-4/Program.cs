using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 时间：2016年11月5日
/// 作业：04-5
/// 内容：只有用户输入y，程序才结束。否则一直提示"程序运行中，请输入y退出程序！"
/// </summary>
namespace Homework_04_5_11_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            do
            {
                Console.WriteLine("程序运行中，请输入y退出程序！");
                str= Console.ReadLine();
            }
            while (str != "y");
        }
    }
}
