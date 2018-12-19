using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 时间：2016年11月3日 
/// 作业：03-2
/// 要求：根据用户输入的五位数字，判断其是否为对称数(即个位数和万位数相等，十位数和千位数相等)
///  </summary>
namespace Homework03_11_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入一个五位数：");
            int num = Convert.ToInt32(Console.ReadLine());

            int g,s,q,w;
            g = num % 10;
            s = num / 10 % 10;
            q = num / 1000 % 10;
            w = num / 10000 % 10;

            Console.WriteLine(g);
            Console.WriteLine(s);
            Console.WriteLine(q);
            Console.WriteLine(w);
        }
    }
}
