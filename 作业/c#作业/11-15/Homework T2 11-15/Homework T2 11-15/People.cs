using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_T2_11_15
{
    class People
    {
        private string name;
        private string sex;
        private string height;
      
        //输入信息
        public void GetPeople()
        {
            Console.Write("请输入姓名：");
            name = Console.ReadLine();
            Console.Write("请输入性别：");
            sex = Console.ReadLine();
            Console.Write("请输入身高：");
            height = Console.ReadLine();
        }

        //显示信息
        public void PeopleShow()
        {
            Console.WriteLine("姓名："+name);
            Console.WriteLine("性别："+sex);
            Console.WriteLine("身高：" + height);
            Console.WriteLine();
        }

        public void Eat()
        {
            Console.WriteLine(name + "吃了");
        }
        public void Drink()
        {
            Console.WriteLine(name + "喝了");
        }
        public void Pull()
        {
            Console.WriteLine(name + "拉了");
        }
        public void Samuel()
        {
            Console.WriteLine(name + "撒了");
        }
        public void Sleep()
        {
            Console.WriteLine(name + "睡了");
        }

    }
}
