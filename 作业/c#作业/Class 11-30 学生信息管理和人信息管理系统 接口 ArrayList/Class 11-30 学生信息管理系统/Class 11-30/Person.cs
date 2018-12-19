using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_30
{
    /// <summary>
    /// 一个人信息
    /// </summary>
    public class Person:IMyObject
    {
        public Person()
        {

        }

        public Person(string cardID)
        {
            this.cardID = cardID;
        }
        public Person(string name, int age)
        {
            this.age = age;
            this.name = name;
        }
        public Person(string cardID,string name,int age)
        {
            this.cardID = cardID;
            this.age = age;
            this.name = name;
        }

        /// <summary>
        /// 设置主键
        /// 将身份证设置为主键
        /// </summary>
        public virtual string PrimaryKey
        {
            get { return cardID; }
            set { cardID = value; }
        }

        //身份证
        private string cardID;
        /// <summary>
        /// 身份证
        /// </summary>
        public string CardID
        {
            get { return cardID; }
            set { cardID = value; }
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

        public virtual string ShowMe()
        {
            //return "身份证：\t" + this.cardID + "\t姓名：\t" + Name + "\t年龄：\t" + Age;
            //return string.Format("身份证：\t{0}\t姓名：\t{1}\t年龄：\t{2}",cardID,name,age);
            //return string.Format("身份证：{0,-25}姓名：{1,-10}年龄：{2,5}",cardID, name, age);
            return $"身份证：{cardID,-25}姓名：{name,-10}年龄：{age,5}";
        }


    }
}
