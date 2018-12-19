using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 2016年11月2日 作业 02-1
/// 目的：让用户输入姓名、性别、年龄、籍贯、爱好、邮箱、自我介绍之后，显示这些信息在屏幕上
/// </summary>
namespace Homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入您的姓名：");
            string name = Console.ReadLine();
            Console.Write("请输入您的性别：");
            string sex = Console.ReadLine();
            Console.Write("请输入您的年龄：");
            string age = Console.ReadLine();
            Console.Write("请输入您的籍贯：");
            string native = Console.ReadLine();
            Console.Write("请输入您的爱好：");
            string love = Console.ReadLine();
            Console.Write("请输入您的邮箱：");
            string email = Console.ReadLine();
            Console.Write("请输入您的自我介绍：");
            string myself = Console.ReadLine();
            Console.WriteLine("=======================================");
            Console.WriteLine("姓名：" + name+"\t"+"性别：" +sex+"\n"+"年龄："+age+"\t"+"籍贯："+native+"\n"+"爱好："+love+"\n"+"邮箱："+email+"\n"+"自我介绍：\n"+"\t"+myself);

        }
    }
}
