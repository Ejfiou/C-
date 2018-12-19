using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_30
{
    public class MyObjectBookView : MyObjectView
    {
        public override IMyObject Create()
        {
            IMyObject books = null;

            Console.Write("请输入要添加的图书的编号：");
            string bookNo = Console.ReadLine();

            Console.Write("请输入要添加的图书的名字：");
            string bookName = Console.ReadLine();

            books = new Book(bookNo, bookName);

            return books;
        }

        public override IMyObject Modify()
        {
            IMyObject books = null;

            Console.Write("请输入要更改的图书的编号：");
            string bookNo = Console.ReadLine();
            Console.Write("请输入更改后的图书的名字：");
            string bookName = Console.ReadLine();
            books = new Book(bookNo, bookName);

            return books;
        }

        public override void PrintMany(IMyObject[] objs)
        {
            Console.WriteLine("\n************图书信息如下*******************");

            if (objs != null)
            {
                for (int i = 0; i < objs.Length; i++)
                {
                    Console.WriteLine(objs[i].ShowMe());
                }
            }
            else
            {
                Console.WriteLine("对不起！当前没有任何书本信息！");
            }
        }

        public override void PrintMenu()
        {
            Console.WriteLine("图书信息管理系统  V1.0");
            Console.WriteLine("0.注销");
            Console.WriteLine("1.增加图书信息");
            Console.WriteLine("2.查询所有图书信息");
            Console.WriteLine("3.修改图书信息");
            Console.WriteLine("4.删除图书信息");
            Console.WriteLine("5.按编号查询对应图书信息");
            Console.WriteLine("6.按书名查询对应图书信息");
        }

        public override void PrintOne(IMyObject obj)
        {
            Console.WriteLine("\n************图书信息如下*******************");

            if (obj != null)
            {
                Console.WriteLine(obj.ShowMe());
            }
            else
            {
                Console.WriteLine("对不起！没有对应的图书信息！");
            }
        }

        public override IMyObject QueryByNonPrimaryKey()
        {
            IMyObject temp = null;

            Console.WriteLine("请输入要查询的书名：");
            string bookName = Console.ReadLine();

            temp = new Book("", bookName);

            return temp;
        }

        public override string QueryByPrimaryKey()
        {
            string bookNo = null;

            Console.WriteLine("请输入要查询的图书编号：");
            bookNo = Console.ReadLine();

            return bookNo;
        }

        public override IMyObject Remove()
        {
            IMyObject books = null;

            Console.Write("请输入要删除的图书编号：");
            string bookNo = Console.ReadLine();

            books = new Book(bookNo,"");

            return books;
        }
    }
}
