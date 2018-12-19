using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_12_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test t = new Test();
            //t.MyTest();

            //ITest i =  new Test(); //接口
            //i.Name = "tom";
            //i.MyTest();

            ////ITest i = new Test();
            ////i.Name = "tom";
            ////ITest1 i1 = new Test();
            ////i1.MyTest();

            //Test o = new Test();
            //ITest i = o;
            //i.Name = "tom";
            //ITest1 i1 = o;
            //i1.MyTest();
            //Father f = o;
            //f.F();

            //Father[] fs = new Father[2];
            //fs[0] = new Father();
            //fs[1] = new Test();
            //for (int i=0;i<fs.Length;i++)
            //{
            //    fs[i].F();
            //}
            //for(int i=0;i<fs.Length;i++)
            //{
            //    if(fs[i] is Test)
            //    {
            //        //Console.WriteLine("yes"+i);
            //        //((Test)fs[i]).MyTest();//强转化为Test
            //        (fs[i] as Test).MyTest();
            //    }
                
            //    if(fs[i] is ITest)
            //    {
            //        Console.WriteLine((fs[i] as ITest).Name);
            //    }

            //    if(fs[i] is ITest1)
            //    {
            //       (fs[i] as ITest1).MyTest();
            //    }                                
            //}

            Test1 t = new Test1();
            t.Name = "tom";
            t.MyTest();



        }
    }
}
