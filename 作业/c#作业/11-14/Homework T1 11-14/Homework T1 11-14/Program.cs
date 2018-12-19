using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 时间：2016年11月14日
/// 作业：09-1
/// 内容：1.动态设置一维整形数组的大小
///       2.给数组赋值
///       3.输出数组的每一个元素
///       4.动态设置二维整形数组的行数,拆分为二维数组
///       5.输出二维整形数组的每一个元素
/// </summary>
namespace Homework_T1_11_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.动态设置一维整形数组的大小
            Console.Write("请输入数组长度：");
            int myLength = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[myLength];

            //2.给数组赋值
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("请输入第{0}个元素：", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();

            //3.输出数组的每一个元素
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("数组中的第{0}个元素是：{1}", i + 1, arr[i]);
            }

            Console.WriteLine();
            //4.动态设置二维整形数组的行数,拆分为二维数组
            Console.Write("请输入要拆分成的二维数组的行数：");
            int row = Convert.ToInt32(Console.ReadLine());
            int list = arr.Length % row == 0 ? arr.Length / row : arr.Length / row + 1;
            int[,] doubleArr = new int[row, list];

            for (int i = 0; i < doubleArr.GetLength(0); i++)
            {
                for (int j = 0; j < doubleArr.GetLength(1); j++)
                {
                    if (i * doubleArr.GetLength(1) + j < arr.Length)
                    {
                        doubleArr[i, j] = arr[i * doubleArr.GetLength(1) + j];
                    }
                }
            }

            //5.输出二维整形数组的每一个元素
            Console.WriteLine("拆分成的二维数组为：");
            for (int i = 0; i < doubleArr.GetLength(0); i++)
            {
                for (int j = 0; j < doubleArr.GetLength(1); j++)
                {
                    Console.Write(doubleArr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
