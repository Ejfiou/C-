using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 时间： 2016年11月8日15:58:33
///    上课练习 打印星星
/// </summary>
namespace Class_11_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int row = 1; row <= 5; row++)//
            //{
            //    for (int starNum = 1; starNum <= row; starNum++)//
            //    {                    
            //            Console.Write("★");
            //    }
            //    Console.WriteLine();
            //}
            /*
            ★
            ★★
            ★★★
            ★★★★
            ★★★★★             
             */

            //for (int row = 5; row >= 1; row--)//
            //{
            //    for (int starNum = 1; starNum <= row; starNum++)//
            //    {
            //        Console.Write("★");
            //    }
            //    Console.WriteLine();
            //}
            /*
              ★★★★★
              ★★★★
              ★★★
              ★★ 
              ★
            */


            //for (int row = 1; row <= 5; row++)
            //{
            //    for (int spaceNum = 1; spaceNum <= (5 - row); spaceNum++)
            //    {
            //        Console.Write("  ");
            //    }
            //    for (int starNum = 1; starNum <= row; starNum++)
            //    {
            //        Console.Write("★");
            //    }
            //    Console.WriteLine();
            //}
            /*       
                      ★
                    ★★
                  ★★★
                ★★★★
              ★★★★★
           */

            //for (int row = 1; row <= 5; row++)
            //{
            //    for (int starNum = 1; starNum <= 5; starNum++)                     

            //    if(row <= starNum)
            //    {
            //        Console.Write("★");
            //    }
            //    else
            //    {
            //        Console.Write("  ");
            //    }
            //    Console.WriteLine();
            //}
            /*
              ★★★★★
                ★★★★
                  ★★★
                    ★★
                      ★
          */
            for (int row = 1; row <= 10; row++)
            {
                for (int spaceNum = 1; spaceNum <= (10 - row); spaceNum++)
                {
                    Console.Write("  ");
                }
                for (int starNum = 1; starNum <= 2 * row - 1; starNum++)
                {
                    Console.Write("★");
                }
                Console.WriteLine();
            }

            
            Process.Start(@"D:\BaiduNetdiskDownload\Net视频\19.HTML+CSS_2（第十九天）\video\4、背景和位置.avi");

            Console.ReadKey();
            /*
                     ★
                   ★★★
                 ★★★★★
               ★★★★★★★
             ★★★★★★★★★
           */
            //for (int row = 5; row >=1; row--)
            //{
            //    for (int spaceNum = 1; spaceNum <= (5 - row); spaceNum++)
            //    {
            //        Console.Write("  ");
            //    }
            //    for (int starNum = 1; starNum <= 2 * row - 1; starNum++)
            //    {
            //        Console.Write("★");
            //    }
            //    Console.WriteLine();
            //}
            /*
             
             ★★★★★★★★★
               ★★★★★★★
                 ★★★★★
                   ★★★
                     ★
             */

            //for (int row = 1; row <= 5; row++)
            //{
            //    for (int spaceNum = 1; spaceNum <= (5 - row); spaceNum++)
            //    {
            //        Console.Write("  ");
            //    }
            //    for (int starNum = 1; starNum <= 2 * row-1; starNum++)
            //    {
            //        Console.Write("★");
            //    }
            //    Console.WriteLine();
            //}
            //for (int row = 4; row >= 1; row--)
            //{
            //    for (int spaceNum = 1; spaceNum <= (5 - row); spaceNum++)
            //    {
            //        Console.Write("  ");
            //    }
            //    for (int starNum = 1; starNum <= 2 * row - 1; starNum++)
            //    {
            //        Console.Write("★");
            //    }
            //    Console.WriteLine();
            //}
        /*
                  ★
                ★★★
              ★★★★★
            ★★★★★★★  
          ★★★★★★★★★
            ★★★★★★★
              ★★★★★
                ★★★
                  ★ 


          */


    }
    }
}



