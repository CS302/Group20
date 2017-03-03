using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = DoSmth(10, 15);
            //int y = DoSmth(30, 45);
            //Console.WriteLine("X = " + x + " Y = " + y);
            //Console.WriteLine(DoSmth(x, y));
            //DoSmth(12.5, 8); - ошибка компиляции

            //int number = 10;

            //int[] numbers = new int[5];

            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;
            //numbers[3] = 4;
            //numbers[4] = 5;

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);
            //Console.WriteLine(numbers[3]);
            //Console.WriteLine(numbers[4]);
            //Console.WriteLine("---------");
            //Console.WriteLine(numbers.Length); //свойство
            //Console.WriteLine(numbers.GetLength(0));
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();


            //int[,] table = new int[2, 3]; //2 строки, 3 столбца
            //table[0, 0] = 1;
            //table[0, 1] = 2;
            //table[0, 2] = 3;
            //table[1, 0] = 4;
            //table[1, 1] = 5;
            //table[1, 2] = 6;

            //Console.WriteLine(table[0, 0] + " " + table[0, 1] + " " + table[0, 2]);
            //Console.WriteLine(table[1, 0] + " " + table[1, 1] + " " + table[1, 2]);
            //Console.WriteLine("-------");
            //Console.WriteLine(table.Length);
            //Console.WriteLine(table.GetLength(0));
            //Console.WriteLine(table.GetLength(1));


            //int[] vec1 = new int[2] { 5, 5 };
            //int[] vec2 = new int[2] { 9, 9 };
            //Console.WriteLine(vec1[0] + " " + vec1[1]);
            //Console.WriteLine(vec2[0] + " " + vec2[1]);
            //Console.WriteLine("---------------------");

            //vec1 = vec2;
            //Console.WriteLine(vec1[0] + " " + vec1[1]);
            //Console.WriteLine(vec2[0] + " " + vec2[1]);
            //Console.WriteLine("---------------------");

            //vec2[0] = 100;
            //vec2[1] = 100;
            //Console.WriteLine(vec1[0] + " " + vec1[1]);
            //Console.WriteLine(vec2[0] + " " + vec2[1]);
            //Console.WriteLine("---------------------");

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //int a = 5;
            //int b = 9;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine("---");

            //a = b;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine("---");

            //b = 100;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine("---");

            string comand = Console.ReadLine();
            //if (comand == "exit")
            //{
            //    Console.WriteLine("Работа завершена");
            //}
            //else
            //{
            //    Console.WriteLine("Выполняется работа");
            //}

            //switch (comand)
            //{
            //    case "exit":
            //        Console.WriteLine("Работа завершена");
            //        break;
            //    case "option1":
            //        Console.WriteLine("Опция 1");
            //        break;
            //    case "option2":
            //    case "option3":
            //    case "option4":
            //        Console.WriteLine("Еще что-то");
            //        break;
            //    default:
            //        Console.WriteLine("Не верное значение");
            //        break;
            //}

            for (int i = 0; i <= 10; i+=2)
            {
                //if (i % 2 == 0)
                //{
                    Console.WriteLine(i);
                //}
                
            }
            Console.WriteLine();


            int[] vec = new int[5] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < vec.GetLength(0); i++)
            {
                Console.WriteLine(vec[i]);
            }

            int[,] table = new int[2, 3]; //2 строки, 3 столбца
            table[0, 0] = 1;
            table[0, 1] = 2;
            table[0, 2] = 3;
            table[1, 0] = 4;
            table[1, 1] = 5;
            table[1, 2] = 6;
            int x = Math.Abs(-15);
            double y = Math.Pow(2, 10);// 2^10=1024
            int num = int.Parse(Console.ReadLine());
            //github.com/cs302/Group20

            int[,] tab = new int[3, 4];
            Random rnd = new Random();
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    table[i, j] = rnd.Next(1, 101);//[1, 100]
                }
                Console.WriteLine();
            }

            //string text = Console.ReadLine();
            //while (text != "exit")
            //{
            //    Console.WriteLine("Приложение работает");
            //    text = Console.ReadLine();
            //}

            string text;
            do
            {
                Console.WriteLine("Приложение работает");
                text = Console.ReadLine();
            } while (text != "exit");

        }

        static int DoSmth(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
    }
}
