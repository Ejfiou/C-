using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_02_21
{

    //委托
    public delegate void TestDelegate(string s);
    public delegate int TestDelegate1(int i);
    public delegate string TestDelegateString(string s);
    

    class Program
    {
        
        static void Main(string[] args)
        {

            //MyTest("tom");

            ////实例化委托
            //TestDelegate t = new TestDelegate(MyTest);
            //t("jack");

            //TestDelegate1 t1 = new TestDelegate1(MyTest1);
            ////接收返回值
            //int n = t1(6);  
            //Console.WriteLine(n); //7

            //测试字符窜数组
            //TestDelegateString testString1 = new TestDelegateString(T2);//或者传T1
            //TestArray(testString1);

            //匿名方法
            //TestDelegateString testAnonymous = delegate (string s)
            //{
            //    return s + "2";
            //};
            //TestArray(testAnonymous);

            //lambda 表达式
            //TestDelegateString testAnonymous = (string s) => s + "2";//或者{return s+"2";};
            //TestDelegateString testAnonymous = s => s + "3";
            //TestArray(testAnonymous);

            //无参数无返回
            //Action a = () => Console.WriteLine("这是无参数，无返回的方法");
            //a();


            ////有参数无返回
            //Action<string> a1 = (q) => Console.WriteLine("hello "+q);
            //a1("tom");

            ////无参数有返回
            //Func<string> f = () => "ss";
            //string s = f();
            //Console.WriteLine(s);

            ////前面为参数，最后一个返回类型
            //Func<string, string> f1 = t => t + "8";
            //string s1 =  f1("tom");
            //Console.WriteLine(s1);

            //Func<int, int, int> f2 = (num1, num2) => num1 + num2;
            //Console.WriteLine(f2(1,1));

            ////有bool型的返回值
            //Predicate<int> p = num => num >3;
            //Console.WriteLine(p(1));

            //选出list中符合标准的数
            //List<int> list = new List<int> { 3, 2, 7, 9, 1 };
            //var result = list.Where(n => n > 4);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //多播委托
            //TestDelegateString tMul = new TestDelegateString(T2);
            //TestDelegateString tMul = T1;
            //tMul += T2;
            //Console.WriteLine(tMul("tom"));


            //发布者
            Clock clock = new Clock();
            //事件订阅（订阅者）(两个学生订阅了事件)
            Student stu1 = new Student() { Name = "tom" };
            Student stu2 = new Student() { Name = "jack" };
            clock.TestEvent += stu1.ShowMe;
            clock.TestEvent += stu2.ShowMe;

            clock.TestWinFormEvent += stu1.TestWinForm;
            clock.TestWinFormEvent += stu2.TestWinForm;
            clock.TestWinFormEvent += Clock_TestWinFormEvent;//Tab键生成的方法

            //触发事件
            clock.Sound();
        }

        

        private static void Clock_TestWinFormEvent(object source, MyEventArgs e)
        {
            Console.WriteLine("Tab键生成的方法"+e.Message);
        }

        public static void MyTest(string s)
        {
            Console.WriteLine("Hello "+s);
        }

        public static int MyTest1(int num)
        {
            Console.WriteLine("Hello1 " + num);
            return num + 1;
        }

        /// <summary>
        /// 测试委托方法
        /// </summary>
        /// <param name="p">委托</param>
        public static void TestArray(TestDelegateString p)
        {
            string[] strs = new string[] { "a", "b", "c" };
            for (int i = 0; i < strs.Length; i++)
            {
                strs[i] = p(strs[i]);
            }

            for (int i = 0; i < strs.Length; i++)
            {
                Console.WriteLine(strs[i]);
            }
        }

        public static string T1(string s)
        {
            Console.WriteLine("T1");
            return s.ToUpper();
        }

        public static string T2(string s)
        {
            Console.WriteLine("T2");
            return s + "1";
        }

    }
}
