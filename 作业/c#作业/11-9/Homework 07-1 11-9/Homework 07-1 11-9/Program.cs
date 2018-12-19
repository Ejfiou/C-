using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 时间：2016年11月9日
/// 作业：07-1
/// 内容：1.动态设置一维整形数组的大小
///       2.给数组赋值
///       3.输出数组的每一个元素
///       4.排序(升序)
///       5.输出排序后数组的每一个元素
///       6.倒着输出排序后数组的每一个元素
///       7.输出数组中的最大值和最小值
///       8.计算数组中所有数值的总和和平均分
/// </summary>
namespace Homework_07_1_11_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int index;
            //1.动态设置一维整形数组的大小
            Console.Write("请输入数组长度：");
            int myLengh = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[myLengh];

            //2.给数组赋值
            for (index = 0; index < arr.Length; index++)
            {
                Console.Write("请输入第{0}个元素：", index + 1);
                arr[index] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();

            //3.输出数组的每一个元素
            for (index = 0; index < arr.Length; index++)
            {
                Console.WriteLine("数组中的第{0}个元素是：{1}",index+1,arr[index]);
            }

            //4.排序(升序)
            for (index = 1; index < arr.Length; index++)
            {
                if (arr[index] < arr[index - 1])
                {
                    int j;
                    int temp = arr[index];
                    for (j = index - 1; j >= 0 && arr[j] > temp; j--)
                        arr[j + 1] = arr[j];
                    arr[j + 1] = temp;
                }
            }

            Console.WriteLine();

            //5.输出排序后数组的每一个元素     
            Console.Write("排序后的数组为：");
            for (index = 0; index < arr.Length; index++)
            {
                Console.Write(arr[index]+"  ");
            }

            Console.WriteLine("\n");

            //6.倒着输出排序后数组的每一个元素
            Console.Write("倒着输出排序后的数组为：");
            for (index = arr.Length-1; index >= 0; index--)
            {
                Console.Write(arr[index] + "  ");
            }

            Console.WriteLine("\n");

            //7.输出数组中的最大值和最小值
            Console.WriteLine("数组中的最大值是："+arr[arr.Length-1]);
            Console.WriteLine("数组中的最小值是："+arr[0]);

            Console.WriteLine();

            //8.计算数组中所有数值的总和和平均分
            int sum = 0;
            for (index = 0; index < arr.Length; index++)
            {
                sum += arr[index];
            }
            Console.WriteLine("数组中所有数值的总和为："+sum,(sum*1.0/arr.Length));
            Console.WriteLine("数组中所有数值平均值为：" + (sum * 1.0 / arr.Length));
        }
    }
}
