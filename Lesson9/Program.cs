using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    int number;
                    number = int.Parse(Console.ReadLine());
                    Console.WriteLine(number * number);
                    return;
                }
                catch (FormatException ex1)
                {
                    Console.WriteLine(ex1.Message);
                    Console.WriteLine("Вводить можно только цифры");
                }
                catch (OverflowException ex2)
                {
                    Console.WriteLine(ex2.Message);
                    Console.WriteLine("Число должно соответствовать типу Int32");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Вводить нужно число!");
                    Console.WriteLine("Попробуйте еще раз");
                }
                finally
                {
                    //действия, которые выполнятся в любом случае
                }
            }
        }
    }
}
