using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson10_Threads
{
    class Program
    {
        delegate void BinaryOp(int x, int y);
        static object obj = new object();
        static Queue<int> queue;
        static void Main(string[] args)
        {
            #region Sample
            //BinaryOp binOp = new BinaryOp(Sum);
            //binOp(10, 20);
            //Sum(10, 20);
            //binOp += Sum;
            //binOp += Sum;
            //binOp += Sum;
            //binOp += Mul;

            //binOp(10, 20);
            
            //Action<int, int> action = new Action<int, int>(Sum);
            //action(10, 20);
            //Func<int, int, int> func = new Func<int, int, int>(Mul);
            //Console.WriteLine(func(10, 20)); 
            #endregion

            //Action<int, int> action = new Action<int, int>(GetNumbers);

            //action.BeginInvoke(10, 20, null, null);
            //action.BeginInvoke(-20, -10, null, null);
            //while (Console.ReadLine() != "exit")
            //{   }

            //queue = new Queue<int>();
            //for (int i = 1; i < 100; i++)
            //{
            //    queue.Enqueue(i);
            //}

            //Action<int> action = new Action<int>(CalcQueItem);
            //action.BeginInvoke(1, null, null);
            //action.BeginInvoke(2, null, null);
            
            //Console.ReadLine();

            //int fact = 1;
            //for (int i = 1; i <=3 ; i++)
            //{
            //    fact *= i;
            //}
            //Console.WriteLine(fact);
            Console.WriteLine(Fact(10));
        }

        static int Fact(int x)
        {
            if (x == 0)
                return 1;
            else
                return x * Fact(x - 1);
        }

        static void CalcQueItem(int id)
        {
            while (queue.Count != 0)
            {
                int number;
                Thread.Sleep(10);
                lock (obj)
                {
                    number = queue.Dequeue();
                }
                
                number *= number;
                Console.WriteLine("{0} - {1}", id, number);
            }
        }

        static void GetNumbers(int a, int b)
        {
            for (int i = a; i <= b; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(500);
            }
        }

        static void Sum(int x, int y)
        {
            int sum = 0;
            for (int i = x; i < y; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }

        static int Mul(int x, int y)
        {
            int mul = 1;
            for (int i = x; i < y; i++)
            {
                mul *= i;
            }
            return mul;
        }
    }
}
