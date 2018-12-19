using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_12_8
{
    public class Test:Father,ITest,ITest1  //实现接口
    {
        public Test()
        {

        }

        //实现接口
        private string name;
        public string Name
        {
            get{ return name; }

            set{ name = value; }            
        }

        public void MyTest()
        {
            Console.WriteLine("Hello"+name);
        }


    }
    public class Test1 : Father1, ITest
    {
        private string name;
        public string Name
        {
            get { return name; }

            set { name = value; }
        }

        public override void MyTest()
        {
            Console.WriteLine("Hi" + name);
        }
    }

}
