using System;

namespace Group20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //qwerty

            int number = 15;
            number = 10; //инициализация
            Console.WriteLine(number);
            number = 100;
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine();

            number = 10 * (64513 + 64);
            number = 10 - number;
            Console.WriteLine(number);

            number = 56 / 10; //5 целая часть
            number = 56 % 10; //6 остаток от деления
            Console.WriteLine(number);

            Console.WriteLine("*************");
            number = 56;
            //56 --> 56.0 
            double price = (double)number / 10;
            Console.WriteLine(price);
            
            string text = "34253646";
            int number2 = int.Parse(text);
            number2 = number2 + 1;
            Console.WriteLine(number2);

            char symbol = 'A';
            Console.WriteLine("a" + "b" + "c");

            Console.WriteLine('a' + 'b' + 'c');
            Console.WriteLine((int)'a');
            Console.WriteLine((char)97);
            Console.WriteLine((int)'0');

            Console.WriteLine("**********");

            bool flag = true;
            Console.WriteLine(flag);

            flag = true || false; //или. or. V
            flag = true && false; //и, and, /\
            Console.WriteLine(!flag);

            int number3 = 10;
            number3 = -number3;
            Console.WriteLine(number3);
            
            number3 = 5;
            number3--; // аналогично number3 = number3 - 1;
            number3 *= 2; // аналогично number3 = number3 * 2;
            Console.WriteLine(number3);

            DateTime date = new DateTime(2017, 2, 21, 19, 54, 00);
            date = DateTime.Now;
            Console.WriteLine(date);
            //TimeSpan span = date - DateTime.Now;

            //string inp = Console.ReadLine();
            //int day1 = int.Parse(inp); //21
            string inp = Console.ReadLine();
            DateTime date1 = DateTime.Parse(inp);

            int x = 100;
            double y = 56.5555;
            string s = "qwerty";

            Console.WriteLine("X = " + x + " " + y +" "+ s);
            
        }
    }
}
