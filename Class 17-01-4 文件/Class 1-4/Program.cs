using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Class_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //File类
            //string a = @"F:\a.txt";
            //string b = @"F:\b.txt";
            //string c = @"F:\.txt";

            //File.Copy(a, b);

            //File.Create(@"F:\d.txt");

            //File.Delete(@"F:\d.txt");

            //if(File.Exists(@"F:\a.txt"))//判断是否有文件
            //{
            //    Console.WriteLine("有");
            //}
            //else
            //    Console.WriteLine("无");

            //File.Move(@"F:\1\a.txt", @"F:\a.txt");

            //FileInfo类
            //FileInfo f =new FileInfo(@"F:\1\a.txt");
            // Console.WriteLine(f.Attributes);//获取或设置当前文件或目录的特性。
            // Console.WriteLine(f.CreationTime);
            //Console.WriteLine(f.Directory);//获取父目录的实例
            //Console.WriteLine(f.DirectoryName);//获取表示目录的完整路径的字符串。
            //Console.WriteLine(f.Extension);//获取扩展名
            //Console.WriteLine(f.Exists);//是否存在文件
            //Console.WriteLine(f.FullName);//获取完整目录
            //Console.WriteLine(f.IsReadOnly);//是否为只读.
            //Console.WriteLine(f.Length);//获取文件大小，字节为单位
            //Console.WriteLine(f.Name);//获取文件名

            //Directory 类
            //Directory.CreateDirectory(@"F:\1\123");//在指定路径中创建所有目录和子目录，除非它们已经存在
            //Directory.Delete(@"F:\1\123",true);//删除空目录
            //Console.WriteLine(Directory.Exists(@"F:\1\123")); //是否存在文件夹
            //Console.WriteLine(Directory.GetCurrentDirectory() );//获取应用程序的当前工作目录

            //string[] a = Directory.GetDirectories(@"F:\");//返回(数组)指定目录中的子目录的名称（包括其路径）
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}

            //string[] a = Directory.GetFiles(@"F:\1");//返回指定目录中文件的名称（包括其路径）
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}

            //string[] c = Directory.GetLogicalDrives(); //检索此计算机上格式为 "<drive letter>:\" 的逻辑驱动器的名称。
            //for (int i = 0; i < c.Length; i++)
            //{
            //    Console.WriteLine(c[i]);
            //}

            //Console.WriteLine(Directory.GetParent(@"F:\2\3\5\7"));//检索指定路径的父目录
            //Directory.Move(@"F:\1\123\4", @"F:\1\111");//移动文件夹

            DirectoryInfo d = new DirectoryInfo(@"1\123\5.xlsx");
            Console.WriteLine(d.Root); //根目录
            Console.WriteLine(d.Name);
            Console.WriteLine(d.Parent);
            Console.WriteLine(d.CreationTime);
            Console.WriteLine(d.Extension);

        }
    }
}
