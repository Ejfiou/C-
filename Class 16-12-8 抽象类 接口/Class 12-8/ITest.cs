using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_12_8
{
    public interface ITest
    {
        /// <summary>
        /// 姓名  （属性）
        /// </summary>
        string Name
        {
            set;
            get;
        }
    }

    public interface ITest1
    {
        void MyTest();
    }

    public class Father
    {
        public Father()
        {
                
        }
        public void F()
        {
            Console.WriteLine("Father");
        }
    }

    public abstract class Father1
    {
        public Father1()
        {

        }

        public void F1()
        {
            Console.WriteLine("Father1");
        }

        public abstract void MyTest();
    } 
}
