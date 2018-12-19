using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12_6_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone p = new Phone();
            p.Type = "手机";
            p.ShowMe();
            p.ShowMe1();
            Console.WriteLine();

            SmartPhone sp = new SmartPhone();
            sp.Size = 15;
            sp.ShowMe();
            sp.ShowMe1();
            Console.WriteLine();

            OldPhone op = new OldPhone();
            op.Size = 16;
            op.ShowMe();
            op.ShowMe1();
            Console.WriteLine();

            Phone p1 = new SmartPhone(15,"手机");
            p1.ShowMe();
            p1.ShowMe1();
            Console.WriteLine();

            Phone p2 = new OldPhone(16,"手机");
            p2.ShowMe();
            p2.ShowMe1();
            Console.WriteLine();

            Phone[] po = new Phone[3];
            po[0] = new Phone("手机");
            po[1] = new SmartPhone(15, "手机");
            po[2] = new OldPhone(16, "手机");
            Console.WriteLine("覆盖：");
            for (int a = 0; a < po.Length; a++)
            {
                po[a].ShowMe();
            }
            Console.WriteLine("重写：");
            for (int a = 0; a < po.Length; a++)
            {
                po[a].ShowMe1();
            }
        }
    }
}
