using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkersLibrary;

namespace Lesson8_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList list = new ArrayList();
            //list.Add(new Driver("John", 28, 123456, 256, "BMW"));
            //list.Add(new Driver("Ivan", 38, 456123, 128, "UAZ"));
            //list.Add(new Manager("Hulk", 58, 789456, 15));
            //list.Add(new Manager("Linda", 35, 89621, 10));
            //list.Add(new Manager("Max", 18, 7896412, 8));
            ////Console.WriteLine(list.Count);
            ////list.RemoveAt(3);
            ////(list[3] as Worker).Print();
            ////list.Add("Rabotnik");
            //foreach (object item in list)
            //{
            //    (item as Worker).Print();
            //}

            //List<Worker> list = new List<Worker>();

            //list.Add(new Driver("John", 28, 123456, 256, "BMW"));
            //list.Add(new Driver("Ivan", 38, 456123, 128, "UAZ"));
            //list.Add(new Manager("Hulk", 58, 789456, 15));
            //list.Add(new Manager("Linda", 35, 89621, 10));
            //list.Add(new Manager("Max", 18, 7896412, 8));
            ////Worker[] workers = new Worker[3];
            ////list.AddRange(workers);
            //list.Reverse();
            //list.Insert(2, new Driver("Vasya", 25, 863631, 512, "Audi"));
            //list[0].Print();
            //foreach (Worker item in list)
            //{
            //    item.Print();
            //}

            //Dictionary<string, int> dict = new Dictionary<string, int>();
            //if (!dict.ContainsKey(".exe"))
            //    dict.Add(".exe", 0);
            //dict.Add(".cs", 0);
            //dict.Add(".rb", 0);

            //dict[".rb"] += 1;
            //foreach (KeyValuePair<string, int> item in dict)
            //{
            //    Console.WriteLine(item.Key);
            //    Console.WriteLine(item.Value);
            //}

            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);
            //stack.Push(6);

            //int number = stack.Pop();
            //Console.WriteLine(number);

            //number = stack.Peek();
            //Console.WriteLine(number);
            //number = stack.Peek();
            //Console.WriteLine(number);

            //foreach (int item in stack)
            //{
            //    Console.WriteLine(item);
            //}

            //while (stack.Count != 0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);

            Console.WriteLine(queue.Peek());

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
        }
    }
}
