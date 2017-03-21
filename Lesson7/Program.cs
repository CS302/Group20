using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] files = Directory.GetFiles(@"C:\Users\Alex-Vaio\Documents\GitHub", "*m.cs", SearchOption.AllDirectories);
            //for (int i = 0; i < files.Length; i++)
            //{
            //    Console.WriteLine(files[i]);
            //}

            //DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Alex-Vaio\Documents\GitHub");
            //FileInfo[] files = dir.GetFiles("*.exe", SearchOption.AllDirectories);
            //for (int i = 0; i < files.Length; i++)
            //{
            //    Console.WriteLine(files[i].FullName);
            //    Console.WriteLine(files[i].CreationTime);
            //    Console.WriteLine(files[i].Length);
            //    Console.WriteLine(files[i].Extension);
            //    Console.WriteLine(files[i].Name);
            //    Console.WriteLine();
            //}

            FileInfo file1 = new FileInfo(@"C:\Lesson6\1.txt");
            FileInfo file2 = new FileInfo(@"C:\Lesson6\Test\2.txt");

            file1.Create();

            if (!file2.Directory.Exists)
            {
                file2.Directory.Create();
            }
            file2.Create();

            Directory.CreateDirectory(@"C:\Lesson6\Test\1\2\3\4\5\6\7\8\9");
            
            string path = @"C:\Lesson6\Test\1\2\3\123.txt";
            Console.WriteLine(Path.GetFileName(path));
            Console.WriteLine(Path.GetFileNameWithoutExtension(path));
            Console.WriteLine(Path.GetDirectoryName(path));
            Console.WriteLine(Path.GetExtension(path));

            string dir = @"C:\Lesson6\Test\1\2\3";
            string temp = "temp_24";
            string fileName = "data.txt";

            string path1 = dir + "\\" + temp + "\\" + fileName;
            path1 = String.Format(@"{0}\{1}\{2}", dir, temp, fileName);
            path1 = Path.Combine(dir, temp, fileName);
            Console.WriteLine(path1);
        }
    }
}
