using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 时间：2016年11月9日
/// 作业：07-2
/// 内容：1.动态设置一维字符串数组的大小
///       2.给数组赋值
///       3.输出数组的每一个元素
///       4.输出数组中的长度最长的字符串
///       5.将数组进行对称调换
///       6.输出对称调换后数组的每一个元素
/// </summary>
namespace Homework_07_2_11_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int index;

            //1.动态设置一维字符串数组的大小
            Console.Write("请输入数组的长度：");
            int myLengh = Convert.ToInt32(Console.ReadLine());
            string [] arr = new string[myLengh];

            //2.给数组赋值
            for (index = 0; index < myLengh; index++)
            {
                Console.Write("请输入第{0}个元素：", index + 1);
                arr[index] = Console.ReadLine();
            }

            Console.WriteLine();

            //3.输出数组的每一个元素
            for (index = 0; index < arr.Length; index++)
            {
                Console.WriteLine("数组中的第{0}个元素是：{1}", index + 1, arr[index]);
            }

            Console.WriteLine();

            //4.输出数组中的长度最长的字符串
            int len = 0;
            for (int lenIndex = 0; lenIndex < arr.Length; lenIndex++)
            {
                if (arr[lenIndex].Length > len)
                {
                    len = arr[lenIndex].Length;
                    index = lenIndex;
                }              
            }
            Console.WriteLine("数组中长度最长的字符串为："+arr[index]);

            Console.WriteLine();

            // 5.将数组进行对称调换
            string temp;
            for (index = 1; index <= arr.Length/2; index++)
            {
                temp = arr[index-1];
                arr[index - 1] = arr[arr.Length-index];
                arr[arr.Length - index] = temp;
            }

            //6.输出对称调换后数组的每一个元素
            for (index = 0; index < arr.Length; index++)
            {
                Console.WriteLine("数组对调后的的第{0}个元素是：{1}", index + 1, arr[index]);
            }
        }
    }
}
