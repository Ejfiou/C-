using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_30
{
    /// <summary>
    /// 学生信息
    /// </summary>
    public class Student
    {
        
        public Student()
        {

        }

        public Student(string stuNo)
        {
            StuNo = stuNo;
        }

        //有参数的构造函数
        public Student(string stuNo,string name,int age)
        {
            StuNo = stuNo;
            Name = name;
            Age = age;           
        }

        //学号
        private string stuNo;
        /// <summary>
        /// 学号,唯一的，不能重复
        /// </summary>
        public string StuNo
        {
            get { return stuNo; }
            set { stuNo = value; }
        }

        //姓名
        private string name;
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //年龄
        private int age;
        /// <summary>
        /// 年龄
        /// </summary>
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string ShowMe()
        {
            return "学号：\t" + stuNo + "\t姓名：\t" + name + "\t年龄：\t" + age;
        }
    }
}
