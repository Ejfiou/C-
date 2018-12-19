using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_02_21
{
    public class Student
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void ShowMe(string s)
        {
            Console.WriteLine($"我是:{name} 参数:{s}");
        }

        public void TestWinForm(object source, MyEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
