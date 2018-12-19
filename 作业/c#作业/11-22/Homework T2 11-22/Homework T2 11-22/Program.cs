using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 时间：2016年11月22日
/// 内容：猜拳系统
/// </summary>
namespace Homework_T2_11_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("猜拳系统");
            Console.WriteLine("=================================================");            
            Console.WriteLine("1.石头");
            Console.WriteLine("2.剪刀");
            Console.WriteLine("3.布");
            Console.WriteLine("输入相应的序号来选择操作");
            Console.WriteLine("=================================================");

            int a, b;
            bool f;

            Console.Write("请甲方输入姓名：");
            string j = Console.ReadLine();
            Console.Write("请乙方输入姓名：");
            string y = Console.ReadLine();

            Console.WriteLine("现在进行双方的猜拳游戏");
            //甲方
            Console.Write("请{0}出拳：",j);
            f = int.TryParse(Console.ReadLine(), out a); 
            while (!f || a < 1 || a > 3)
            {
                Console.Write("输入格式错误，请重新输入：");
                f = int.TryParse(Console.ReadLine(), out a);
            }

            //乙方
            Console.Write("请{0}出拳：",y);
            f = int.TryParse(Console.ReadLine(), out b);
            while (!f || a < 1 || a > 3)
            {
                Console.Write("输入格式错误，请重新输入：");
                f = int.TryParse(Console.ReadLine(), out b);
            }
            
            Game g = new Game();
            int s = g.Judge(a, b);
            switch (s)
            {
                case 0:
                    {
                        Console.WriteLine("平局！");
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("{0}赢了！", y);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("{0}赢了！", j);
                        break;
                    }
            }
        }
    }
}
