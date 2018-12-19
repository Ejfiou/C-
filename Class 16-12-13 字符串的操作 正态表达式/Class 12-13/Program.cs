using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Class_12_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = "tom";

            //char[] ch = { 't','o', 'm'};
            //string s = new string(ch);
            //Console.WriteLine(s.Length);
            //Console.WriteLine(s[2]);

            //string s1 = ",";
            //string s2 = "cde";

            //Console.WriteLine(string.Compare(s1,s2));
            //string s1 = "anidg{0}mal";
            //string s2 = "kkkkl";

            //Console.WriteLine("Comparison of '{0}' and '{1}': {2}", s1, s2, s1.CompareTo(s2));

            //Console.WriteLine(string.Format(s1, s2) );

            //Console.WriteLine(string.Concat(s1,s2));

            //string[] arr = { "alll","jkj","jlj"};

            //Console.WriteLine(string.Join(s1,arr));

            //string s3 = "hello,word";
            //char s2 = ',';
            //string[] arr = s3.Split(s2);

            //Console.WriteLine(arr[1]);
            // string sentence = "The dog had a bone, a ball, and other toys.";
            // char[] charsToTrim = { ',', '.', ' ' };
            //string[] words = sentence.Split();
            //foreach (string word in words)
            //Console.WriteLine(sentence.TrimEnd(charsToTrim));

            //string s1 = "aaa\0aaaa";
            //Console.WriteLine(s1);
            //Console.WriteLine(s1.Insert(2, "4"));

            //string s1 = "dfdsafg";
            //char[] arr = { ' ', 'a', 'b' };
            //Console.WriteLine(s1.TrimStart(arr));

            //char[] arr1 = { ' ', 'g', 'f' };
            //Console.WriteLine(s1.TrimEnd(arr1));

            string s = "01ccxz23456";
            //Console.WriteLine(s.StartsWith("D"));

            //Console.WriteLine(s.IndexOf("dddddd"));

            char[] arr2 = { '1', '4' };
            Console.WriteLine(s.LastIndexOfAny(arr2, 0));

            Console.WriteLine(s.Substring(3, 6));

            //Console.WriteLine(string.Copy(s1));

            char[] arr3 = { 'a', 'b', 'c', 'd', 'e', 'f', ' ', ' ' };
            s.CopyTo(2, arr3, 2, 5);

            Console.WriteLine(arr3);

            //Console.WriteLine(s1.ToUpper());

            //string str = "fsdafsf";
            //char[] arr4 = new char[30];

            //str.CopyTo(1, arr4, 3, 4);
            //Console.WriteLine(arr4);

            //Console.WriteLine();
            //int t =Convert.ToInt32( Console.ReadLine());

            //string p = s1[t-1].ToString().ToUpper();
            //Console.WriteLine(p);

            //Console.WriteLine(s1.Insert(t - 1, p).Remove(t, 1)); 

            //string str = "tom";

            //str = "jj";

            //StringBuilder ss = new StringBuilder("stom");
            //ss.Append("QQ");
            //Console.WriteLine(ss);
            //ss.Insert(0, "t ");
            //Console.WriteLine(ss);
            //ss.Remove(0, 2);
            //Console.WriteLine(ss);

            //bool flag = false;
            //StringBuilder sb = new StringBuilder();
            //sb.Append("The value of the flag is ").Append(flag).Append(".");
            //Console.WriteLine(sb);
            //Console.WriteLine(str.GetType());

            //int i = 5;
            //Console.WriteLine("i is an int? {0}", i.GetType() == typeof(int));
            //Console.WriteLine("i is an int? {0}", typeof(int).IsInstanceOfType(i));

            //Regex reg = new Regex("b..g");
            //bool flag = reg.IsMatch("biigg");
            //Console.WriteLine(flag);

            //Regex reg1 = new Regex("b[0|5]g");
            //bool flag1 = reg1.IsMatch("b55gg");
            //Console.WriteLine(flag1);


            //Regex reg1 = new Regex("^bag\\d{2,4}m$");
            //bool flag1 = reg1.IsMatch("bag230m");
            //Console.WriteLine(flag1);

            //bool flag = Regex.IsMatch("119",@"^\d{6}$");
            //Console.WriteLine(flag);

            //StringBuilder sb = new StringBuilder();
            //sb.Append(Console.ReadLine()).Append(Console.ReadLine()).Append(Console.ReadLine()).Append(Console.ReadLine()).Append(Console.ReadLine());
            //Console.WriteLine(sb);


            //bool flag = Regex.IsMatch(Console.ReadLine(), @"[a-zA-Z]{5}");
            //Console.WriteLine(flag);


            //Match m = Regex.Match("age=30kjk,age=30,age=30", "(.+?)=(.+?)");
            //Console.WriteLine(m.Success);
            //Console.WriteLine(m.Groups[1].Value);
            //Console.WriteLine(m.Groups[2].Value);


            //MatchCollection ms = Regex.Matches("age=32no=2age=110", @"age=(\d+)");
            //Console.WriteLine(ms.Count);
            //Console.WriteLine(ms[0].Success);
            //Console.WriteLine(ms[0].Groups[1].Value);
            //Console.WriteLine(ms[1].Success);
            //Console.WriteLine(ms[1].Groups[1].Value);
            //Console.WriteLine(ms[2].Success);
            //Console.WriteLine(ms[2].Groups[1].Value);
            //for(int i=0;i<ms.Count;i++)
            //{
            //    if(ms[i].Success)
            //    {
            //        Console.WriteLine(ms[i].Groups[1].Value);
            //    }
            //}

            //foreach (Match m in ms)
            //{
            //    if (m.Success)
            //    {
            //        Console.WriteLine(m.Groups[1].Value);
            //    }
            //}


            //string reStr = Regex.Replace("t--------o--m---o----k", "-+", ":");
            //Console.WriteLine(reStr);

            //string reStr = Regex.Replace("2003-5-4", @"(\d{4})-(\d{1,2})-(\d{1,2})", "$1年$2月$3日");
            //Console.WriteLine(reStr);

            string reStr = Regex.Replace("ttootttoom", @"(.)(.) \1+", "$1");
            Console.WriteLine(reStr);

        }
    }
}
