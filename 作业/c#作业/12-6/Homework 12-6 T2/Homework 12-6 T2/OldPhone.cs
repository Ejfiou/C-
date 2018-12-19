using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12_6_T2
{
    class OldPhone:Phone
    {
        public OldPhone()
        { }

        public OldPhone(int size, string type):base(type)
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
            Console.WriteLine("老年手机:"+size);
        }

        public override void ShowMe1()
        {
            Console.WriteLine("老年手机");
        }
    }
}
