using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_T1_11_15
{
    class Calculator
    {
        private double num1;
        public double Num1
        {
            get { return num1; }
            set { num1 = value; }
        }

        private double num2;
        public double Num2
        {
            get { return num2; }
            set { num2 = value; }
        }

        private double result;
      
        //加
        public void Add()
        {
            result = num1 + num2;
            Console.WriteLine(result);
        }
        //减
        public void Reduce()
        {
            result = num1 - num2;
            Console.WriteLine(result);
        }
        //乘
        public void Ride()
        {
            result = num1 * num2;
            Console.WriteLine(result);
        }
        //除
        public void Division()
        {
            result = num1 / num2;
            Console.WriteLine(result);
        }
    }

}
