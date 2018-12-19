using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 时间：2016年11月14日
/// 作业：09-2
/// 内容：1.动态设置二维整形数组的大小
///       2.给数组赋值
///       3.输出数组的每一个元素
///       4.合并为一维数组
///       5.输出一维数组的每一个元素
/// </summary>
namespace Homework_T2_11_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.动态设置二维整形数组的大小
            Console.Write("请输入二维数组的行数：");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("请输入二维数组的列数：");
            int list = Convert.ToInt32(Console.ReadLine());
            int[,] doubArr = new int[row, list];

            //2.给数组赋值
            for (int i = 0; i < doubArr.GetLength(0); i++)
            {
                for (int j = 0; j < doubArr.GetLength(1); j++)
                {
                    Console.Write("请输入第"+(i+1)+"行的第"+(j+1)+"个元素：");
                    doubArr[i, j] = Convert.ToInt32( Console.ReadLine());
                }
            }

            //3.输出数组的每一个元素
            Console.WriteLine("该二维数组为：");
            for (int i = 0; i < doubArr.GetLength(0); i++)
            {
                for (int j = 0; j < doubArr.GetLength(1); j++)
                {
                    Console.Write(doubArr[i,j]+"\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            //4.合并为一维数组
            int[] arr = new int[doubArr.Length];

            for (int i = 0; i < doubArr.GetLength(0); i++)
            {
                for (int j = 0; j < doubArr.GetLength(1); j++)
                {
                    arr[i * doubArr.GetLength(1) + j] = doubArr[i, j];
                }
            }
            Console.WriteLine("合并为一维数组后为：");
            //5.输出一维数组的每一个元素
            for (int i = 0; i < doubArr.Length; i++)
            {
                Console.Write(arr[i]+"\t");
            }
            Console.WriteLine();
        }
    }
}
