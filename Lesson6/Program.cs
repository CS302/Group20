using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "\a";
//            text = "первая\nвторая";
//            text = "первая\r123";
//            //Console.WriteLine(text);

//            //string[] symbols = new string[] { "\\", "/", "|", "-" };
//            //for (int i = 0; i < 1000; i++)
//            //{
//            //    Console.Write(symbols[i % 4] + "\r");
//            //    Thread.Sleep(200); //приостанавливает программу на 200 мс
//            //}

//            Console.WriteLine("наши занятия \"легкие\"");
//            char s = '\'';

//            string path1 = "C:\\Lesson6\\1.txt";
//            //string path2 = Console.ReadLine();
//            path1 = @"C:\Lesson6\Test\2.txt";
//            path1 = @"первая строка
//вторая строка
//                    третья строка";
//            Console.WriteLine(path1);

            //text = "Простая строка";
            //Console.WriteLine(text.Length);
            //Console.WriteLine(text[text.Length - 1]);

            //Console.WriteLine(text.CompareTo("Сложная строка"));

            //Console.WriteLine(text.Contains("стр"));
            //text = text.Insert(0, "Это ");
            //Console.WriteLine(text.Insert(0, "Это "));

            //Console.WriteLine(text.Remove(8, 3));

            //Console.WriteLine(text.Replace("Простая", "Сложная"));
            if (text.Contains("тся") || text.Contains("ться"))
            {
                
            }
            //string data = "561 684 321 987 321 145";
            //string[] items = data.Split(' ');
            //int sum = 0;
            //for (int i = 0; i < items.Length; i++)
            //{
            //    sum += int.Parse(items[i]);
            //}
            //Console.WriteLine(sum);
            //Console.WriteLine(text.ToLower());
            //Console.WriteLine(text.ToUpper());
            //string username = "user123 ";
            //username = username.Trim(' ');


            //int n = 1000000;
            //StringBuilder data = new StringBuilder();

            //Console.WriteLine(data.MaxCapacity);
            //for (int i = 0; i < n; i++)
            //{
            //    data.Append(i);
            //}
            //Console.WriteLine(data.Length);

            //int x = 100;
            //int y = 150;
            //Console.WriteLine("X = " + x + " Y = " + y);
            //Console.WriteLine("X = {0}\nY={1}\nЕще разок X = {0}", x, y);
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //double price = 99.9999;
            //Console.WriteLine("Цена = {0}", price);

            //Console.WriteLine("Цена = {0:e}", price); //science
            //Console.WriteLine("Цена = {0:c}", price); //commercial
            //Console.WriteLine("Цена = {0:.##}", price);
            //Console.WriteLine();

            //DateTime date = DateTime.Now;
            //Console.WriteLine("{0:hh:mm}", date);
            //Console.WriteLine("{0:dd.MM.yy hh:mm}", date);
            //Console.WriteLine("{0:dd MMM yyyy hh:mm}", date);
            
            Point p = new Point(123.789456, 45.846513);
            //string str = p.ToString();
            Console.WriteLine("{0:e}", p);
            //[1.23789456e+002]
            Console.WriteLine("{0:ij}", p);
            //(123.78i; 45.84j)
            /*
             * string str = "Мы сегодня программировали и планируем продолжить это занятие.";
             * 
             */
        }
    }

    class Point : IFormattable
    {
        double x;
        double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return string.Format("X = {0}\nY = {1}", x, y);
        }

        public void Print()
        {
            Console.WriteLine("X = {0}\nY = {1}", x, y);
        }



        public string ToString(string format, IFormatProvider formatProvider)
        {
            switch (format)
            {
                case "e":
                    return string.Format("[{0:e} ; {1:e}]", x, y);
                case "ij":
                    return string.Format("({0:.##}i ; {1:.##}j)", x, y);
                default:
                    return ToString();
            }
        }
    }
}
