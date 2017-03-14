using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    /*
     * Класс "Квадрат"
     * Поля: L, (x,y), colour
     * Конструктор
     * Методы: площадь, периметр.
     * 
     * Класс "Круг"
     * Поля: R, (x,y), colour
     * Конструктор
     * Методы: площадь, и длина окружности.
     * 
     * Main - случайным образом создать несколько квадратов и кругов.
     * Подсчитать - сколько всего фигур.
     */

    class Program
    {
        static void Main(string[] args)
        {
            Worker[] workers = new Worker[3];
            workers[0] = new Driver("John", 45, 98653, 256, "Audi");
            workers[1] = new Manager("Ivan", 29, 495346, 5);
            workers[2] = new Manager("Hulk", 59, 9798653, 15);

            
            Worker.PrintWorkers(workers);

            
        }
       
    }

    abstract class Worker //абстрактный класс
    {
        private string name; //поле (перменная принадлежит объекту (worker1.name))
        private int age; //поле
        public int snn; //поле
        public static int count; //поле (переменная, которая принадлежит классу вцелом (Worker.count))
        protected double salary;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public int Age //свойство 
        {
            set 
            {
                if ((value >= 16) && (value < 65))
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Значение возраста недопустимо.");
                }
            }
            get 
            { 
                return age; 
            }
        }

        public void SetAge(int age)
        {
            if ((age >= 16) && (age < 65))
            {
                this.age = age;
            }
            else
            {
                Console.WriteLine("Значение возраста недопустимо.");
            }
        }
        public int GetAge()
        {
            return age;
        }

        public abstract double GetBonus();
        
        public virtual void Print()
        {
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Возраст: " + age);
            Console.WriteLine("ИНН: " + snn);
            Console.WriteLine("Зарплата: " + salary);
        }

        public static void PrintWorkers(Worker[] workers)
        {
            for (int i = 0; i < workers.Length; i++)
            {
                workers[i].Print();
                Console.WriteLine();
            }
        }

        static Worker() //правило хорошего стиля
        {
            count = 0; //инициализация статичных полей класса
        }

        public Worker(string name, int age, int snn) //основной конструктор
        {
            this.name = name; //this указывает на член класса
            Age = age; //передаем значение свойству, чтобы выполнились проверки
            this.snn = snn;
            this.salary = 30000;
            count = count + 1;
        }

        public Worker(string name, int age) //второстепенный конструктор
            : this(name, age, 0)
        {   }
    }

    sealed class Driver : Worker // запечатанный/стерильный
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

    class Manager : Worker
    {
        public int projCount;

        public Manager(string name, int age, int snn, int projCount)
            : base(name, age, snn)
        {
            this.projCount = projCount;
            this.salary = 50000;
        }

        public override double GetBonus()
        {
            return projCount * 1000;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Кол-во проектов: " + projCount);
            Console.WriteLine();
        }
    }

    //class SuperDriver : Driver //- наследование запрещено
    //{ }
}
