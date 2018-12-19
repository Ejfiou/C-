using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11_17
{
    class Functions
    {
        //判断是否奇数
        public string OddNumber(int odd)
        {
            if (odd % 2 == 0)
            {
                return "不是奇数";
            }
            else
            {
                return "是奇数";
            }
        }

        //判断是否对称数
        public string SymmetricNumber(int sy)
        {
            int g, s, q, w;           //提取各个位上的数
            g = sy % 10;
            s = sy / 10 % 10;
            q = sy / 1000 % 10;
            w = sy / 10000 % 10;
            if (s == q && g == w)
            {
               return "是对称数";
            }
            else
            {
               return "不是对称数";
            }
        }

        //倒着输出
        public int Reverse(int re)
        {
            int result = 0;
            while (re > 0)
            {
                result = result * 10 + re % 10;
                re /= 10;
            }
            return result;
        }

        //长方形周长
        public int Perimeter(int length, int wide)
        {
            int result;
            result = (length + wide) * 2;
            return result; 
        }

        //质数
        public string Prime(int pri)
        {
            int i = 0;
            for (int j = 2; j < pri; j++)
            {
                if (pri % j == 0)
                {
                    i++;
                }
            }
            if (i == 0)
            {
                return "是质数";
            }
            else
            {
                return "不是质数";
            }
        }

        //字符串长度
        public int Length(string l)
        {
            int i = 0;
            foreach (char s in l)
            {
                i++;
            }
            return i;
        }

        //两个的最大值
        public int Max(int num1, int num2)
        {
            return num1 > num2 ? num1 : num2;
        }

        //三个的最大值
        public int Max2(int num1, int num2, int num3)
        {
            int max;
            max = num1 > num2 ? num1 : num2;
            max = max > num3 ? max : num3;
            return max;
        }

    }
}
