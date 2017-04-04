using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_Lorry
{
    class Program
    {
        static void Main(string[] args)
        {
            Lorry lorry1 = new Lorry(100);
            try
            {
                lorry1.Add(new Book(50, "Война и Мир"));
                lorry1.Add(new Disc(5, "Windows 8.1"));
                lorry1.Add(new Book(55, "Властелин колец"));
            }
            catch (OverflowGoodsException ex)
            {
                Console.WriteLine(ex.Message);
                ex.good.Print();
            }
            

            for (int i = 0; i < lorry1.Count; i++)
            {
                lorry1[i].Print();
            }
        }
    }

    class Lorry
    {
        private int maxWeight;
        private int weight;
        private List<Good> items;
        public int Count
        {
            get { return items.Count; }
        }
        //индексатор
        public Good this[int i]
        {
            get { return items[i]; }
        }

        public Lorry(int maxWeight)
        {
            this.maxWeight = maxWeight;
            items = new List<Good>();
        }

        public void Add(Good good)
        {
            if (good.weight + weight > maxWeight)
            {
                OverflowGoodsException ex = new OverflowGoodsException("На данный товар места нет");
                ex.good = good;
                throw ex;
            }
            items.Add(good);
            weight += good.weight;
            Console.WriteLine("Товар добавлен.");
        }

        public void RemoveAt(int index)
        {
            if ((items.Count != 0) && (index >= 0) && (index < items.Count))
            {
                weight -= items[index].weight;
                items.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Неправильно введен индекс.");
            }
        }
    }

    public abstract class Good
    {
        public int weight;
        protected string name;
        public Good(int weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }
        public abstract void Print();
    }

    class Book : Good
    {
        public override void Print()
        {
            Console.WriteLine("Книга - {0}\nМасса = {1}", name, weight);
        }

        public Book(int weight, string name)
            : base(weight, name)
        {

        }
    }

    class Disc : Good
    {
        public override void Print()
        {
            Console.WriteLine("Диск - {0}\nМасса = {1}", name, weight);
        }
        public Disc(int weight, string name)
            : base(weight, name)
        {

        }
    }

    [Serializable]
    public class OverflowGoodsException : Exception
    {
        public Good good;
        public OverflowGoodsException() { }
        public OverflowGoodsException(string message) : base(message) { }
        public OverflowGoodsException(string message, Exception inner) : base(message, inner) { }
        protected OverflowGoodsException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
