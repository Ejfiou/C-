using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace Class_03_07
{
    class Program
    {
        static void Main(string[] args)
        {
            //获取全部进程
            Process[] pro = Process.GetProcesses();
            foreach (var item in pro)
            {
                Console.WriteLine(item.ProcessName);
            }
            Console.WriteLine(pro.Length);

            //打开一个进程
            // Process p = Process.Start("notepad.exe");
            //Console.ReadLine();
            //杀死进程
            //p.Kill();

            //应用程序域
            //Console.WriteLine(AppDomain.CurrentDomain.FriendlyName);
            //创建域
            //AppDomain app = AppDomain.CreateDomain("MyAppDomain");
            //app.ExecuteAssembly(@"E:\课堂做的\Class 11-8 打印星星\Class 11-8\bin\Debug\Class 11-8.exe");

            // TakesAWhile(2000);

            //创建线程方法一(定义委托)
            //Action action = TakesAWhile;
            //action.BeginInvoke(null, null); //无参数无返回
            //Action<int> action = TakesAWhile;
            //6秒执行
            //action.BeginInvoke(6000, null, null);//一个参数,无返回

            //定义一个委托           
            //Func<int, int, int> func = TakesAWhile;
            //异步执行(线程)
            // func.BeginInvoke(6000, 8, TakesAWhileCompleted, func);//两参数，一还回

            //创建线程方法二
            //Thread th = new Thread(TakesAWhile);
            //th.IsBackground = true;
            //th.Start();

            ////10秒执行
            //for (int i = 0; i < 100; i++)
            //{
            //    Console.Write("."+i);
            //    Thread.Sleep(100);
            //}
            //Console.WriteLine();


            //同步处理
            //Warehouse house = new Warehouse() { Number = 100 };
            ////入库
            //Thread threadIn = new Thread(()=> { 
            //    for (int i = 0; i < 1000; i++)
            //    {
            //        //加锁
            //        Monitor.Enter(house);
            //        house.Number++;
            //        Console.WriteLine("当前仓库的数量是：" + house.Number);
            //        Monitor.Exit(house);
            //        Thread.Sleep(10);
            //    }
            //});
            //threadIn.IsBackground = true;

            ////出库
            //Thread threadOut = new Thread(() =>{
            //    for (int i = 0; i < 1000; i++)
            //    {
            //        Monitor.Enter(house);
            //        house.Number--;
            //        Console.WriteLine("当前仓库的数量是：" + house.Number);
            //        Monitor.Exit(house);
            //        Thread.Sleep(10);
            //    }
            //});
            //threadOut.IsBackground = true;
            //threadIn.Start();
            //threadOut.Start();
            //Console.ReadKey();


            //创建MyConnection池
            //MyConnection[] my = new MyConnection[10];
            //int index = 0; //作为存放或读取对象的下标

            ////5个生产者
            //for (int i = 0; i < 5; i++)
            //{
            //    Thread producer = new Thread(()=> {
            //        while (true)
            //        {
            //            lock (my)
            //            {
            //                if (index < my.Length)
            //                {
            //                    Console.WriteLine("生产了一个对象");
            //                    MyConnection con = new MyConnection();
            //                    my[index] = con;
            //                    index++;
            //                }
            //            }

            //            Thread.Sleep(100);
            //        }
            //    });
            //    producer.IsBackground = true;
            //    producer.Start();
            //}

            ////10个消费者
            //for (int i = 0; i < 10; i++)
            //{
            //    Thread comsumer = new Thread(() => {
            //        while (true)
            //        {
            //            lock (my)
            //            {
            //                if (index > 0)
            //                {
            //                    index--;

            //                    Console.WriteLine("消费了一个对象");
            //                    my[index] = null;
            //                }
            //            }
            //            Thread.Sleep(100);
            //        }
            //    });
            //    comsumer.IsBackground =true;
            //    comsumer.Start();
            //}

            //线程池
            ThreadPool.QueueUserWorkItem(TakesAWhile,8);
            Thread.Sleep(4000);
            Console.WriteLine(result);
            //暂停主线程
            Console.ReadLine();
        }

        static int result = -1;



        static void TakesAWhile()
        {
            Console.WriteLine("TasksAWhile started");
            Thread.Sleep(4000);
            Console.WriteLine("TaskAWhile completed");
        }

        static void TakesAWhile(object o)
        {
            Console.WriteLine("TasksAWhile started");
            Thread.Sleep(4000);
            Console.WriteLine("TaskAWhile completed");

            int temp = (int)o;
            temp++;
            result = temp;
        }

        static void TakesAWhile(int ms)
        {
            Console.WriteLine("TasksAWhile started");
            Thread.Sleep(ms);
            Console.WriteLine("TaskAWhile completed");
        }

        static int TakesAWhile(int ms,int data)
        {
            Console.WriteLine("TasksAWhile started");
            Thread.Sleep(ms);
            Console.WriteLine("TaskAWhile completed");
            data++;
            return data;
        }

        //回调函数
        static void TakesAWhileCompleted(IAsyncResult ar)
        {
            //获取用户定义的对象(转换成委托类型)
            var func =  ar.AsyncState as Func<int, int, int>;

            //得到线程执行完之后的返回值
            int data = func.EndInvoke(ar);
            Console.WriteLine(data);
        }
    }
}
