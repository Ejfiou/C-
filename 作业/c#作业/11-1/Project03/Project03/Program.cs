using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("姓名\t性别\t年龄\t籍贯\t爱好\ntom\t男\t23\tsuzhou\tread\njack\t男\t21\tsuzhou\tsleep\nrose\t女\t18\tsuzhou\teat\njerry\t女\t20\tsuzhou\tplay");

            Console.WriteLine("请输入整数的个数：");
            int a = int.Parse(Console.ReadLine());
            int[] arr = new int[a];
            for(int i=0;i<arr.Length;i++)
            {
                Console.Write($"请输入第{i+1}个整数：");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Class1 c = new Class1 ();
            Console.WriteLine(c.A(arr));

        }

    }
}
