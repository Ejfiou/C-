using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 时间：2016年11月15日
/// 内容：制作一个计算器类(特征和行为-加减乘除3/2=1.5)，并在程序入口中使用它。
/// </summary>
namespace Homework_T1_11_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();           

            Console.Write("请输入第一个数：");
            c.Num1= Convert.ToDouble(Console.ReadLine());
            Console.Write("请输入操作符(+ - * /)：");
            string s = Console.ReadLine();
            Console.Write("请输入第二个数：");
            c.Num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("计算结果为：");

            switch (s)
            {
                case "+":
                    {
                        c.Add();
                        break;
                    }
                case "-":
                    {
                        c.Reduce();
                        break;
                    }
                case "*":
                    {
                        c.Ride();
                        break;
                    }
                case "/":
                    {
                        c.Division();
                        break;
                    }
            }
        }
    }
}
