using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_12_6
{
    public class Son:Father
    {
        public Son()
        {
            Console.WriteLine("Son无参数构造函数");
        }

        //public Son(string nickName,string name)
        //{
        //    this.nickName = nickName;
        //    base.Name = name;  //私有的不能被继承
        //}

        public Son(string nickName, string name):base(name)
        {
            Console.WriteLine("Son两个参数构造函数");
            this.nickName = nickName;
        }

        private string nickName;
        public string NickName
        {
            get { return nickName; }
            set { nickName = value; }
        }
        public void ShowSon()
        {
            Console.WriteLine("Son");
        }
        
        /// <summary>
        /// 覆盖，隐藏方法
        /// </summary>
        public new void Test()//覆盖
        {
            //this.ShowSon();
            //base.ShowFather();
            Console.WriteLine("Son Test");
        }

        /// <summary>
        /// 重写方法
        /// </summary>
        public override void Test1()
        {
            Console.WriteLine("Son Test1");
        }
    }
}
