using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 时间：2016年11月16日
/// 内容：制作一个人类(特征和行为-吃喝拉撒睡)，并在程序入口中使用它。
/// </summary>
namespace Homework_T2_11_16
{
    class Program
    {
        static void Main(string[] args)
        {
            People p1 = new People();

            Console.Write("请输入姓名：");
            string name = Console.ReadLine();
            Console.Write("请输入性别：");
            string sex = Console.ReadLine();
            Console.Write("请输入身高：");
            string height = Console.ReadLine();

            string show1 = p1.PeopleShow(name, sex, height);
            string eat = p1.Eat(name);
            string drink = p1.Drink(name);
            string pull = p1.Pull(name);
            string sam = p1.Samuel(name);
            string sleep = p1.Sleep(name);

            Console.WriteLine(show1);
            Console.WriteLine(eat);
            Console.WriteLine(drink);
            Console.WriteLine(pull);
            Console.WriteLine(sam);
            Console.WriteLine(sleep);

        }
    }
}
