using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_30
{
    public class MyObjectPersonView : MyObjectView
    {
        public override IMyObject Create()
        {
            IMyObject per = null;

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

        public override IMyObject Modify()
        {
            IMyObject per = null;

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

        public override void PrintMany(IMyObject[] objs)
        {
            Console.WriteLine("\n************人的信息如下*******************");

            if (objs != null)
            {
                for (int i = 0; i < objs.Length; i++)
                {
                    Console.WriteLine(objs[i].ShowMe());
                }
            }
            else
            {
                Console.WriteLine("对不起！当前没有任何人的信息！");
            }
        }

        public override void PrintMenu()
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

        public override void PrintOne(IMyObject obj)
        {
            Console.WriteLine("\n************人的信息如下*******************");

            if (obj != null)
            {
                Console.WriteLine(obj.ShowMe());
            }
            else
            {
                Console.WriteLine("对不起！没有对应的人的信息！");
            }
        }

        public override IMyObject QueryByNonPrimaryKey()
        {
            IMyObject temp = null;

            Console.WriteLine("请输入要查询的姓名：");
            string name = Console.ReadLine();

            temp = new Person("", name, 0);

            return temp;
        }

        public override string QueryByPrimaryKey()
        {
            string stuNo = null;

            Console.WriteLine("请输入要查询的身份证：");
            stuNo = Console.ReadLine();

            return stuNo;
        }
    

        public override IMyObject Remove()
        {
            IMyObject per = null;

            Console.Write("请输入要删除的人的身份证：");
            string cardID = Console.ReadLine();

            per = new Person(cardID);

            return per;
        }
    }
}
