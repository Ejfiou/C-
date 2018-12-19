using System;//16  14
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_30
{
    /// <summary>
    /// 程序界面
    /// </summary>
   public class MyView
    {
        public MyView()
        {

        }

        /// <summary>
        ///创建学生对象 
        /// </summary>
        /// <returns>学生对象</returns>
        public Student CreatStudent()
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
        public Student RemoveStudent()
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
        public Student ModifyStudent()
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
        /// 显示学生信息
        /// </summary>
        /// <param name="stus">要显示的学生信息的数组</param>
        public void PrintAllStudents(Student[] stus)
        {
            Console.WriteLine("\n************学生信息如下*******************");
            Student stu = new Student();
            if (stus != null)
            {
                for (int i=0;i<stus.Length;i++)
                {
                    Console.WriteLine(stus[i].ShowMe()+stu.Age);
                }
            }
            else
            {
                Console.WriteLine("对不起！当前没有任何学生信息！");
            }           
        } 

        /// <summary>
        /// 打印成功
        /// </summary>
        public void PrintSuccess()
        {
            Console.WriteLine("成功！");
        }
        /// <summary>
        /// 打印失败
        /// </summary>
        public void PrintFail()
        {
            Console.WriteLine("失败！");
        }

        /// <summary>
        /// 打印菜单
        /// </summary>
        public void PrintMenu()
        {
            Console.WriteLine("学生信息管理系统--菜单如下：");
            Console.WriteLine("0.退出系统");
            Console.WriteLine("1.增加学生信息");
            Console.WriteLine("2.查询所有学生信息");
            Console.WriteLine("3.修改学生信息");
            Console.WriteLine("4.删除学生信息");
            Console.WriteLine("5.按学号查询对应的学生信息");
            Console.WriteLine("6.按姓名查询对应的学生信息");
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
            while(!f)
            {
                Console.Write("您的输入有误，请重新输入：");
                f = int.TryParse(Console.ReadLine(), out menuIndex);
            }

            return menuIndex;
        }

        /// <summary>
        /// 没有找到功能
        /// </summary>
        public void NotFound()
        {
            Console.WriteLine("对不起！没有实现您要的功能！");
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
        /// 得到查询的学号
        /// </summary>
        /// <returns>查询的学号</returns>
        public string QueryStudentByStuNo()
        {
            string stuNo = null;

            Console.WriteLine("请输入要查询的学号：");
            stuNo = Console.ReadLine();

            return stuNo;
        }

        /// <summary>
        /// 打印一个学生信息
        /// </summary>
        /// <param name="stus">要显示的学生信息</param>
        public void PrintStudent(Student stu)
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

        /// <summary>
        /// 得到查询的姓名
        /// </summary>
        /// <returns>查询的姓名</returns>
        public string QueryStudentsByName()
        {
            string name = null;

            Console.WriteLine("请输入要查询的姓名：");
            name = Console.ReadLine();

            return name;
        }
    }
}
