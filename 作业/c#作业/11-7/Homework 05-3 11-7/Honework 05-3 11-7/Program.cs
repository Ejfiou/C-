using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 时间：2016年11月7日
/// 作业：05-3
/// 内容：用户输入"abcdefg"，显示的结果为"aceg"。
/// </summary>
namespace Honework_05_3_11_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入字符串：");
            string str = Console.ReadLine();
            int count = 0;

            foreach(char t in str)
            {
                if (count % 2 == 0)
                {
                    Console.Write(t);
                }
                count++;
            }
            Console.WriteLine();
        }
    }
}
