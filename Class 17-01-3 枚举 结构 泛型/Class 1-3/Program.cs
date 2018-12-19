using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //枚举
            //Person p = new Person();
            //p.Name = "tom";
            //p.Age = 21;
            ////p.Sex = Genders.Female;
            //p.Sex = Genders.男;
            //Console.WriteLine(p.Sex);
            //Console.WriteLine((int)p.Sex);//枚举转整数
            //Console.WriteLine((Genders)1);//整数转枚举

            ////枚举转字符串
            //Console.WriteLine(p.Sex.ToString());

            ////字符串转化为枚举
            //string s = "男";
            //Genders g = (Genders)(Enum.Parse(typeof(Genders), s));
            //Console.WriteLine((int)g);

            //结构
            //MyStruct s = new MyStruct("tom",21);
            ////s.name = "dd";
            //Console.WriteLine(s.name);
            ////s.Age = 21;
            //Console.WriteLine(s.Age);
            //s.ShowMe();

            //造人
            //Person p1 = new Person() { Name="tom",Age=21,Sex=Genders.男};
            //Person p2 = new Person() { Name = "jack", Age = 31, Sex = Genders.男 };
            //Person p3 = new Person() { Name = "rose", Age = 11, Sex = Genders.女 };

            ////泛型
            //List<Person> list = new List<Person>();
            //list.Add(p1);
            //list.Add(p2);
            //list.Add(p3);

            ////Console.WriteLine(list.Count);
            ////for (int i = 0; i < list.Count; i++)
            ////{
            ////    Console.WriteLine(list[i].ShowMe());
            ////}

            //foreach (Person p in list)
            //{
            //    Console.WriteLine(p.ShowMe());
            //}

            //list[1] = new Person() { Name = "jack", Age = 88, Sex = Genders.男 };
            //foreach (Person p in list)
            //{
            //    Console.WriteLine(p.ShowMe());
            //}

            //list.RemoveAt(1);//删除
            //list.Remove(p1);
            //foreach (Person p in list)
            //{
            //    Console.WriteLine(p.ShowMe());
            //}

            //造人
            Person p1 = new Person() { Name = "tom", Age = 21, Sex = Genders.男 };
            Person p2 = new Person() { Name = "jack", Age = 31, Sex = Genders.男 };
            Person p3 = new Person() { Name = "rose", Age = 11, Sex = Genders.女 };

            Dictionary<string, Person> dic = new Dictionary<string, Person>();
            dic.Add(p1.Name, p1);
            dic.Add(p2.Name, p2);
            dic.Add(p3.Name, p3);

            dic["jack"] = new Person() { Name = "jack", Age = 88, Sex = Genders.男 };
            foreach (KeyValuePair<string,Person>  p in dic)
            {
                Console.WriteLine(p.Key+"-------"+p.Value.ShowMe());
            }

            
        }
    }
}
