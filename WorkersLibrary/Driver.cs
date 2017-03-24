using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersLibrary
{
    public sealed class Driver : Worker // запечатанный/стерильный
    {
        public int hours;
        public string carType;

        public Driver(string name, int age, int snn, int hours, string carType)
            : base(name, age, snn) //обращение к базовому (самому базовому) конструктору Worker
        {
            this.hours = hours;
            this.carType = carType;
            salary = 45000;
        }

        public override double GetBonus()
        {
            return hours * 50;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Кол-во часов: " + hours);
            Console.WriteLine("Машина: " + carType);
            Console.WriteLine();
        }
    }
}
