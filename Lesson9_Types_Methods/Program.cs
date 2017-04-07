using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_Types_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //var number = 100;//Int32
            //var text = "string";
            
            //var x = GetNumber();
            //x = "string";

            //dynamic number = 10;
            //number += 100;
            //number = "string";
            //number += 10;
            //Console.WriteLine(number);

            //int a = 10;
            //int b = 15;
            //Switch(ref a, ref b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            
            //1 2 3 4 5
            //1 2 3 4 5 1 2 3 4 5

            /*
             * 1 2
             * 3 4
             * 
             * 1 2 1 2
             * 3 4 3 4
             * 1 2 1 2
             * 3 4 3 4
             */
            //int number;
            //bool flag = int.TryParse(Console.ReadLine(), out number);
            //if (flag == true)
            //{
            //    Console.WriteLine(number * number);                
            //}
            //else
            //{
            //    Console.WriteLine("Error");

            //int x = int.Parse(Console.ReadLine());
            //}
        }

        static void Switch(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static int GetNumber()
        {
            return 100;
        }
    }
}
