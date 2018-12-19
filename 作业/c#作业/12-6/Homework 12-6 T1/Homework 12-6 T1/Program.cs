using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12_6_T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car(30);
            c.Size = 30;
            c.ShowMe();
            c.ShowMe1();
            Console.WriteLine();

            Truck v = new Truck();
            v.Kind = "大货车";
            v.ShowMe();
            v.ShowMe1();
            Console.WriteLine();

            PassengerCar b = new PassengerCar();
            b.Passengers = 20;
            b.ShowMe();
            b.ShowMe1();
            Console.WriteLine();


            Car c1 = new Truck("大货车",20);
            c1.ShowMe();
            c1.ShowMe1();
            Console.WriteLine();

            Car c2 = new PassengerCar(20,30);
            c2.ShowMe();
            c2.ShowMe1();
            Console.WriteLine();

            Car[] c3 = new Car[3];
            c3[0] = new Car(30);
            c3[1] = new PassengerCar(20, 30);
            c3[2] = new Truck("大货车", 20);

            Console.WriteLine("覆盖:");
            for (int i = 0; i < c3.Length; i++)
            {
                c3[i].ShowMe();
            }

            Console.WriteLine();
            Console.WriteLine("重写:");
            for (int i = 0; i < c3.Length; i++)
            {
                c3[i].ShowMe1();
            }

        }
    }
}
