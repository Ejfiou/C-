using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
///  
///            学生管理系统：
///   *******************************
///   * 增加学生信息
///   * 修改学生信息
///   * 删除学生信息
///   * 查询所有学生信息
///   * 按学号查询对应的学生信息
///   * 按姓名查询对应的学生信息
/// </summary>
namespace Class_11_30
{
    class Program
    {
       
        static void Main(string[] args)
        {

             new MyObjectController<MyObjectPersonView, MyObjectPersonDAOList>();
            //MyController con = new MyController();

            //con.Start();

            //MyObjectController o = new MyObjectController();

            //o.Start();

            //Database db = new Database();

            //Console.WriteLine(db.UsersStruct.Length);
            //for (int i = 0; i < db.UsersStruct.Length; i++)
            //{

            //    if (string.IsNullOrWhiteSpace(db.UsersStruct[i].Username))
            //    {
            //        Console.WriteLine("没有数据");
            //    }
            //    else
            //    {
            //        Console.WriteLine(db.UsersStruct[i].ShowMe());
            //    }
            //}

            //Console.WriteLine("请输入密码：");
            //StringBuilder sb = new StringBuilder();
            //ConsoleKeyInfo info = Console.ReadKey(true);
            //while (info.Key != ConsoleKey.Enter)
            //{
            //    if (info.Key==ConsoleKey.Backspace)
            //    {
            //        if (sb.Length>0)
            //        {
            //            Console.Write("\b");
            //            Console.Write(" ");
            //            Console.Write("\b");
            //            sb.Remove(sb.Length - 1, 1);
            //        }                    
            //    }
            //    else
            //    {
            //        Console.Write("*");
            //        sb.Append(info.KeyChar);
            //       
            //    }
            //    info = Console.ReadKey(true);
            //}
            //Console.WriteLine(sb);


        }
    }
}
