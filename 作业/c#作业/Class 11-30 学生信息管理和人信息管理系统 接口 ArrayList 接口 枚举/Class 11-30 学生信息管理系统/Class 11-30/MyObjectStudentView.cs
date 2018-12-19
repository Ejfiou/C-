using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Class_11_30
{
    /// <summary>
    /// 学生信息管理系统
    /// </summary>
    public class MyObjectStudentView:MyObjectPersonView
    {
        public MyObjectStudentView()
        {

        }

        public override IMyObject Create()
        {
            IMyObject stu = null;

            Console.Write("请输入学生的学号(以Stu开头)：");
            string stuNo = Console.ReadLine().Trim();
            while (Regex.IsMatch(stuNo,@"^Stu")==false)
            {
                Console.Write("输入有误！请重新输入学号（以Stu开头）：");
                stuNo = Console.ReadLine();
            }

            Console.Write("请输入学生的姓名：");
            string name = Console.ReadLine().Trim();
            while (Regex.IsMatch(name, @"^\w+$") == false)
            {
                Console.Write("输入有误！请重新输入姓名：");
                name = Console.ReadLine().Trim();
            }

            Console.Write("请输入学生的年龄(1-60)：");
            string age = Console.ReadLine().Trim();
            while (Regex.IsMatch(age, @"^(([1-9])|([1-5][0-9])|(60))$") == false)
            {
                Console.Write("输入错误！请重新输入年龄(20-60)：");
                age = Console.ReadLine().Trim();
            }
            int ageInt;
            bool f = int.TryParse(age, out ageInt);

            Console.Write("请选择学生的性别：(0-男,1-女)：");
            string sex = Console.ReadLine().Trim();
            while (Regex.IsMatch(sex, @"^[0-1]$")==false)
            {
                Console.Write("输入有误！请重新选择性别(0-男,1-女)：");
                sex = Console.ReadLine().Trim();
            }
            int sexInt;
            int.TryParse(sex, out sexInt);

            stu = new Student(stuNo, name, ageInt,(Genders)sexInt);

            return stu;
        }

        public override IMyObject Modify()
        {
            IMyObject stu = null;

            Console.Write("请输入要修改学生的学号(以Stu开头)：");
            string stuNo = Console.ReadLine().Trim();
            while (Regex.IsMatch(stuNo, @"^Stu") == false)
            {
                Console.Write("输入有误！请重新输入学号（以Stu开头）：");
                stuNo = Console.ReadLine();
            }

            Console.Write("请输入要修改后学生的姓名：");
            string name = Console.ReadLine().Trim();
            while (Regex.IsMatch(name, @"^\w+$") == false)
            {
                Console.Write("输入有误！请重新输入姓名：");
                name = Console.ReadLine().Trim();
            }

            Console.Write("请输入要修改学生的年龄：");
            string age = Console.ReadLine().Trim();
            while (Regex.IsMatch(age, @"^(([1-9])|([1-5][0-9])|(60))$") == false)
            {
                Console.Write("输入错误！请重新输入年龄(20-60)：");
                age = Console.ReadLine().Trim();
            }
            int ageInt;
            bool f = int.TryParse(age, out ageInt);


            Console.Write("请选择修改后的学生的性别：(0-男,1-女)：");
            string sex = Console.ReadLine().Trim();
            while (Regex.IsMatch(sex, @"^[0-1]$")==false)
            {
                Console.Write("输入有误！请重新选择性别(0-男,1-女)：");
                sex = Console.ReadLine().Trim();
            }
            int sexInt;
            int.TryParse(sex, out sexInt);
            stu = new Student(stuNo, name, ageInt,(Genders)sexInt);

            return stu;
        }

        public override IMyObject Remove()
        {
            IMyObject stu = null;

            Console.Write("请输入要删除的学生的学号(以Stu开头)：");
            string stuNo = Console.ReadLine().Trim();
            while (Regex.IsMatch(stuNo, @"^Stu") == false)
            {
                Console.Write("输入有误！请重新输入学号（以Stu开头）：");
                stuNo = Console.ReadLine();
            }

            stu = new Student(stuNo);

            return stu;
        }

        public override void PrintMany(IMyObject[] objs)
        {
            Console.WriteLine("\n************学生信息如下*******************");

            if (objs != null)
            {
                for (int i = 0; i < objs.Length; i++)
                {
                    Console.WriteLine(objs[i].ShowMe());
                }
            }
            else
            {
                Console.WriteLine("对不起！当前没有任何学生信息！");
            }
        }

        public override void PrintOne(IMyObject obj)
        {
            Console.WriteLine("\n************学生信息如下*******************");

            if (obj != null)
            {
                Console.WriteLine(obj.ShowMe());
            }
            else
            {
                Console.WriteLine("对不起！没有对应的学生信息！");
            }
        }

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

        public override string QueryByPrimaryKey()
        {
            Console.Write("请输入要查询的学生的学号(以Stu开头)：");
            string stuNo = Console.ReadLine().Trim();
            while (Regex.IsMatch(stuNo, @"^Stu") == false)
            {
                Console.Write("输入有误！请重新输入学号（以Stu开头）：");
                stuNo = Console.ReadLine();
            }
            return stuNo;
        }

        public override IMyObject QueryByNonPrimaryKey()
        {
            IMyObject temp = null;

            Console.Write("请输入要查询的学生的姓名：");
            string name = Console.ReadLine().Trim();
            while (Regex.IsMatch(name, @"^\w+$") == false)
            {
                Console.Write("输入有误！请重新输入姓名：");
                name = Console.ReadLine().Trim();
            }

            temp = new Person("", name, 0);

            return temp;
        }
    }
}
