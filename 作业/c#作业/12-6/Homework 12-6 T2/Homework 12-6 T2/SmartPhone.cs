using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12_6_T2
{
    public class SmartPhone:Phone
    {
        public SmartPhone()
        { }

        public SmartPhone(int size, string type):base(type)
        {
            this.size = size;
        }

        private int size;
        public int Size
        {
            set { size = value; }
            get { return size; }
        }

        public new void ShowMe()
        {
            Console.WriteLine("智能手机:"+size);
        }

        public override void ShowMe1()
        {
            Console.WriteLine("智能的");
        }
    }
}
