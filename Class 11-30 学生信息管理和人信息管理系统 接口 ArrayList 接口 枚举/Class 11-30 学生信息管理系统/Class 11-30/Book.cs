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

        public Book(string bookNo, string bookName, string author, float price)
        {
            this.bookNo = bookNo;
            this.bookName = bookName;
            this.author = author;
            this.price = price;
        }

        /// <summary>
        /// 编号
        /// </summary>
        private string bookNo;
        public string BookNo
        {
            get { return bookNo; }
            set { bookNo = value; }            
        }

        /// <summary>
        /// 书名
        /// </summary>
        private string bookName;
        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }            
        }

        /// <summary>
        /// 作者
        /// </summary>
        private string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        /// <summary>
        /// 价格
        /// </summary>
        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        
        public string PrimaryKey
        {
            get { return bookNo; }
            set { bookNo = value; }         
        }

        public string ShowMe()
        {
            //return "图书编号：" + bookNo + "\t图书名：" + bookName + "\t作者：" + author + "\t价格：" + price;
            return string.Format("图书编号：{0,-15}图书名：{1,-10}作者：{2,-10}价格：{3,10:C}", BookNo, bookName, author, price);
        }
    }
}
