using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Class_12_29
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();
            int index = a1.Add("tom");
            a1.Add("jack");
            a1.Add(12);
            a1.Add(15);
            a1.Add(17);
            a1.Add(19);
            a1.Add(88);
            Console.WriteLine(index);
            Console.WriteLine(a1.Count);

            //a1.Remove(88);//按元素删除
            //Console.WriteLine(a1.Count);
            //a1.RemoveAt(3);//按下标删除
            //Console.WriteLine(a1.Count);
            //a1.RemoveRange(0, 2);//索引位置加个数          
            //Console.WriteLine(a1.Count);

            //int i = a1.IndexOf(12);
            //Console.WriteLine(i);

            //bool f = a1.Contains(12);//查找元素
            //Console.WriteLine(f);

            //for (int i = 0; i < a1.Count; i++)
            //{
            //    a1[i] = "jj";
            //}

            //for (int i = 0; i < a1.Count; i++)
            //{
            //    Console.Write(a1[i] + "\t");
            //}
            //Console.WriteLine();

            //a1[a1.IndexOf(12)] = "jklj";

            //foreach (object o in a1)
            //{
            //    Console.Write(o+"\t");
            //}
            //Console.WriteLine();

            //object[] objs = a1.ToArray(); //ArrayList  ---> Array
            //for (int i = 0; i < objs.Length; i++)
            //{
            //    Console.Write(objs[i]+"\t");
            //}
            //Console.WriteLine();

            //造人
            //Person p1 = new Person("tom",21);
            //Person p2 = new Person(name: "jack", age: 32);
            //Person p3 = new Person(age: 18, name: "rose") ;

            //ArrayList a1 = new ArrayList();
            //a1.Add(p1);
            //a1.Add(p2);
            //a1.Add(p3);
            //for (int i = 0; i < a1.Count; i++)
            //{
            //    Console.WriteLine(a1[i]);//重写了ToString();
            //}

            //for (int i = 0; i < a1.Count; i++)
            //{
            //    if (a1[i] is Person)
            //    {
            //        Console.WriteLine((a1[i] as Person).ShowMe());
            //    }
            //}
            //int index = -1;
            //for (int i = 0; i < a1.Count; i++)
            //{
            //    if (a1[i] is Person)
            //    {
            //        if((a1[i] as Person).Name == "jack")
            //        {
            //            index = i;
            //            break;
            //        }
            //    }
            //}
            ////(a1[index] as Person).Age = 45;
            //a1[index] = new Person(name: "jack", age: 88);

            //for (int i = 0; i < a1.Count; i++)
            //{
            //    if (a1[i] is Person)
            //    {
            //        if ((a1[i] as Person).Name == "jack")
            //        {
            //            a1[i] = new Person(name: "jack", age: 88);
            //            break;
            //        }
            //    }
            //}
            //for (int i = 0; i < a1.Count; i++)
            //{
            //    Console.WriteLine(a1[i]);//重写了ToString();
            //}

            //Hashtable ht = new Hashtable();//哈希表
            //无序性
            //ht.Add(3,"tom");
            //ht.Add("stu", 21);
            //ht.Add(6,"jj");
            //foreach (DictionaryEntry de in ht)
            //{
            //    Console.WriteLine(de.Key + "-----" + de.Value);
            //}
            //Console.WriteLine(ht.Count);
            //ht.Remove(6);
            //Console.WriteLine(ht.Count);
            //ht["stu"] = 88;
            //foreach (DictionaryEntry de in ht)
            //{
            //    Console.WriteLine(de.Key + "-----" + de.Value);
            //}

            //造人
            Person p1 = new Person("tom", 21);
            Person p2 = new Person(name: "jack", age: 32);
            Person p3 = new Person(age: 18, name: "rose");

            Hashtable ht = new Hashtable();
            ht.Add(p1.Name, p1);
            ht.Add(p2.Name, p2);
            ht.Add(p3.Name, p3);
            foreach (DictionaryEntry de in ht)
            {
                Console.WriteLine(de.Key+"-------"+de.Value);
            }
            foreach (DictionaryEntry de  in ht)
            {
                if(de.Value is Person)
                {
                    Console.WriteLine(de.Key + "-----" + (de.Value as Person).ShowMe());
                }
            }

            ht["jack"] = new Person(name: "jack", age: 88);
            foreach (DictionaryEntry de in ht)
            {
                Console.WriteLine(de.Key + "-------" + de.Value);
            }
            ht.Remove("jack");
            foreach (DictionaryEntry de in ht)
            {
                Console.WriteLine(de.Key + "-------" + de.Value);
            }

        }
    }
}
