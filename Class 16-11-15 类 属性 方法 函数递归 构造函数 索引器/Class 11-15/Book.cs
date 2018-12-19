using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_15
{
    public class Book
    {


        public Book()//构造函数
        {

        }

        public Book(string t, int s)//构造函数，两个参数
        {
            title = t;
            size = s;
        }

        ~Book()//析构函数
        {

        }

        public string this[int index] //索引器
        {
            get
            {
                if (index == 0)
                {
                    return title;
                }
                else if (index == 1)
                {
                    return size.ToString();
                }
                else
                {
                    return "对不起!";
                }
            }
            set
            {
                if (index == 0)
                {
                    title=value;
                }
                else if (index == 1)
                {
                     size=Convert.ToInt32(value);
                }
                else
                {
                    
                }
            }
        }

        public string this[string type]
        {
            get
            {
                if (type == "Title")
                    return title;
                return "对不起！";
            }
            set
            {
                if (type == "Title")
                    title = value;
            }
        }

        ////特征
        ////书名
        private string title;  //字段
        public string Title    //属性
        {
            get { return title; }
            set { title = value; }
        }
        ////大小
        private int size;
        public int Size  //属性：保护，外衣
        {
            get { return size; }
            set
            {
                if (value > 0)
                {
                    size = value;
                }
            }
        }
        //颜色
        private string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        //行为

        //阅读
        public void Read() //方法
        {
            Console.WriteLine(title + "可以阅读");
        }

        //枕头
        public void Sleep()
        {
            Console.WriteLine(title + "可以当枕头睡觉");
        }

        //显示自己内容
        public void ShowMe()
        {
            Console.WriteLine("书名：" + title);
            Console.WriteLine("大小：" + size);
            Console.WriteLine("颜色：" + color);
        }

        //当size>10,显示该书好大
        //否则，显示该书好小
        public void Show()
        {
            if (size > 10)
            {
                Console.WriteLine(title + "该书好大");
            }
            else
            {
                Console.WriteLine(title + "该书好小");
            }

        }

        public void B(int qq)
        {
            if (size > qq)
            {
                Console.WriteLine(title + "该书好大");
            }
            else
            {
                Console.WriteLine(title + "该书好小");
            }
        }

        public void C(int min, int max)
        {
            if ((size > min) && (size < max))
            {
                Console.WriteLine(title + "这本书刚刚好啊！");
            }
            else
            {
                Console.WriteLine(title + "这本书不符合标准！");
            }
        }

        //public int TestReturn()
        //{
        //    return 6;
        //}

        public string Test1(int a, string str)
        {
            //string temp,j;

            //for (int i = 0; i < a; i++)
            //{
            //    temp = "hello" + str;
            //    j = temp;
            //}

            //return "sf";

            string abc = "";
            for (int i = 0; i < a; i++)
            {
                abc = abc + "可以阅读" + str + "\n";
                if (i == a - 1)
                {
                    abc = abc + "可以阅读" + str;
                }
            }
            return abc;

        }
        public void TestRef(ref int n)
        {
            n++;
            Console.WriteLine(n);
            //Console.WriteLine(n); //kljjj
            //n = "sjfdfj";
        }

        public int TestOut(out int o)
        {
            o = 6;
            return 8;
        }

        public void TestRef(ref int i, ref int b)
        {
            i++;
            b++;
        }

        public string TestOut(out string t, out string s, out string a)
        {
            t = "ttttt";
            s = "sssss";
            a = "aaaaa";
            return "return";
        }

        public void Te(int n)
        {
            n++;
            Console.WriteLine(n);
        }
        public void Ref(ref int n)
        {
            n--;
            Console.WriteLine(n);
        }

        public int Out(int a, out int o)
        {
            a = 7;
            o = a++;
            return (o + 1);

        }

        public string OddNumber(int odd)
        {
            if (odd % 2 == 0)
            {
                return "不是奇数";
            }
            else
            {
                return "是奇数";
            }
        }


        public int GetMax(params int[] a)
        {
            int max = -1;//定义默认值

            if (a.Length > 0)
            {
                max = a[0];
            }

            for (int i = 1; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            return max;
        }

        public void GetName()
        {
            Console.WriteLine("GetName");
        }

        public void GetName(string name)
        {
            Console.WriteLine("GetName" + name);
        }

        public void Area(double a)
        {
            const double pi = 3.14;
            Console.WriteLine("圆的面积为：" + (pi * a * a));
        }

        public void Area(int length, int wide)
        {
            Console.WriteLine("矩形的面积为：" + (length * wide));
        }

        public void TestStatic1()
        {
            Console.WriteLine("TestStatic1");
        }

        public static void TestStatic()
        {
            Console.WriteLine("TestStatic");
            Book a = new Book();
            a.TestStatic1();
            TestStatic2();
        }

        public static void TestStatic2()
        {
            Console.WriteLine("TestStatic2");
        }


        public void TestSelf(int a, int i)
        {
            Console.WriteLine("Hello" + i);
            if (i < a)
            {
                i++;
                TestSelf(a, i);
            }
        }

        public void TestSelf(int a)
        {
            if (a > 1)
            {
                a--;
                TestSelf(a);
            }
            Console.WriteLine("Hello" + a);
        }

        public void TestSelf1(int a)
        {
            if (a > 1)
            {
                a--;
                TestSelf1(a);
            }
            else
            {
                a--;
            }
            Console.WriteLine("Hello" + (a + 1));
        }

        int sun = 0;
        int i = 1;
        //public int AddNum(int n)
        //{
        //    if (i <= n)
        //    {
        //        sun = sun + n;
        //        n--;
        //        AddNum(n);
        //    }
        //    return sun;
        //}



        public void AddNum(int n)
        {
            if (i <= n)
            {
                sun = sun + n;
                n--;
                AddNum(n);
            }
            Console.WriteLine(sun);
        }

        public int Sum(ref int sum, int a)
        {
            if (a < 5)
            {
                a++;              //1 2 3 4   5
                sum = sum + a;    //1 3 6 10  15
                Sum(ref sum, a);
            }
            return (sum);//
        }

        public int Sum1(int a)
        {

            //0    1  2   3    4
            if (a > 0)//10  11  11  10   8
            {
                a--;     //4
                a = a + Sum1(a);// 
                Console.WriteLine(a);//2  4  7  11
            }
            return a;
        }

        public int Sum2(int i)
        {
            if (i > 0)
            {
                return i + Sum2(i - 1);
            }
            return 0;
        }


    }
}
