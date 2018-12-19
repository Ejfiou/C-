using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12_6_T1
{
    public class Car
    {
        public Car()
        {

        }

        public Car(int size)
        {
            this.size = size;
        }

        private int size;
        public int Size
        {
            set { size = value; }
            get { return size; }
        }

        public void ShowMe()
        {
            Console.WriteLine("储存车辆数为：" + size);
        }

        public virtual void ShowMe1()
        {
            Console.WriteLine("种类");
        }
    }
}
