using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Homework_11_23
{
    class Game
    {
        public Game()
        {

        }

        private Player[] pers;

        public void PrintTitle()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("猜拳游戏v1.0");
            Console.WriteLine("作者：唐兴国");
            Console.WriteLine("联系方式：xxxxx");
            Console.WriteLine("输入对应序号以完成选择");
            Console.WriteLine("  1.剪刀\n  2.石头\n  3.布");
            Console.WriteLine("==================================");
        }
        public void SetPlayerNum()
        {
            int playNum;
            Console.Write("请输入参与游戏的人数：");
            bool f = int.TryParse(Console.ReadLine(), out playNum);
            while (!f || playNum < 2)
            {
                Console.Write("您的输入有误，请重新输入：");
                f = int.TryParse(Console.ReadLine(), out playNum);
            }
            pers = new Player[playNum];
        }

        public void SetPlayer()
        {
            for (int i = 0; i < pers.Length; i++)
            {
                Console.Write($"\n请输入玩家{(i + 1)}的姓名：");
                string str = Console.ReadLine();
                Console.Write($"请输入玩家{(i + 1)}是否为机器(y/n)：");
                string isPerson = Console.ReadLine();
                while (isPerson != "y" && isPerson != "n")
                {
                    Console.Write("输入错误，请重新输入：");
                    isPerson = Console.ReadLine();
                }
                pers[i] = new Player(str, isPerson == "n");
            }
        }

        Random r = new Random();
        public void PlayContent()
        {
            for (int i = 0; i < pers.Length; i++)
            {
                Console.Clear();//清屏
                PrintTitle();

                int temp;
                if (pers[i].IsPerson == false)
                {
                    temp = r.Next(1, 4);
                }
                else
                {
                    Console.Write($"\n请玩家{pers[i].Name}选择游戏手势（1.石头，2.剪刀，3.布）：");
                    bool f = int.TryParse(Console.ReadLine(), out temp);
                    while (!f || temp < 1 || temp > 3)
                    {
                        Console.Write("您的输入有误，请重新输入：");
                        f = int.TryParse(Console.ReadLine(), out temp);
                    }
                }
                pers[i].PlayContent = temp;
            }
        }


        public void GetResult()
        {
            Console.WriteLine("*************参赛结果为*****************");
            for (int i = 0; i < pers.Length; i++)
            {
                Console.WriteLine($"{pers[i].Name}出了\t{pers[i].PlayContent}");
            }

            Console.WriteLine("************游戏结果为******************");
            int kind = 1;
            int a = pers[0].PlayContent;
            int b = 0;

            for (int i = 0; i < pers.Length; i++)
            {
                if (a != pers[i].PlayContent && b != pers[i].PlayContent)
                {
                    b = pers[i].PlayContent;
                    kind++;
                    if (kind == 3)
                    {
                        break;
                    }

                }
            }

            if (kind == 2)
            {
                if ((a == 1 && b == 2) || (a == 2 && b == 3) || (a == 3 && b == 1))
                {
                    for (int i = 0; i < pers.Length; i++)
                        if (pers[i].PlayContent == a)
                        {
                            Console.WriteLine($"{pers[i].Name}获胜");
                        }
                }
                else
                {
                    for (int i = 0; i < pers.Length; i++)
                        if (pers[i].PlayContent == b)
                        {
                            Console.WriteLine($"{pers[i].Name}获胜");
                        }
                }
            }
            else
            {
                Console.WriteLine("平局");
            }
        }
    }
}
