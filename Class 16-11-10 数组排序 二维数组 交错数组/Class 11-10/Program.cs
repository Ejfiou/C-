using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 时间：2016年11月10日
///     数组排序
/// </summary>
namespace Class_11_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //int index;
            ////1.动态设置一维整形数组的大小
            //Console.Write("请输入数组长度：");
            //int myLengh = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[myLengh];

            ////2.给数组赋值
            //for (index = 0; index < arr.Length; index++)
            //{
            //    Console.Write("请输入第{0}个元素：", index + 1);
            //    arr[index] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine();

            ////3.输出数组的每一个元素
            //for (index = 0; index < arr.Length; index++)
            //{
            //    Console.WriteLine("数组中的第{0}个元素是：{1}", index + 1, arr[index]);
            //}

            ////排序
            ////算法一
            ////for (index = 1; index < arr.Length; index++)
            ////{
            ////    if (arr[index] < arr[index - 1])
            ////    {
            ////        int j;
            ////        int temp = arr[index];
            ////        for (j = index - 1; j >= 0 && arr[j] > temp; j--)
            ////            arr[j + 1] = arr[j];
            ////        arr[j + 1] = temp;
            ////    }
            ////}

            ////算法二
            ////for (index = arr.Length - 1; index >= 0; index--)
            ////{
            ////    for (int b = 0; b < index; b++)
            ////    {
            ////        if (arr[b] > arr[b + 1])
            ////        {
            ////            int temp;
            ////            temp = arr[b + 1];
            ////            arr[b + 1] = arr[b];
            ////            arr[b] = temp;
            ////        }
            ////    }
            ////}

            ////算法三
            ////int[] brr = new int[arr.Length];
            ////for (int a = arr.Length - 1; a >= 0; a--)
            ////{
            ////    int max = arr[0];
            ////    int n = 0;
            ////    for (int b = 1; b < arr.Length; b++)
            ////    {
            ////        if(arr[b]>max)
            ////        {
            ////            max = arr[b];
            ////            n = b;
            ////        }
            ////    }
            ////    arr[n] = 0;//离开原来队伍
            ////    brr[a] = max;//进去新队伍
            ////}
            ////arr = brr;

            ////算法四
            ////for (index = arr.Length - 1; index >= 0; index--)
            ////{
            ////    for (int b = 0; b < index; b++)
            ////    {
            ////        if (arr[index] < arr[b])
            ////        {
            ////            int temp = arr[index];
            ////            arr[index] = arr[b];
            ////            arr[b] = temp;
            ////        }
            ////    }
            ////}


            //Console.WriteLine();

            ////5.输出排序后数组的每一个元素     
            //Console.Write("排序后的数组为：");
            //for (index = 0; index < arr.Length; index++)
            //{
            //    Console.Write(arr[index] + "  ");
            //}

            //Console.WriteLine();




            //二维数组
            //方式一
            //int[,] arr = { { 4,5},{6,7 },{8,9 } };
            //Console.WriteLine(arr[0, ]);

            //方式二
            //int[,] arr = new int[3, 2];
            //arr[0, 0] = 2;
            //arr[0, 1] = 3;
            //arr[1, 0] = 5;
            //arr[1, 1] = 6;
            //arr[2, 0] = 8;
            //arr[2, 1] = 9;
            //for (int i=0;i<arr.GetLength(0);i++)
            //{
            //    for(int j=0;j<arr.GetLength(1); j++)
            //    {
            //        Console.Write(arr[i, j]+"\t");
            //    }
            //    Console.WriteLine();
            //}

            //方式三
            //int[,] arr = new int[3, 2] { { 4, 5 }, { 6, 7 }, { 8, 9 } };

            //    Console.Write("请输入二位数组的行数：");
            //    int row = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("请输入二位数组的列数：");
            //    int column = Convert.ToInt32(Console.ReadLine());

            //    int[,] arr = new int[row,column];
            //  //动态输入
            //    //输入二维数组的元素
            //    for (int i = 0; i < arr.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < arr.GetLength(1); j++)
            //        {
            //            Console.Write("请输入第"+(i+1)+"行第"+(j+1)+"个元素：");
            //            arr[i, j] = Convert.ToInt32(Console.ReadLine());
            //        }
            //    }

            //    //输出二维数组中的元素
            //    for (int i = 0; i < arr.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < arr.GetLength(1); j++)
            //        {
            //            Console.Write(arr[i, j] + "\t");
            //        }
            //        Console.WriteLine();
            //    }

            //    //求最大值及其下标
            //    int maxRowIndex = 0;
            //    int maxColumnIndex = 0;
            //    int max = arr[0, 0];

            //    for (int i = 0; i < arr.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < arr.GetLength(1); j++)
            //        {
            //        
            //            if (arr[i,j]>max)
            //            {
            //                maxRowIndex = i;
            //                maxColumnIndex = j;
            //                max = arr[i, j];
            //            }
            //        }
            //        Console.WriteLine();
            //    }

            //    Console.WriteLine("最大的数的位置是第"+(maxRowIndex+1)+"行第"+(maxColumnIndex+1)+"列");
            //    Console.WriteLine("最大值是"+max);


            //交错数组
            //方式一
            //int[][] arr = { new int[2], new int[3], new int[4] };
            //int[][] arr = { new int[]{ 2,3}, new int[] { 4,5,6}, new int[] { 7,8,9,0} };
            //Console.WriteLine(arr[1][1]);
            //方式二
            //int[][] arr = new int[3][];
            //arr[0] = new int[2];
            //arr[1] = new int[3];
            //arr[2] = new int[4];
            //arr[0][0] = 1;
            //arr[0][1] = 2;
            //arr[1][0] = 3;
            //arr[1][1] = 4;
            //arr[1][2] = 5;
            //arr[2][0] = 6;
            //arr[2][1] = 7;
            //arr[2][2] = 8;
            //arr[2][3] = 9;
            //for (int i = 0; i < arr.Length; i++) //行
            //{
            //    for (int j = 0; j < arr[i].Length; j++)//每一列的数字的个数
            //    {
            //        Console.Write(arr[i][j] + "\t");
            //    }
            //    Console.WriteLine();
            //}


            //动态输入
            //Console.Write("请输入交错数组的行数：");
            //int row = Convert.ToInt32(Console.ReadLine());
            //int[][] arr = new int[row][];
            //for (int i=0;i<row;i++)
            //{
            //    Console.Write("请输入交错数组的第"+(i+1)+"行的列数：");
            //    int column = Convert.ToInt32(Console.ReadLine());
            //    arr[i] = new int[column];
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        Console.Write("请输入第" + (i + 1) + "行第" + (j + 1) + "列的数值：");
            //        arr[i][j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            ////动态输出
            //for (int i = 0; i < arr.Length; i++) //行
            //{
            //    for (int j = 0; j < arr[i].Length; j++)//每一列的数字的个数
            //    {
            //        Console.Write(arr[i][j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            int[] arr = { 8, 3, 12, 66, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if(arr[j]>arr[j+1])
                    {
                        int temp;
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j+1] = temp;
                    }
                }
            }

            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }

        }


    }
    
}
