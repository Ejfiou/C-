using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 时间：2016年11月10日
/// 作业：08-1
/// 内容：1.动态设置二维整形数组的大小
///       2.给数组赋值
///       3.输出数组的每一个元素
///       4.倒着输出数组的每一个元素
///       5.输出数组中的最大值和最小值
///       6.计算数组中所有数值的总数和平均分
/// </summary>
namespace Homework_08_1_11_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.动态设置二维整形数组的大小
            Console.Write("请输入二位数组的行数：");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("请输入二位数组的列数：");
            int column = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[row, column];

            //2.给数组赋值
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("请输入第" + (i + 1) + "行的第" + (j + 1) + "个元素：");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //3.输出数组的每一个元素
            Console.WriteLine("\n该二维数组为：");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //4.倒着输出数组的每一个元素
            Console.WriteLine("\n倒着输出该二维数组为：");
            for (int i = arr.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = arr.GetLength(1) - 1; j >= 0; j--)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //5.输出数组中的最大值和最小值
            int min;
            int max = min = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (max < arr[i, j])
                    {
                        max = arr[i, j];
                    }
                    if (min > arr[i, j])
                    {
                        min = arr[i, j];
                    }
                }
            }
            Console.WriteLine("\n最大值是：" + max);
            Console.WriteLine("最小值是：" + min);

            //6.计算数组中所有数值的总数和平均分
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i, j];
                }
            }
            double avg = sum * 1.0 / arr.Length;
            Console.WriteLine("\n所有数值的总和是：" + sum);
            Console.WriteLine("所有数值的平均值是：" + avg);
        }
    }
}
