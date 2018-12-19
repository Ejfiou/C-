using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_T1_11_16
{
    class Calculator
    {
        //private double num1;
        //public double Num1
        //{
        //    get { return num1; }
        //    set { num1 = value; }
        //}

        //private double num2;
        //public double Num2
        //{
        //    get { return num2; }
        //    set { num2 = value; }
        //}      

        //加
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        //减
        public double Reduce(double num1, double num2)
        {
            return num1 - num2;
        }

        //乘
        public double Ride(double num1, double num2)
        {
            return num1 * num2;
        }

        //除
        public double Division(double num1, double num2)
        {
            return num1 / num2;
        }
    }

}
