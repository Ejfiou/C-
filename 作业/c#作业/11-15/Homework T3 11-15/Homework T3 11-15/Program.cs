using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 时间：2016年11月15日
/// 内容：制作一个登录类(特征和行为-打印登录菜单和判断是否为合法用户)，并在程序入口中使用它。
/// </summary>
namespace Homework_T3_11_15
{
    class Program
    {
        static void Main(string[] args)
        {
            LogIn us = new LogIn();
            us.PrintMenu();
            us.Judge();

        }
    }
}
