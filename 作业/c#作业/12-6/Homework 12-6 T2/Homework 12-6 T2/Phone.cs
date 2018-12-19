using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12_6_T2
{
    public class Phone
    {
        public Phone()
        { }

        public Phone(string type)
        {
            this.type = type;
        }
        private string type;
        public string Type
        {
            set { type = value; }
            get { return type; }
        }

        public void ShowMe()
        {
            Console.WriteLine("种类：" + type);
        }
        public virtual void ShowMe1()
        {
            Console.WriteLine("手机");
        }
    }
}
