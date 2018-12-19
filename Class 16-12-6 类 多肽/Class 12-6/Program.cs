using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_12_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Father f = new Father();
            //f.Name = "tom";
            ////f.ShowFather();
            //f.Test();
            //f.Test1();

            //Son s = new Son();
            //s.Name = "jj";//继承
            ////s.ShowSon();
            ////s.ShowFather();//继承来的
            //s.Test();
            //s.Test1();

            ////新的写法
            ////父类变量名（引用）=子类的实例（对象）
            //Father x = new Son();
            //x.Test();//（覆盖）调用父类方法
            //x.Test1();//（重写）调用子类

            Father[] arr = new Father[3];

            arr[0] = new Father();
            arr[1] = new Son();
            arr[2] = new Father();

            for(int i=0;i<arr.Length;i++)
            {
                arr[i].Test();
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].Test1();
            }






            //Father f = new Father();
            //Son s = new Son();
            //Son s1 = new Son("tom", "tt");
        }
    }
}
