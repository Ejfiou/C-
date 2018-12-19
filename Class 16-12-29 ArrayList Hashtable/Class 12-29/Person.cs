using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_12_29
{
    class Person
    {
        public Person()
        {

        }

        public Person(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        
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

        public string ShowMe()
        {
            return $"姓名：{name}\t年龄：{age}";
        }

        public override string ToString()
        {
            return $"姓名：{name}\t年龄：{age}";
        }
    }
}
