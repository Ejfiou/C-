using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_30
{
    /// <summary>
    /// 人信息管理系统的程序界面
    /// </summary>
    public class MyPersonView
    {
        public MyPersonView()
        {

        }

        /// <summary>
        /// 创建人对象
        /// </summary>
        /// <returns>人对象</returns>
        public virtual Person Create()
        {
            Person per = null;

            Console.Write("请输入人的身份证：");
            string cardID = Console.ReadLine();
            Console.Write("请输入人的姓名：");
            string name = Console.ReadLine();
            Console.Write("请输入人的年龄：");
            string age = Console.ReadLine();

            int ageInt;
            bool f = int.TryParse(age, out ageInt);
            while (!f)
            {
                Console.Write("输入格式错误，请重新输入：");
                age = Console.ReadLine();
                f = int.TryParse(age, out ageInt);
            }

            per = new Person(cardID, name, ageInt);

            return per;
        }


        /// <summary>
        /// 修改人信息
        /// </summary>
        /// <returns>人对象</returns>
        public virtual Person Modify()
        {
            Person per = null;

            Console.Write("请输入要修改人的身份证：");
            string cardID = Console.ReadLine();
            Console.Write("请输入要修改人的姓名：");
            string name = Console.ReadLine();
            Console.Write("请输入要修改人的年龄：");
            string age = Console.ReadLine();

            int ageInt;
            bool f = int.TryParse(age, out ageInt);
            while (!f)
            {
                Console.Write("输入格式错误，请重新输入：");
                age = Console.ReadLine();
                f = int.TryParse(age, out ageInt);
            }

            per = new Student(cardID, name, ageInt);

            return per;
        }

        /// <summary>
        /// 删除人信息
        /// </summary>
        /// <returns>人对象</returns>
        public virtual Person Remove()
        {
            Person per = null;

            Console.Write("请输入要删除的人的身份证：");
            string cardID = Console.ReadLine();

            per = new Person(cardID);

            return per;
        }


        /// <summary>
        /// 显示多个人信息
        /// </summary>
        /// <param name="stus">要显示的人信息的数组</param>
        public virtual void PrintMany(Person[] pers)
        {
            Console.WriteLine("\n************人的信息如下*******************");

            if (pers != null)
            {
                for (int i = 0; i < pers.Length; i++)
                {
                    Console.WriteLine(pers[i].ShowMe());
                }
            }
            else
            {
                Console.WriteLine("对不起！当前没有任何人的信息！");
            }
        }


        /// <summary>
        /// 打印一个人的信息
        /// </summary>
        /// <param name="stus">要显示的人信息</param>
        public virtual void PrintOne(Person stu)
        {
            Console.WriteLine("\n************人的信息如下*******************");

            if (stu != null)
            {
                Console.WriteLine(stu.ShowMe());
            }
            else
            {
                Console.WriteLine("对不起！没有对应的人的信息！");
            }
        }

        /// <summary>
        /// 打印或显示信息
        /// </summary>
        /// <param name="msg">要显示的信息</param>
        public void PrintMessage(string msg)
        {
            Console.WriteLine(msg);
        }

        /// <summary>
        /// 打印菜单
        /// </summary>
        public virtual void PrintMenu()
        {
            Console.WriteLine("人的信息管理系统--菜单如下：");
            Console.WriteLine("0.注销");
            Console.WriteLine("1.增加人信息");
            Console.WriteLine("2.查询所有人信息");
            Console.WriteLine("3.修改人信息");
            Console.WriteLine("4.删除人信息");
            Console.WriteLine("5.按身份证查询对应的人信息");
            Console.WriteLine("6.按姓名查询对应的人信息");
        }

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
        /// 得到查询的身份证
        /// </summary>
        /// <returns>查询的身份证</returns>
        public virtual string QueryByPrimaryKey()
        {
            string stuNo = null;

            Console.WriteLine("请输入要查询的身份证：");
            stuNo = Console.ReadLine();

            return stuNo;
        }

        /// <summary>
        /// 得到查询的姓名
        /// </summary>
        /// <returns>查询的姓名</returns>
        public string QueryByName()
        {
            string name = null;

            Console.WriteLine("请输入要查询的姓名：");
            name = Console.ReadLine();

            return name;
        }

        /// <summary>
        /// 用户登录界面
        /// </summary>
        /// <returns>用户对象</returns>
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
