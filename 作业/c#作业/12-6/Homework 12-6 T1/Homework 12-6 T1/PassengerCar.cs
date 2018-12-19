using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12_6_T1
{
    public class PassengerCar:Car
    {
        public PassengerCar()
        {

        }

        public PassengerCar(int passengers, int size):base(size)
        {
            this.passengers = passengers;
        }

        private int passengers;
        public int Passengers
        {
            set { passengers = value; }
            get { return passengers; }
        }

        public new void ShowMe()
        {
            Console.WriteLine("乘客人数为：" + passengers);
        }

        public override void ShowMe1()
        {
            Console.WriteLine("客车");
        }


    }
}
