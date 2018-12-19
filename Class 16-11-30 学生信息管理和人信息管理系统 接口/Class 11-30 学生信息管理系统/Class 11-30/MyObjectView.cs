using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            int menuIndex = -1;

            Console.Write("请您选择菜单（输入菜单的编号）：");
            bool f = int.TryParse(Console.ReadLine(), out menuIndex);
            while (!f)
            {
                Console.Write("您的输入有误，请重新输入：");
                f = int.TryParse(Console.ReadLine(), out menuIndex);
            }

            return menuIndex;
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

        public User LogIn()
        {
            User user = null;

            Console.Write("请输入用户名：");
            string username = Console.ReadLine();
            Console.Write("请输入密码：");
            string password = Console.ReadLine();

            user = new User(username, password, null);
            return user;
        }

        /// <summary>
        /// 打印菜单
        /// </summary>
        public void PrintLogInMenu()
        {
            Console.WriteLine("欢迎使用信息管理系统 v1.0");
            Console.WriteLine("作者：xxx");
            Console.WriteLine("电话：110");
            Console.WriteLine();
            Console.WriteLine("0.退出系统");
            Console.WriteLine("1.登录系统");
        }
    }
}
