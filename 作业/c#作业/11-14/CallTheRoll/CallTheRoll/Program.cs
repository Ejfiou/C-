using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 时间：2016年11月14日
/// 内容：点名系统
/// 功能：1.全班点名
///       2.除去班长进行点名
///       3.除去组长和班长进行点名
///       4.某个组中进行点名
///       5.某个组中除去组长进行点名      
/// </summary>
namespace CallTheRoll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("点名系统 v1.0");
            Console.WriteLine("作者：唐兴国");
            Console.WriteLine("联系方式：15050416073");
            Console.WriteLine("实现功能如下");
            Console.WriteLine("1.全班点名");
            Console.WriteLine("2.除去班长进行点名");
            Console.WriteLine("3.除去组长和班长进行点名");
            Console.WriteLine("4.某个组中进行点名");
            Console.WriteLine("5.某个组中除去组长进行点名");
            Console.WriteLine();
            Console.WriteLine("开始使用本系统");
            Console.Write("请输入要执行的操作(序号)：");

            string[][] strs = new string[7][];
            strs[0] = new string[] { "蒋书文", "刘秀武", "周亮", "朱文校", "叶贻峰", "刘树家" }; //GTG组  组长均在最后一个
            strs[1] = new string[] { "童旭", "秦思远", "蒋天佑", "邹南阳", "王雅林", "陈秀" };  //DDU组
            strs[2] = new string[] { "陈媛", "李孔强", "冯杰", "彭洋", "向瑞格", "李荣" };      //荣组
            strs[3] = new string[] { "陈铭", "唐兴国", "朱梓昇", "邓宣东", "高甜", "尹泽方" };  //WE
            strs[4] = new string[] { "李泽昇", "王乾康", "王求圣", "李林", "邓志清", "屠建伟" };//楚天组
            strs[5] = new string[] { "王成业", "袁广", "方敏", "李飞鸿", "周明球", "左思仪" };  //SKY组
            strs[6] = new string[] { "黄哲林" };

            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            //全班点名
            if (num == 1)
            {
                Console.WriteLine("您选择了全班点名");
                while (true)
                {
                    for (int i = 0; i < strs.Length; i++)
                    {
                        for (int j = 0; j < strs[i].Length; j++)
                        {
                            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b结果为：" + strs[i][j] + "\t");
                        }
                    }
                }
            }

            //除去班长进行点名
            if (num == 2)
            {
                Console.WriteLine("您选择了除去班长进行点名");
                while (true)
                {
                    for (int i = 0; i < strs.Length - 1; i++)     //班长在最后一个数组
                    {
                        for (int j = 0; j < strs[i].Length; j++)
                        {
                            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b结果为：" + strs[i][j] + "\t");
                        }
                    }
                }
            }

            //除去组长和班长进行点名
            if (num == 3)
            {
                Console.WriteLine("您选择了除去组长和班长进行点名");
                while (true)
                {
                    for (int i = 0; i < strs.Length - 1; i++)     //班长在最后一个数组
                    {
                        for (int j = 0; j < strs[i].Length - 1; j++)  //组长在最后一个元素
                        {
                            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b结果为：" + strs[i][j] + "\t");
                        }
                    }
                }
            }


            //某个组中进行点名
            if (num == 4)
            {
                Console.Write("您选择了某个组中进行点名");
                Console.WriteLine("（1、GTG组 2、DDU组 3、荣组 4、WE组 5、楚天组 6、SKY组）");
                Console.Write("请输入组（序号）：");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        {
                            Console.WriteLine("您选择了GTG组");
                            while (true)
                            {
                                for (int j = 0; j < strs[0].Length; j++)
                                {
                                    Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b结果为：" + strs[0][j] + "\t");
                                }
                            }
                        }
                    case 2:
                        {
                            Console.WriteLine("您选择了DDU组");
                            while (true)
                            {
                                for (int j = 0; j < strs[1].Length; j++)
                                {
                                    Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b结果为：" + strs[1][j] + "\t");
                                }
                            }
                        }
                    case 3:
                        {
                            Console.WriteLine("您选择了荣组");
                            while (true)
                            {
                                for (int j = 0; j < strs[2].Length; j++)
                                {
                                    Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b结果为：" + strs[2][j] + "\t");
                                }
                            }
                        }
                    case 4:
                        {
                            Console.WriteLine("您选择了WE组");
                            while (true)
                            {
                                for (int j = 0; j < strs[3].Length; j++)
                                {
                                    Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b结果为：" + strs[3][j] + "\t");
                                }
                            }
                        }
                    case 5:
                        {
                            Console.WriteLine("您选择了WE组");
                            while (true)
                            {
                                for (int j = 0; j < strs[4].Length; j++)
                                {
                                    Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b结果为：" + strs[4][j] + "\t");
                                }
                            }
                        }
                    case 6:
                        {
                            Console.WriteLine("您选择了SKY组");
                            while (true)
                            {
                                for (int j = 0; j < strs[5].Length; j++)
                                {
                                    Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b结果为：" + strs[5][j] + "\t");
                                }
                            }
                        }
                }

            }
                //某个组中除去组长进行点名
                if (num == 5)
                {
                    Console.Write("您选择了某个组中除去组长进行点名");
                    Console.WriteLine("（1、GTG组 2、DDU组 3、荣组 4、WE组 5、楚天组 6、SKY组）");
                    Console.Write("请输入组（序号）：");
                    int s = Convert.ToInt32(Console.ReadLine());
                    switch (s)
                    {
                        case 1:
                            {
                                Console.WriteLine("您选择了GTG组");
                                while (true)
                                {
                                    for (int j = 0; j < strs[0].Length - 1; j++)  //组长为最后一个元素
                                    {
                                        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b结果为：" + strs[0][j] + "\t");
                                    }
                                }
                            }
                        case 2:
                            {
                                Console.WriteLine("您选择了DDU组");
                                while (true)
                                {
                                    for (int j = 0; j < strs[1].Length - 1; j++)
                                    {
                                        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b结果为：" + strs[1][j] + "\t");
                                    }
                                }
                            }
                        case 3:
                            {
                                Console.WriteLine("您选择了荣组");
                                while (true)
                                {
                                    for (int j = 0; j < strs[2].Length - 1; j++)
                                    {
                                        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b结果为：" + strs[2][j] + "\t");
                                    }
                                }
                            }
                        case 4:
                            {
                                Console.WriteLine("您选择了WE组");
                                while (true)
                                {
                                    for (int j = 0; j < strs[3].Length - 1; j++)
                                    {
                                        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b结果为：" + strs[3][j] + "\t");
                                    }
                                }
                            }
                        case 5:
                            {
                                Console.WriteLine("您选择了WE组");
                                while (true)
                                {
                                    for (int j = 0; j < strs[4].Length - 1; j++)
                                    {
                                        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b结果为：" + strs[4][j] + "\t");
                                    }
                                }
                            }
                        case 6:
                            {
                                Console.WriteLine("您选择了SKY组");
                                while (true)
                                {
                                    for (int j = 0; j < strs[5].Length - 1; j++)
                                    {
                                        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b结果为：" + strs[5][j] + "\t");
                                    }
                                }
                            }
                    }
                }
            
        }
    }
}