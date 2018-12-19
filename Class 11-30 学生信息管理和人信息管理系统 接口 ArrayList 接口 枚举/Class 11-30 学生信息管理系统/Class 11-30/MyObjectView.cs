using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Class_11_30
{
    /// <summary>
    /// 万事万物中的某种信息管理系统的程序界面
    /// </summary>
    public abstract class MyObjectView
    {
        /// <summary>
        /// 创建某种对象
        /// </summary>
        /// <returns>某种对象</returns>
        public abstract IMyObject Create();

        /// <summary>
        /// 修改某种信息
        /// </summary>
        /// <returns>某种对象</returns>
        public abstract IMyObject Modify();

        /// <summary>
        /// 删除某种对象
        /// </summary>
        /// <returns>某种对象</returns>
        public abstract IMyObject Remove();

        /// <summary>
        /// 显示某种信息
        /// </summary>
        /// <param name="objs"></param>
        public abstract void PrintMany(IMyObject[] objs);

        /// <summary>
        /// 显示一个信息
        /// </summary>
        /// <param name="obj"></param>
        public abstract void PrintOne(IMyObject obj);

        /// <summary>
        /// 打印或显示信息
        /// </summary>
        /// <param name="msg">要显示的信息</param>
        public void PrintMessage(string msg)
        {
            Console.WriteLine(msg);
        }

        public abstract void PrintMenu();

        /// <summary>
        /// 选择菜单数字
        /// </summary>
        /// <returns>选择的数字</returns>
        public int ChoiceMenu()
        {
            Console.Write("请您选择菜单（输入菜单的编号）：");
            string userChoice = Console.ReadLine().Trim();
            while (Regex.IsMatch(userChoice, "^[0-9]+$") == false)
            {
                Console.Write("您的输入有误，请重新输入菜单编号：");
                userChoice = Console.ReadLine().Trim();
            }

            return Convert.ToInt32(userChoice);
        }

        /// <summary>
        /// 清屏
        /// </summary>
        public void Clear()
        {
            //客户决定清屏
            Console.Write("请按任意键继续...");
            Console.ReadKey();
            Console.Clear();
        }

        /// <summary>
        /// 得到查询的主键
        /// </summary>
        /// <returns>查询的主键</returns>
        public abstract string QueryByPrimaryKey();

        /// <summary>
        /// 得到查询的某种信息
        /// </summary>
        /// <returns>查询的某种信息</returns>
        public abstract IMyObject QueryByNonPrimaryKey();

        public UserStruct LogIn()
        {
            UserStruct user;

            Console.Write("请输入用户名：");
            string username = Console.ReadLine();
            Console.Write("请输入密码：");
            string password = GetMaskPassword();
            Console.WriteLine();
            user = new UserStruct(username, password, null);
            return user;
        }

        /// <summary>
        /// 打印菜单
        /// </summary>
        public void PrintLogInMenu()
        {
            //Console.WriteLine("欢迎使用信息管理系统 v1.0");
            //Console.WriteLine("作者：xxx");
            //Console.WriteLine("电话：110");
            Console.WriteLine(PrintCopyright());
            Console.WriteLine("0.退出系统");
            Console.WriteLine("1.登录系统");
        }

        /// <summary>
        /// 版权的信息
        /// </summary>
        /// <returns>版权的信息</returns>
        public string PrintCopyright()
        {
            StringBuilder copyright = new StringBuilder();

            //       .-'^' -.
            //     .' a___a `. 
            //     == (___) ==
            //     '. ._I_. .'
            //____ /.`-----'.\____ 

            //╋╋╋☆╋╋☆╋╋☆╋╋╋
            //╋☆  欢迎使用本系统  ☆╋
            //╋☆    作者：张三    ☆╋  
            //╋☆    版本：v2.0    ☆╋ 
            //╋╋╋☆╋╋☆╋╋☆╋╋╋

            /**/

            copyright.AppendLine("          .-'^' -.");
            copyright.AppendLine("        .' a___a `.");
            copyright.AppendLine("        == (___) ==");
            copyright.AppendLine("        '. ._I_. .'");
            copyright.AppendLine(@"  _____ /.`-----'.\______");
            copyright.AppendLine();
            copyright.AppendLine("╋╋╋☆╋╋☆╋╋☆╋╋╋");
            copyright.AppendLine("╋☆  欢迎使用本系统  ☆╋");
            copyright.AppendLine("╋☆    作者：张三    ☆╋");
            copyright.AppendLine("╋☆    版本：v2.0    ☆╋");
            if (Vip.isVip())
            {
                copyright.AppendLine("╋☆    版本：正式版    ☆╋");
            }
            else
            {
                copyright.AppendLine("╋☆    版本：试用版    ☆╋");
            }
            copyright.AppendLine("╋╋╋☆╋╋☆╋╋☆╋╋╋");
            if (!Vip.isVip())
            {
                copyright.AppendLine("");
                copyright.AppendLine("当前为试用版，无法保存数据！");
                copyright.AppendLine("如果要保存数据，请联系作者！");
            }
            return copyright.ToString();
        }

        /// <summary>
        /// 产生隐藏的密码字符串
        /// </summary>
        /// <returns>输入的明文密码</returns>
        private string GetMaskPassword()
        {
            string password = null;

            StringBuilder sb = new StringBuilder();
            ConsoleKeyInfo info = Console.ReadKey(true);
            while (info.Key != ConsoleKey.Enter)
            {
                if (info.Key == ConsoleKey.Backspace)
                {
                    if (sb.Length > 0)
                    {
                        Console.Write("\b");
                        Console.Write(" ");
                        Console.Write("\b");
                        sb.Remove(sb.Length - 1, 1);
                    }
                }
                else
                {
                    Console.Write("*");
                    sb.Append(info.KeyChar);                    
                }
                info = Console.ReadKey(true);
            }

            if (sb.Length>0)
            {
                password = sb.ToString();
            }
            return password;
        } 
    }
}
