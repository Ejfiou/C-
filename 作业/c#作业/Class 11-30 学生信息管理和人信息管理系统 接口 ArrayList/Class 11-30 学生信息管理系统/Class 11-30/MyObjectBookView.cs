using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Class_11_30
{
    public class MyObjectBookView : MyObjectView
    {
        public override IMyObject Create()
        {
            IMyObject books = null;

            Console.Write("请输入要添加的图书的编号（13位）：");
            string bookNo = Console.ReadLine().Trim();
            while(Regex.IsMatch(bookNo,@"[0-9]{13}")==false)
            {
                Console.Write("输入有误！请重新输入编号(13位)：");
                bookNo = Console.ReadLine();
            }
            Console.Write("请输入要添加的图书书名：");
            string bookName = Console.ReadLine().Trim();
            while (Regex.IsMatch(bookName, @"^\w+$") == false)
            {
                Console.Write("输入有误！请重新输入书名：");
                bookName = Console.ReadLine().Trim();
            }

            Console.Write("请输入要添加的图书的作者姓名：");
            string author = Console.ReadLine().Trim();
            while (Regex.IsMatch(author,@"^\w+$")==false)
            {
                Console.Write("输入有误！请重新输入作者姓名：");
                author = Console.ReadLine().Trim();
            }


            Console.Write("请输入要添加的图书的价格(格式0.00)：");
            string strPrice = Console.ReadLine().Trim();
            while (Regex.IsMatch(strPrice, @"^\d+\.\d{2}$") ==false)
            {
                Console.Write("输入有误！请重新输入价格（格式0.00）：");
                strPrice = Console.ReadLine();
            }

            float price;
            bool  f =float.TryParse(strPrice,out price);

            books = new Book(bookNo, bookName, author, price);

            return books;
        }

        public override IMyObject Modify()
        {
            IMyObject books = null;

            Console.Write("请输入要更改的图书的编号：");
            string bookNo = Console.ReadLine().Trim();
            while (Regex.IsMatch(bookNo, @"[0-9]{13}") == false)
            {
                Console.Write("输入有误！请重新输入编号(13位)：");
                bookNo = Console.ReadLine();
            }

            Console.Write("请输入更改后的图书的书名：");
            string bookName = Console.ReadLine().Trim();
            while (Regex.IsMatch(bookName, @"^\w+$") == false)
            {
                Console.Write("输入有误！请重新输入书名：");
                bookName = Console.ReadLine().Trim();
            }

            Console.Write("请输入要修改的图书的作者姓名：");
            string author = Console.ReadLine().Trim();
            while (Regex.IsMatch(author, @"^\w+$") == false)
            {
                Console.Write("输入有误！请重新输入作者姓名：");
                author = Console.ReadLine().Trim();
            }

            Console.Write("请输入要添加的图书的价格：");
            string strPrice = Console.ReadLine().Trim();
            while (Regex.IsMatch(strPrice, @"^\d+\.\d{2}$") == false)
            {
                Console.Write("输入有误！请重新输入价格：");
                strPrice = Console.ReadLine();
            }

            float price;
            bool f = float.TryParse(Console.ReadLine(), out price);

            books = new Book(bookNo, bookName, author, price);

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
            Console.WriteLine("6.按条件查询对应图书信息");
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

            Console.WriteLine();
            Console.WriteLine("请选择以下的查询条件：");
            Console.WriteLine("1.书名：");
            Console.WriteLine("2.作者：");
            int index = ChoiceMenu();
            switch(index)
            {
                case 1:
                    Console.Write("请输入要查询的书名：");
                    string bookName = Console.ReadLine().Trim();
                    while (Regex.IsMatch(bookName, @"^\w+$") == false)
                    {
                        Console.Write("输入有误！请重新输入书名：");
                        bookName = Console.ReadLine().Trim();
                    }
                    temp = new Book(null, bookName, null, 0);
                    break;
                case 2:
                    Console.Write("请输入要查询的作者姓名：");
                    string author = Console.ReadLine().Trim();
                    while (Regex.IsMatch(author, @"^\w+$") == false)
                    {
                        Console.Write("输入有误！请重新输入作者姓名：");
                        author = Console.ReadLine().Trim();
                    }
                    temp = new Book(null, null, author, 0);
                    break;
            }

            return temp;
        }

        public override string QueryByPrimaryKey()
        {
            Console.Write("请输入要查询的图书编号：");
            string bookNo = Console.ReadLine().Trim();
            while (Regex.IsMatch(bookNo, @"[0-9]{13}") == false)
            {
                Console.Write("输入有误！请重新输入编号(13位)：");
                bookNo = Console.ReadLine();
            }

            return bookNo;
        }

        public override IMyObject Remove()
        {
            IMyObject books = null;

            Console.Write("请输入要删除的图书编号：");
            string bookNo = Console.ReadLine().Trim();
            while (Regex.IsMatch(bookNo, @"[0-9]{13}") == false)
            {
                Console.Write("输入有误！请重新输入编号(13位)：");
                bookNo = Console.ReadLine();
            }

            books = new Book(bookNo,null,null,0);

            return books;
        }
    }
}
