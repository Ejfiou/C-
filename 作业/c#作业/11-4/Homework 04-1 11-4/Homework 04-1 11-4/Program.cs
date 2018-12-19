using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 时间：2016年11月4日
/// 作业：04-1
/// 内容：制作用户登录程序。(要求：让用户输入用户名和密码)
///       判断用户登录身份(以admin登录的为管理员，其余的为普通会员)
///       管理员密码为admin，普通会员密码为123
///       如果登录失败，那么随后提示"您是否想要重新登录？（y/n）"
/// </summary>
namespace Homework_04_1_11_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "y";

            while (str == "y")
            {
                Console.Write("请输入用户名：");
                string user = Console.ReadLine();
                Console.Write("请输入密码：");
                string password = Console.ReadLine();

                if (user == "admin" && password == "admin")
                {
                    Console.WriteLine("管理员登录成功");
                    break;
                }
                else if (user == "admin")
                {
                    Console.WriteLine("密码错误");
                }
                else if (password == "123")
                {
                    Console.WriteLine("普通会员登录成功");
                    break;
                }
                else
                {
                    Console.WriteLine("密码错误");
                }

                Console.Write("您是否想要重新登录？（y/n）");
                str = Console.ReadLine();
            }

        }
    }
}
