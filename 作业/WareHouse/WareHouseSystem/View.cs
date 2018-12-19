using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using MyClassLibrary1;
namespace WareHouseSystem
{
    public class View:IView
    {
        public View()
        {

        }
        private DataBase db = new DataBase();

        /// <summary>
        /// 仓库菜单
        /// </summary>
        public void PrintMenu()
        {
            StringBuilder copyright = new StringBuilder();
            copyright.AppendLine("╋╋╋☆╋╋☆╋╋☆╋╋☆╋╋☆╋");
            copyright.AppendLine("╋☆  欢迎使用仓库管理系统    ☆╋");
            copyright.AppendLine("╋☆                          ☆╋");
            copyright.AppendLine("╋╋╋☆╋╋☆╋╋☆╋╋☆╋╋☆╋");
            copyright.AppendLine();
            copyright.AppendLine("***********菜单如下***********");
            copyright.AppendLine("* 1.入库                     *");
            copyright.AppendLine("* 2.出库                     *");
            copyright.AppendLine("* 3.显示所有货物信息         *");
            copyright.AppendLine("* 4.按货物名查询货物信息     *");
            copyright.AppendLine("* 0.注销                     *");
            copyright.AppendLine("******************************");
            Console.WriteLine(copyright);
        }

        

        /// <summary>
        /// 清屏
        /// </summary>
        public void Clear()
        {
            Console.Write("请按任意键继续...");
            Console.ReadKey();
            Console.Clear();
        }

        /// <summary>
        /// 选择菜单
        /// </summary>
        /// <returns>编号</returns>
        public int ChoiceMenu()
        {
            Console.Write("请您选择菜单（输入菜单的编号）：");
            string  choice = Console.ReadLine().Trim();
            while (!Regex.IsMatch(choice, "^[0-9]+$"))
            {
                Console.Write("您的输入有误，请重新输入菜单编号：");
                choice = Console.ReadLine().Trim();
            }

            return Convert.ToInt32(choice);
        }

        /// <summary>
        /// 入库
        /// </summary>
        /// <returns>货物对象</returns>
        public IMyObject Put()
        {
            IMyObject ware = null;

            Console.Write("请输入您要入库的货物名：");
            string name = Console.ReadLine().Trim();
            while (!Regex.IsMatch(name, @"^\w+$"))
            {
                Console.Write("输入错误!请重新输入货物名：");
                name = Console.ReadLine().Trim();
            }
            Console.Write("请输入你要入库的数量：");
            string num = Console.ReadLine().Trim();
            while (!Regex.IsMatch(num, @"^(([1-9]|[1-9][0-9]+)(.([0]+))?)$"))
            {
                Console.Write("您的输入有误，请重新输入数量：");
                num = Console.ReadLine().Trim();
            }

            ware = new WareHouse(name, double.Parse(num));
            return ware;

        }

        /// <summary>
        /// 增加单位
        /// </summary>
        /// <returns></returns>
        public string AddUnit()
        {
            Console.Write("请输入货物单位：");
            string unit = Console.ReadLine().Trim();
            while (!Regex.IsMatch(unit, @"^\w+$"))
            {
                Console.Write("输入错误!请重新输入单位：");
                unit = Console.ReadLine().Trim();
            }

            return unit;
        }


        

        /// <summary>
        /// 出库
        /// </summary>
        /// <returns>货物对象</returns>
        public IMyObject Out()
        {
            IMyObject ware = null;

            Console.Write("请输入您要出库的货品名：");
            string name = Console.ReadLine().Trim();
            while (!Regex.IsMatch(name, @"^\w+$"))
            {
                Console.Write("输入错误!请重新输入货物名：");
                name = Console.ReadLine().Trim();
            }
            Console.Write("请输入您要出库的数量：");
            string num = Console.ReadLine().Trim();

            while (!Regex.IsMatch(num, @"^(([1-9]|[1-9][0-9]+)(.([0]+))?)$"))
            {
                Console.Write("您的输入有误，请重新输入数量：");
                num = Console.ReadLine().Trim();
            }


            ware = new WareHouse(name, double.Parse(num),null);

            return ware;
        }

        /// <summary>
        /// 按货物名查询
        /// </summary>
        /// <returns>货物名</returns>
        public string SearchByName()
        {
            Console.Write("请输入您要查询的货品名：");
            string name = Console.ReadLine().Trim();
            while (!Regex.IsMatch(name, @"^\w+$"))
            {
                Console.Write("输入错误!请重新输入货物名：");
                name = Console.ReadLine().Trim();
            }

            return name;
        }

        /// <summary>
        /// 打印所有货物
        /// </summary>
        /// <param name="ware">货物对象</param>
        public void PrintAll(IMyObject[] ware)
        {
            Console.WriteLine("************** 货物信息如下 ************");
            if (ware != null)
            {
                for (int i = 0; i < ware.Length; i++)
                {
                    Console.WriteLine($"编号：{i+1,-5}{ware[i].ShowMe()}");
                }
            }
            else
            {
                Console.WriteLine("对不起！当前没有任何货物信息！");
            }
        }
        /// <summary>
        /// 打印一个货物
        /// </summary>
        /// <param name="ware">货物对象</param>
        public void PrintOne(IMyObject ware)
        {
            Console.WriteLine("************ 货物信息如下 *************");
            if (ware != null)
            {
                Console.WriteLine(ware.ShowMe());
            }
            else
            {
                Console.WriteLine("对不起！当前没有此货物信息！");
            }
        }

        /// <summary>
        /// 登录菜单
        /// </summary>
        /// <returns></returns>
        public User LogIn()
        {
            User user;

            Console.Write("请输入用户名：");
            string username = Console.ReadLine();
            Console.Write("请输入密码：");
            string password = GetMaskPassword();
            Console.WriteLine();
            user = new User(username, password, null);
            return user;
        }


        /// <summary>
        /// 打印信息
        /// </summary>
        /// <param name="msg">打印的字符</param>
        public void PrintMessage(string msg)
        {
            Console.WriteLine(msg);
        }


        /// <summary>
        /// 打印最开始菜单
        /// </summary>
        public void PrintLogInMenu()
        {

            //Console.WriteLine("作者：xxx");
            //Console.WriteLine("电话：110");
            StringBuilder copyright = new StringBuilder();
            copyright.AppendLine("╋╋╋☆╋╋☆╋╋☆╋╋☆╋╋☆╋");
            copyright.AppendLine("╋☆  欢迎使用仓库管理系统  ☆╋");
            copyright.AppendLine("╋☆                          ☆╋");
            copyright.AppendLine("╋╋╋☆╋╋☆╋╋☆╋╋☆╋╋☆╋");
            copyright.AppendLine("1.登录");
            copyright.AppendLine("0.取消");
            Console.WriteLine(copyright);

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

            if (sb.Length > 0)
            {
                password = sb.ToString();
            }
            return password;
        }

    }
}
