using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson7_files
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point p = new Point(15.45, 23.789, "Point1");
            //p.Print();
            //SavePoint(p);

            Point p = ReadPoint();
            p.Print();


        }

        private static Point ReadPoint()
        {
            FileStream stream = new FileStream("Point.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            //string path = Environment.CurrentDirectory;
            //C:\Lesson7\myProj
            //считывает все в одну строку
            //string str = reader.ReadToEnd();

            //цикл - пока не достигнут конец файла
            //считываем из него по одной строке
            //while (!reader.EndOfStream)
            //{
            //    string str = reader.ReadLine();
            //}
            
            
            double x = double.Parse(reader.ReadLine());
            double y = double.Parse(reader.ReadLine());
            string label = reader.ReadLine();

            reader.Close();

            Point p = new Point(x, y, label);
            
            return p;
        }

        private static void SavePoint(Point p)
        {
            FileStream stream = new FileStream("Point.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine(p.x);
            writer.WriteLine(p.y);
            writer.WriteLine(p.label);

            writer.Close();
        }
    }

    class Point
    {
        public double x;
        public double y;
        public string label;

        public Point(double x, double y, string label)
        {
            this.x = x;
            this.y = y;
            this.label = label;
        }

        public void Print()
        {
            Console.WriteLine("X = {0}\nY = {1}\nLabel - {2}", x, y, label);
        }
    }
}
