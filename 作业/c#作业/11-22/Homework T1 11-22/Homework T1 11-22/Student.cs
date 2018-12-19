using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_T1_11_22
{
    class Student
    {
        public Student()
        {

        }


        public string this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return name;
                }
                else if (index == 1)
                {
                    return sex;
                }
                else if (index == 2)
                {
                    return age.ToString();
                }
                else
                   return "输入错误" ;
            }
            set
            {
                if (index == 0)
                {
                    name=value;
                }
                else if (index == 1)
                {
                    sex=value;
                }
                else if (index == 2)
                {
                    age= Convert.ToInt32(value);
                }
              
            }
        }

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        private string sex;
        public string Sex
        {
            get
            {
                return sex;
            }
            set
            {
                sex = value;
            }
        }

        private int age;
        public int Age
        {
            get
            {                
                return age;
            }
            set
            {
                //bool y = int.TryParse(Console.ReadLine(), out age);
                age = value;
            }
        }


        public void ShowMe()
        {
            Console.WriteLine("姓名：" + name);
            Console.WriteLine("性别：" + sex);
            Console.WriteLine("年龄：" + age);
        }
    }
}
