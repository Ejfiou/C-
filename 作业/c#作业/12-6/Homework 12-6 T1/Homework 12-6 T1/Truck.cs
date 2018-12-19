using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12_6_T1
{
    public class Truck:Car
    {
        public Truck()
        {

        }

        public Truck(string kind, int size):base(size)
        {
            this.kind = kind;
        }

        private string kind;
        public string Kind
        {
            set { kind = value; }
            get { return kind; }
        }

        public new void ShowMe()
        {
            Console.WriteLine("种类为：" + kind);
        }

        public override void ShowMe1()
        {
            Console.WriteLine("货车");
        }
    }
}
