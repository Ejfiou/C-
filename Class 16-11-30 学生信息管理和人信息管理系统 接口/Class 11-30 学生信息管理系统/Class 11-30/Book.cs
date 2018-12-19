using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11_30
{
    public class Book:IMyObject
    {
        public Book()
        {

        }

        public Book(string bookNo, string bookName)
        {
            this.bookNo = bookNo;
            this.bookName = bookName;      
        }

        private string bookNo;
        public string BookNo
        {
            get { return bookNo; }
            set { bookNo = value; }            
        }

        private string bookName;
        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }            
        } 

        public string PrimaryKey
        {
            get { return bookNo; }
            set { bookNo = value; }         
        }

        public string ShowMe()
        {
            return "图书编号为：\t" + bookNo + "\t图书名为：\t" + bookName;
        }
    }
}
