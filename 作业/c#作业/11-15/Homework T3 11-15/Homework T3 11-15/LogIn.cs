using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_T3_11_15
{
    class LogIn
    {
        private string user;
        private string password;

        //提示信息
        public void PrintMenu()
        {
            Console.Write("请输入用户名：");
            user = Console.ReadLine();
            Console.Write("请输入密码：");
            password = Console.ReadLine();
        }

        //判断
        public void Judge()
        {
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
