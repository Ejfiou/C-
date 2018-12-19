using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 时间：2016年11月3日
/// 作业：03-1
/// 要求：制作用户登录程序。
///       (要求：让用户输入用户名和密码)判断用户登录身份
///       (以admin登录的为管理员，其余的为普通会员)管理员密码为admin，普通会员密码为123）
/// </summary>
namespace Homework_01_11_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入用户名：");
            string user = Console.ReadLine();
            Console.Write("请输入密码：");
            string password = Console.ReadLine();

            if (user == "admin" && password == "admin")
            {
                Console.WriteLine("管理员登录成功");
            }
            else if (user == "admin")
                Console.WriteLine("密码错误");

            else if (password == "123")
            {
                Console.WriteLine("普通会员登录成功");
            }
            else
            {
                Console.WriteLine("密码错误");
            }
        }
    }
}
