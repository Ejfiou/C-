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
    public class Student:Person
    {
        public Student()
        {

        }

        public Student(string stuNo)
        {
            StuNo = stuNo;
        }

        //有参数的构造函数
        public Student(string stuNo,string name,int age):base(name,age)
        {
            StuNo = stuNo;
            //this.age = age;
            //this.name = name;
        }

        /// <summary>
        /// 设置主键
        /// 将学号设置为主键
        /// </summary>
        public override string PrimaryKey
        {
            get { return stuNo; }
            set { stuNo = value; }
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

        public override string ShowMe()
        {
            //return "学号：\t" + this.stuNo + "\t姓名：\t" + base.Name + "\t年龄：\t" + base.Age;
            return string.Format("学号：{0,-10}姓名：{1,-10}年龄：{2,5}", stuNo, Name, Age);
        }
    }
}
