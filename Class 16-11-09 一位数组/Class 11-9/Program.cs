using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 时间：2016年11月9日11:01:55
///      课堂上做
/// </summary>
namespace Class_11_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 0;
            //int i = Convert.ToInt32(Console.ReadLine());
            //for (int j = 2; j < i; j++)
            //{
            //    if (i % j == 0)
            //    {
            //        a++;
            //    }
            //}
            //if (a == 0)
            //    Console.WriteLine("yes");
            //else
            //    Console.WriteLine("no");


            //int sum = 0;


            //for (int i = 2; i <= 100; i++)
            //{
            //    bool flag = true;
            //    for (int j = 2; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            flag = false;
            //        }
            //    }
            //    if (flag)
            //    {
            //        sum = sum + i;
            //    }

            //}
            //Console.WriteLine(sum);


            //for (int a = 1; a <= 5; a++)
            //{
            //    for (int k = 1; k <= 5 - a; k++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= a; j++)
            //    {
            //        Console.Write("★");
            //    }
            //    Console.WriteLine();
            //}

            //string str = Console.ReadLine();
            //foreach (char t in str)
            //{

            //    if (t % 3 != 0)
            //        Console.Write("{0}", t);

            //}

            //int sum = 0;
            //int i;
            //for (int a = 2; a <= 100; a++)
            //{
            //    bool flag = false;
            //    for (i = 2; i < a; i++)
            //    {
            //        if (a % i == 0)
            //            flag = true;
            //    }
            //    if (flag)
            //        sum = sum + i;
            //}
            //Console.WriteLine(sum + 1);

            //char t = 'a'

            //int[] i = new int[] { 1, 2, 3, 4, 5, 6 };
            //for (int index = 0; index < i.Length; index++)
            //{


            //    Console.WriteLine(i[index]);
            //}


            //得到最小值及下标
            //Console.Write("请输入数组长度：");
            //int myLengh = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[myLengh];

            //for (int index = 0; index < myLengh; index++)
            //{
            //    Console.Write("请输入第{0}个元素：", index + 1);
            //    arr[index] = Convert.ToInt32(Console.ReadLine());
            //}

            //int min = arr[0], minIndex = 0;
            //for (int index = 0; index < arr.Length; index++)
            //{
            //    if (arr[index] < min)
            //    {
            //        minIndex = index;
            //        min = arr[index];
            //    }
            //}
            //Console.WriteLine("最小值是第{0}个，数值是{1}", minIndex + 1, min);



            //输入数组
            Console.Write("请输入数组长度：");
            int myLengh = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[myLengh];

            for (int index = 0; index < myLengh; index++)
            {
                Console.Write("请输入第{0}个元素：", index + 1);
                a[index] = Convert.ToInt32(Console.ReadLine());
            }
            //比较

            //int  j;
            //for (int index = 1; index < a.Length; index++)
            //    if (a[index] < a[index - 1])
            //    {
            //        int temp = a[index];
            //        for (j = index - 1; j >= 0 && a[j] > temp; j--)
            //            a[j + 1] = a[j];
            //        a[j + 1] = temp;
            //    }
            int  j, k;
            for (int index = 1; index < a.Length; index++)
            {
                //为a[i]在前面的a[0...i-1]有序区间中找一个合适的位置  
                for (j = index - 1; j >= 0; j--)
                    if (a[j] < a[index])
                        break;

                //如找到了一个合适的位置  
                if (j != index - 1)
                {
                    //将比a[i]大的数据向后移  
                    int temp = a[index];
                    for (k = index - 1; k > j; k--)
                        a[k + 1] = a[k];
                    //将a[i]放到正确位置上  
                    a[k + 1] = temp;
                }
            }

            for (int index = 0; index < a.Length; index++)
            {
                Console.WriteLine(a[index]);
            }
        }


    }
}
