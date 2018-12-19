using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_T2_11_16
{
    class People
    {

        //private string name;
        //private string sex;
        //private string height;

        //显示信息
        public string PeopleShow(string name,string sex,string height)
        {           
            return "姓名：" + name + "\n性别：" + sex + "\n身高：" + height;
        }

        public string Eat(string name)
        {
            return name + "吃了";
        }
        public string Drink(string name)
        {
            return name + "喝了";
        }
        public string Pull(string name)
        {
            return name + "拉了";
        }
        public string Samuel(string name)
        {
            return name + "撒了";
        }
        public string Sleep(string name)
        {
            return name + "睡了";
        }
    }
}
