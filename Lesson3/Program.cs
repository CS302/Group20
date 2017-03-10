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
            workers[0] = new Worker("John", 27, 6845643);
            workers[1] = new Worker("Ivan", 37, 6843597);
            workers[2] = new Worker("Hulk", 50);

            Worker.PrintWorkers(workers);

            Console.WriteLine(Worker.count);
            
        }

        
    }

    class Worker //объектный класс
    {
        private string name; //поле (перменная принадлежит объекту (worker1.name))
        private int age; //поле
        public int snn; //поле
        public static int count; //поле (переменная, которая принадлежит классу вцелом (Worker.count))

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
        
        public void Print()
        {
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Возраст: " + age);
            Console.WriteLine("ИНН: " + snn);
            Console.WriteLine();
        }

        public static void PrintWorkers(Worker[] workers)
        {
            for (int i = 0; i < workers.Length; i++)
            {
                workers[i].Print();
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
            count = count + 1;
        }

        public Worker(string name, int age) //второстепенный конструктор
            : this(name, age, 0)
        {   }
    }
}
