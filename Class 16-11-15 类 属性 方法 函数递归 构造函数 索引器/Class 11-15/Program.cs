using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// 2016年11月15日09:18:49
/// 课堂做的：类 对象 方法
/// </summary>
namespace Class_11_15
{
    class Program
    {
        static void Main(string[] args)
        {
            //    //类名  对象名 = 所产生的对象
            Book bk = new Book();

            //    bk.Title = "365故事";
            //    bk.Size = 8;    //赋值 set
            //    bk.Color = "蓝色";

            //    Book tk = new Book();
            //    tk.Title = "辅导";
            //    tk.Size = -40;
            //    tk.Color = "黄色";

            //    Console.WriteLine(bk.Title);
            //    Console.WriteLine(bk.Size);//取值 get
            //    Console.WriteLine(bk.Color);

            //    Console.WriteLine(tk.Title);
            //    Console.WriteLine(tk.Size);
            //    Console.WriteLine(tk.Color);

            //    bk.Read(); //调用方法
            //    tk.Read();

            //    bk.Sleep();
            //    tk.Sleep();

            //    bk.ShowMe();
            //    tk.ShowMe();

            //    bk.Show();
            //    tk.Show();

            //    bk.B(15);
            //    tk.B(-30);

            //    bk.C(2, 100);
            //    tk.C(2, 100);

            //    ////int temp = bk.TestReturn();
            //    //Console.WriteLine(temp);
            //    string r = bk.Test1(5,"jj");
            //    Console.WriteLine(r);

            //int m = 6;
            //bk.TestRef(ref m);
            //Console.WriteLine(m); //9


            //int temp1;
            //int temp = bk.TestOut(out temp1 );
            //Console.WriteLine(temp);//8
            //Console.WriteLine(temp1);//6


            //string s = "kljjj";
            //bk.TestRef(ref s);
            //Console.WriteLine(s);//sjfdfj

            //int b = 5, a = 3;
            //bk.TestRef(ref b,ref a);
            //Console.WriteLine(b);//6
            //Console.WriteLine(a);//4


            //string i,j,k;
            //string s = bk.TestOut(out i,out j,out k);
            //Console.WriteLine(i);//ttttt
            //Console.WriteLine(j);//sssss
            //Console.WriteLine(k);//aaaaa
            //Console.WriteLine(s);//return

            //int m = 6;
            //bk.Te(m++);
            //Console.WriteLine(m);
            //bk.Ref(ref m);
            //Console.WriteLine(m);

            //int temp1 = 100;

            //int temp = bk.Out(5, out temp1);
            //Console.WriteLine(temp1);
            //Console.WriteLine(temp);



            //Book c = new Book();
            ////奇数
            //string str;
            //int a;
            //Console.Write("请输入一个数字：");
            //bool f = int.TryParse(Console.ReadLine(), out a);
            //while (!f)
            //{
            //    Console.Write("您输入的格式不正确，请重新输入：");
            //    f = int.TryParse(Console.ReadLine(), out a);
            //}
            //str = c.OddNumber(a);
            //Console.WriteLine(str);

            //int[] arr = { 3, 5, 1, 99, 22 };
            //int result = bk.GetMax(arr);
            //int result = bk.GetMax(3, 5, 1, 99, 22,995);
            //int result = bk.GetMax();
            //Console.WriteLine(result);

            //bk.GetName();
            //bk.GetName("jj");
            //int a,b;
            //bool f,f1;
            //Console.Write("请输入圆的半径：");
            //f = int.TryParse(Console.ReadLine(), out a);
            //while (!f)
            //{
            //    Console.Write("输入格式错误，请重新输入：");
            //    f = int.TryParse(Console.ReadLine(), out a);
            //}
            //bk.Area(a);

            //Console.Write("请输入矩形的长：");
            //f1= int.TryParse(Console.ReadLine(), out b);

            //while (!f1)
            //{
            //    Console.Write("输入的长格式错误，请重新输入：");
            //    f1 = int.TryParse(Console.ReadLine(), out b);
            //}

            //Console.Write("请输入矩形的宽：");

            //f = int.TryParse(Console.ReadLine(), out a);
            //while (!f)
            //{
            //    Console.Write("输入的宽格式错误，请重新输入：");
            //    f = int.TryParse(Console.ReadLine(), out b);
            //}

            //bk.Area(b,a);

            //Book.TestStatic();
            //bk.TestStatic1();

            // bk.TestSelf(5,1);
            //bk.TestSelf(3);
            //bk.TestSelf1(3);
            //bk.AddNum(100);
            //int t = 0;
            //Console.WriteLine(bk.Sum(ref t, 0));

            //int a =3;
            //Console.WriteLine(bk.Sum1(a));
            //Console.WriteLine(bk.Sum2(100));

            bk[0] = "Tom";
            bk[1] = "4";
            bk.ShowMe();

            Book bk1 = new Book("tom",60);
            bk.ShowMe();

            int x = 0;
            while (x<=5)
            {
                int a =int.Parse( Console.ReadLine());
                Console.WriteLine(bk.GetMax(a));
                x++;
             }
           
        }
    }
} 
