using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game();
            game1.PrintTitle();            
            game1.SetPlayerNum();
            game1.SetPlayer();
            game1.PlayContent();
            game1.GetResult();
            Console.WriteLine("游戏结束");
        }
    }
}
