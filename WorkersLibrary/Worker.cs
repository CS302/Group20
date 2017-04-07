using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersLibrary
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Worker //абстрактный класс
    {
        #region Мои супер-поля
        /// <summary>
        /// Поле: Имя работника
        /// </summary>
        private string name; //поле (перменная принадлежит объекту (worker1.name))
        /// <summary>
        /// Поле: Возраст работника
        /// </summary>
        private int age; //поле
        public int snn; //поле
        public static int count; //поле (переменная, которая принадлежит классу вцелом (Worker.count))
        protected double salary;
        #endregion
        
        #region Свойства
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
        #endregion

        #region Методы
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
        #endregion

        #region Конструкторы
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
        { } 
        #endregion

    }
}
