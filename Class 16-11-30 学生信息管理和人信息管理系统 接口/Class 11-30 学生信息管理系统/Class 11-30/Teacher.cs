using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_30
{
    public class Teacher:Person
    {
        public Teacher(string teaNo)
        {
            this.teaNo = teaNo;
        }

        //有参数的构造函数
        public Teacher(string teaNo, string name, int age):base(name,age)
        {
            TeaNo = teaNo;
        }

        /// <summary>
        /// 设置主键
        /// 将教师编号设置为主键
        /// </summary>
        public override string PrimaryKey
        {
            get { return TeaNo; }
            set { TeaNo = value; }
        }

        //教师编号
        private string teaNo;
        /// <summary>
        /// 教师编号,唯一的，不能重复
        /// </summary>
        public string TeaNo
        {
            get { return teaNo; }
            set { teaNo = value; }
        }

        public override string ShowMe()
        {
            return "教师编号：\t" + this.teaNo + "\t姓名：\t" + base.Name + "\t年龄：\t" + base.Age;
        }
    }
}
