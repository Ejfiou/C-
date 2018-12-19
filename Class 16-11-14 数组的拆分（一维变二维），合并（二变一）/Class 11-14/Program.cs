using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 时间：2016年11月14日09:27:39
/// 内容：数组的拆分（一维变二维），合并（二变一）
/// </summary>
namespace Class_11_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //数组的拆分
            //int[] arr = { 3, 55, 1, 99, 5, 2 };

            //二维数组的行数：1
            //int[,] temp = new int [1,6];
            //temp[0, 0] = arr[0];

            //for (int j = 0; j < temp.GetLength(1); j++)
            //{
            //    temp[0, j] = arr[j];
            //}

            //二维数组的行数：2
            //int[,] temp = new int[2, 3];
            //temp[0, 0] = arr[0];

            //for (int i = 0; i < temp.GetLength(0); i++)
            //{
            //    for (int j = 0; j < temp.GetLength(1); j++)
            //    {
            //         temp[i, j] = arr[i * temp.GetLength(1) + j]; ////0=0*3+0  1=0*3+0
            //    }
            //}

            //二维数组的行数：3
            //int[,] temp = new int[3, 2];

            //for (int i = 0; i < temp.GetLength(0); i++)
            //{
            //    for (int j = 0; j < temp.GetLength(1); j++)
            //    {
            //        temp[i, j] = arr[i * temp.GetLength(1) + j];
            //    }
            //}

            //二维数组的行数：4
            //int[,] temp = new int[4,2];           

            //for (int i = 0; i < temp.GetLength(0); i++)
            //{
            //    for (int j = 0; j < temp.GetLength(1); j++)
            //    {
            //        if (i * temp.GetLength(1) + j < arr.Length)
            //        {
            //            temp[i, j] = arr[i * temp.GetLength(1) + j];
            //        }
            //    }
            //}

            //二维数组的行数：5
            //int[,] temp = new int[5, 2];

            //for (int i = 0; i < temp.GetLength(0); i++)
            //{
            //    for (int j = 0; j < temp.GetLength(1); j++)
            //    {
            //        if (i * temp.GetLength(1) + j < arr.Length)
            //        {
            //            temp[i, j] = arr[i * temp.GetLength(1) + j];
            //        }
            //    }
            //}

            //二维数组的行数：6
            //int[,] temp = new int[6, 1];

            //for (int i = 0; i < temp.GetLength(0); i++)
            //{
            //    for (int j = 0; j < temp.GetLength(1); j++)
            //    {
            //        if (i * temp.GetLength(1) + j < arr.Length)
            //        {
            //            temp[i, j] = arr[i * temp.GetLength(1) + j];
            //        }
            //    }
            //}

            //二维数组的行数：x
            //int x = Convert.ToInt32(Console.ReadLine());
            //int yLength = arr.Length % x == 0 ? arr.Length / x : arr.Length / x + 1;
            //int[,] temp = new int[x, yLength];

            //for (int i = 0; i < temp.GetLength(0); i++)
            //{
            //    for (int j = 0; j < temp.GetLength(1); j++)
            //    {
            //        if (i * temp.GetLength(1) + j < arr.Length)
            //        {
            //            temp[i, j] = arr[i * temp.GetLength(1) + j];
            //        }
            //    }
            //}

            ////查看数组中的内容
            //for (int i = 0; i < temp.GetLength(0); i++)
            //{
            //    for (int j = 0; j < temp.GetLength(1); j++)
            //    {
            //        Console.Write(temp[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}



            //合并
            //int[,] temp = { { 4, 5 }, { 6, 7 }, { 8, 9 } };
            //int[] arr = new int[temp.Length];

            //for (int i = 0; i < temp.GetLength(0); i++)
            //{
            //    for (int j = 0; j < temp.GetLength(1); j++)
            //    {
            //        arr[i * temp.GetLength(1) + j] = temp[i, j];
            //    }
            //}
            //for (int i = 0; i < temp.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}


            
            //string[] strs = { "tom", "jerry", "jack", "rose" };
            //while (true)
            //{
            //    for (int index = 0; index < strs.Length; index++)
            //    {
            //            Console.WriteLine(strs[index]);
            //    }
            //}

        }
    }
}
