using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 时间：2016年11月15日
/// 内容：制作一个人类(特征和行为-吃喝拉撒睡)，并在程序入口中使用它。

/// </summary>
namespace Homework_T2_11_15
{
    class Program
    {
        static void Main(string[] args)
        {
            People p1 = new People();
            People p2 = new People();

            p1.GetPeople();
            p2.GetPeople();

            p1.PeopleShow();
            p2.PeopleShow();

            Console.WriteLine();

            p1.Eat();
            p1.Drink();
            p1.Pull();
            p1.Samuel();
            p1.Sleep();

            Console.WriteLine();

            p2.Eat();
            p2.Drink();
            p2.Pull();
            p2.Samuel();
            p2.Sleep();
        }

    }
}
