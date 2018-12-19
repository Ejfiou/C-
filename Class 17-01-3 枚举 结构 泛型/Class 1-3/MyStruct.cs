using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_1_3
{
    public struct MyStruct
    {

        public MyStruct(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public string name;

        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public void ShowMe()
        {
            Console.WriteLine("Hello!");
        }
    }
}
