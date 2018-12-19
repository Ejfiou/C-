using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 时间：2016年11月7日
/// 作业：05-1
/// 内容：判断一个数是否是质数。
///       所谓质数，就是一个正整数，除了本身和1 以外不能被其他任何数整除。例如2，3，5，7 是质数（这4个数只能被1和本身整除）；而4(可以被2整除)，6（可以被2和3整除），8（可以被2和4整除），9（可以被3整除）则不是。
/// </summary>
namespace Homework_05_1_11_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, j, num;

            Console.Write("请输入要判断的数字：");
            num = Convert.ToInt32(Console.ReadLine());

            for (j = 2; j < num; j++)
            {
                if (num % j == 0)
                {
                    i++;
                }
            }
            if (i == 0)
            {
                Console.WriteLine("是质数。");
            }
            else
            {
                Console.WriteLine("不是质数。");
            }
        }
    }
}

