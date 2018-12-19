using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_T1_11_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Student stu = new Student();
            stu.Name = "Tom";
            stu.Sex = "男";
            stu.Age = 17;
            stu.ShowMe();

            stu[0]="Jerry";
            stu[1] = "女";
            stu[2] = "12";
            stu.ShowMe();

        }

    }
}
