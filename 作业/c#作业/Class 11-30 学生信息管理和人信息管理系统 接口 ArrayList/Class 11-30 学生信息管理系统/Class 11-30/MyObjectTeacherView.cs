using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Class_11_30
{
    public class MyObjectTeacherView : MyObjectPersonView
    {
        public override IMyObject Create()
        {
            IMyObject tea = null;

            Console.Write("请输入教师的编号(以Tea开头)：");
            string teaNo = Console.ReadLine().Trim();
            while (Regex.IsMatch(teaNo,@"^Tea")==false)
            {
                Console.Write("输入有误!请重新输入教师编号(Tea开头)：");
                teaNo = Console.ReadLine().Trim();
            }

            Console.Write("请输入教师的姓名：");
            string name = Console.ReadLine().Trim();
            while (Regex.IsMatch(name, @"^\w+$") == false)
            {
                Console.Write("输入有误！请重新输入姓名：");
                name = Console.ReadLine().Trim();
            }

            Console.Write("请输入教师的年龄(20-60)：");
            string age = Console.ReadLine().Trim();
            while (Regex.IsMatch(age,@"[2-5][0-9]||60")==false)
            {
                Console.Write("输入错误！请重新输入年龄(20-60)：");
                name = Console.ReadLine().Trim();
            }

            int ageInt;
            bool f = int.TryParse(age, out ageInt);

            tea = new Teacher(teaNo, name, ageInt);

            return tea;
        }

        public override IMyObject Modify()
        {
            IMyObject tea = null;

            Console.Write("请输入要修改教师的编号：");
            string teaNo = Console.ReadLine().Trim();
            while (Regex.IsMatch(teaNo, @"^Tea") == false)
            {
                Console.Write("输入有误!请重新输入教师编号(Tea开头)：");
                teaNo = Console.ReadLine().Trim();
            }

            Console.Write("请输入修改后教师的姓名：");
            string name = Console.ReadLine().Trim();
            while (Regex.IsMatch(name, @"^\w+$") == false)
            {
                Console.Write("输入有误！请重新输入姓名：");
                name = Console.ReadLine().Trim();
            }

            Console.Write("请输入修改后教师的年龄：");
            string age = Console.ReadLine().Trim();
            while (Regex.IsMatch(age, @"[2-5][0-9]||60") == false)
            {
                Console.Write("输入错误！请重新输入年龄(20-60)：");
                name = Console.ReadLine().Trim();
            }

            int ageInt;
            bool f = int.TryParse(age, out ageInt);

            tea = new Teacher(teaNo, name, ageInt);

            return tea;
        }

        public override void PrintMany(IMyObject[] objs)
        {
            Console.WriteLine("\n************教师信息如下*******************");

            if (objs != null)
            {
                for (int i = 0; i < objs.Length; i++)
                {
                    Console.WriteLine(objs[i].ShowMe());
                }
            }
            else
            {
                Console.WriteLine("对不起！当前没有任何教师信息！");
            }
        }

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

        public override void PrintOne(IMyObject obj)
        {
            Console.WriteLine("\n************教师信息如下*******************");

            if (obj != null)
            {
                Console.WriteLine(obj.ShowMe());
            }
            else
            {
                Console.WriteLine("对不起！没有对应的教师信息！");
            }
        }

        public override string QueryByPrimaryKey()
        {
            string teaNo = null;

            Console.Write("请输入要查询的教师编号(以Tea开头)：");
            teaNo = Console.ReadLine().Trim();
            while (Regex.IsMatch(teaNo, @"^Tea") == false)
            {
                Console.Write("输入有误!请重新输入教师编号(Tea开头)：");
                teaNo = Console.ReadLine().Trim();
            }

            return teaNo;
        }

        public override IMyObject Remove()
        {
            IMyObject tea = null;

            Console.Write("请输入要删除的教师的编号：");
            string teaNo = Console.ReadLine().Trim();
            while (Regex.IsMatch(teaNo, @"^Tea") == false)
            {
                Console.Write("输入有误!请重新输入教师编号(Tea开头)：");
                teaNo = Console.ReadLine().Trim();
            }

            tea = new Teacher(teaNo);

            return tea;
        }
    }
}
