using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_30
{
    public class MyStudentView:MyPersonView
    {
        public MyStudentView()
        {

        }

        /// <summary>
        ///创建学生对象 
        /// </summary>
        /// <returns>学生对象</returns>
        public override Person Create()
        {
            Student stu = null;

            Console.Write("请输入学生的学号：");
            string stuNo = Console.ReadLine();
            Console.Write("请输入学生的姓名：");
            string name = Console.ReadLine();
            Console.Write("请输入学生的年龄：");
            string age = Console.ReadLine();

            int ageInt;
            bool f = int.TryParse(age, out ageInt);
            while (!f)
            {
                Console.Write("输入格式错误，请重新输入：");
                age = Console.ReadLine();
                f = int.TryParse(age, out ageInt);
            }

            stu = new Student(stuNo, name, ageInt);

            return stu;
        }

        /// <summary>
        /// 删除学生信息
        /// </summary>
        /// <returns>学生对象</returns>
        public override Person Remove()
        {
            Student stu = null;

            Console.Write("请输入要删除的学生的学号：");
            string stuNo = Console.ReadLine();

            stu = new Student(stuNo);

            return stu;
        }

        /// <summary>
        /// 修改学生信息
        /// </summary>
        /// <returns>学生对象</returns>
        public override Person Modify()
        {
            Student stu = null;

            Console.Write("请输入要修改学生的学号：");
            string stuNo = Console.ReadLine();
            Console.Write("请输入要修改学生的姓名：");
            string name = Console.ReadLine();
            Console.Write("请输入要修改学生的年龄：");
            string age = Console.ReadLine();

            int ageInt;
            bool f = int.TryParse(age, out ageInt);
            while (!f)
            {
                Console.Write("输入格式错误，请重新输入：");
                age = Console.ReadLine();
                f = int.TryParse(age, out ageInt);
            }

            stu = new Student(stuNo, name, ageInt);

            return stu;
        }


        /// <summary>
        /// 显示多个学生信息
        /// </summary>
        /// <param name="stus">要显示的学生信息的数组</param>
        public override void PrintMany(Person[] stus)
        {
            Console.WriteLine("\n************学生信息如下*******************");

            if (stus != null)
            {
                for (int i = 0; i < stus.Length; i++)
                {
                    Console.WriteLine(stus[i].ShowMe());
                }
            }
            else
            {
                Console.WriteLine("对不起！当前没有任何学生信息！");
            }
        }

        /// <summary>
        /// 打印一个学生信息
        /// </summary>
        /// <param name="stus">要显示的学生信息</param>
        public override void PrintOne(Person stu)
        {
            Console.WriteLine("\n************学生信息如下*******************");

            if (stu != null)
            {
                Console.WriteLine(stu.ShowMe());
            }
            else
            {
                Console.WriteLine("对不起！没有对应的学生信息！");
            }
        }

        public void Clear1()
        {
            Console.Clear();
        }
        /// <summary>
        /// 打印菜单
        /// </summary>
        public override void PrintMenu()
        {
            Console.WriteLine("学生信息管理系统--菜单如下：");
            Console.WriteLine("0.注销");
            Console.WriteLine("1.增加学生信息");
            Console.WriteLine("2.查询所有学生信息");
            Console.WriteLine("3.修改学生信息");
            Console.WriteLine("4.删除学生信息");
            Console.WriteLine("5.按学号查询对应的学生信息");
            Console.WriteLine("6.按姓名查询对应的学生信息");
        }


        /// <summary>
        /// 得到查询的学号
        /// </summary>
        /// <returns>查询的学号</returns>
        public override string QueryByPrimaryKey()
        {
            string stuNo = null;

            Console.WriteLine("请输入要查询的学号：");
            stuNo = Console.ReadLine();

            return stuNo;
        }
    }
}
