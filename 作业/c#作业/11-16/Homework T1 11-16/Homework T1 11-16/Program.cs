using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 时间：2016年11月16日
/// 内容：制作一个计算器类(特征和行为-加减乘除3/2=1.5)，并在程序入口中使用它。
/// </summary>
namespace Homework_T1_11_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();

            Console.Write("请输入第一个数：");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("请输入操作符(+ - * /)：");
            string s = Console.ReadLine();
            Console.Write("请输入第二个数：");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("计算结果为：");

            double result = 0;
            switch (s)
            {
                case "+":
                    {
                        result = c.Add(num1, num2);
                        break;
                    }
                case "-":
                    {
                        result = c.Reduce(num1, num2);
                        break;
                    }
                case "*":
                    {
                        result = c.Ride(num1, num2);
                        break;
                    }
                case "/":
                    {
                        result = c.Division(num1, num2);
                        break;
                    }
            }

            Console.WriteLine(result);
        }
    }
}
