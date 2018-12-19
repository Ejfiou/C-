using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_1_3
{
    public class Person
    {
        

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private Genders sex;

        public Genders Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public string ShowMe()
        {
            return $"姓名：{name,-10}性别：{sex,-6}年龄：{age}";
        }
    }
}
