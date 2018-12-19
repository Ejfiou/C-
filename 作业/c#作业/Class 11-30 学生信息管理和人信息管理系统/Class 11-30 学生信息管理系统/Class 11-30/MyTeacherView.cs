using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_30
{
    public class MyTeacherView:MyPersonView
    {
        public MyTeacherView()
        {

        }

        /// <summary>
        ///创建教师对象 
        /// </summary>
        /// <returns>教师对象</returns>
        public override Person Create()
        {
            Teacher tea = null;

            Console.Write("请输入教师的编号：");
            string teaNo = Console.ReadLine();
            Console.Write("请输入教师的姓名：");
            string name = Console.ReadLine();
            Console.Write("请输入教师的年龄：");
            string age = Console.ReadLine();

            int ageInt;
            bool f = int.TryParse(age, out ageInt);
            while (!f)
            {
                Console.Write("输入格式错误，请重新输入：");
                age = Console.ReadLine();
                f = int.TryParse(age, out ageInt);
            }

            tea = new Teacher(teaNo, name, ageInt);

            return tea;
        }

        /// <summary>
        /// 删除教师信息
        /// </summary>
        /// <returns>教师对象</returns>
        public override Person Remove()
        {
            Teacher tea = null;

            Console.Write("请输入要删除的教师的编号：");
            string teaNo = Console.ReadLine();

            tea = new Teacher(teaNo);

            return tea;
        }

        /// <summary>
        /// 修改教师信息
        /// </summary>
        /// <returns>教师对象</returns>
        public override Person Modify()
        {
            Teacher tea = null;

            Console.Write("请输入要修改教师的编号：");
            string teaNo = Console.ReadLine();
            Console.Write("请输入要修改教师的姓名：");
            string name = Console.ReadLine();
            Console.Write("请输入要修改教师的年龄：");
            string age = Console.ReadLine();

            int ageInt;
            bool f = int.TryParse(age, out ageInt);
            while (!f)
            {
                Console.Write("输入格式错误，请重新输入：");
                age = Console.ReadLine();
                f = int.TryParse(age, out ageInt);
            }

            tea = new Teacher(teaNo, name, ageInt);

            return tea;
        }


        /// <summary>
        /// 显示多个教师信息
        /// </summary>
        /// <param name="teas">要显示的教师信息的数组</param>
        public override void PrintMany(Person[] teas)
        {
            Console.WriteLine("\n************教师信息如下*******************");

            if (teas != null)
            {
                for (int i = 0; i < teas.Length; i++)
                {
                    Console.WriteLine(teas[i].ShowMe());
                }
            }
            else
            {
                Console.WriteLine("对不起！当前没有任何教师信息！");
            }
        }


        /// <summary>
        /// 打印一个教师信息
        /// </summary>
        /// <param name="tea">要显示的教师信息</param>
        public override void PrintOne(Person tea)
        {
            Console.WriteLine("\n************教师信息如下*******************");

            if (tea != null)
            {
                Console.WriteLine(tea.ShowMe());
            }
            else
            {
                Console.WriteLine("对不起！没有对应的教师信息！");
            }
        }


        /// <summary>
        /// 打印菜单
        /// </summary>
        public override void PrintMenu()
        {
            Console.WriteLine("教师信息管理系统--菜单如下：");
            Console.WriteLine("0.注销");
            Console.WriteLine("1.增加教师信息");
            Console.WriteLine("2.查询所有教师信息");
            Console.WriteLine("3.修改教师信息");
            Console.WriteLine("4.删除教师信息");
            Console.WriteLine("5.按教师编号查询对应的教师信息");
            Console.WriteLine("6.按姓名查询对应的教师信息");
        }

        /// <summary>
        /// 得到查询的教师编号
        /// </summary>
        /// <returns>查询的教师编号</returns>
        public override string QueryByPrimaryKey()
        {
            string teaNo = null;

            Console.WriteLine("请输入要查询的教师编号：");
            teaNo = Console.ReadLine();

            return teaNo;
        }
    }
}
