using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_12_6
{
    public class Father
    {
        public Father()
        {
            Console.WriteLine("Fathe无参数的构造函数");
        }

        public Father(string name)
        {
            Console.WriteLine("Father一个参数的构造函数");
            this.name = name;
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void ShowFather()
        {
            Console.WriteLine("Father"+name);
        }

        public void Test()
        {
            Console.WriteLine("Father Test");
        }

        /// <summary>
        /// 虚方法
        /// </summary>
        public virtual void Test1()
        {
            Console.WriteLine("Father Test1");
        }
    }
}
