using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows";
            ShowLargeFilesWithoutLinq(path);
            Console.WriteLine("**********");
            ShowLargeFilesWithLinq(path);
            Console.WriteLine("**********");
            ShowLargeFilesWithLinqMethods(path);
        }

        private static void ShowLargeFilesWithLinq(string path)
        {
            var query = from file in new DirectoryInfo(path).GetFiles()
                        orderby file.Length descending
                        select file;

            foreach (var file in query.Take(5))
            {
                Console.WriteLine($"{file.Name,-20} : {file.Length,10:N0}");
            }
        }

        private static void ShowLargeFilesWithLinqMethods(string path)
        {
            var query = new DirectoryInfo(path).GetFiles()
                       .OrderByDescending(c => c.Length)
                       .Take(5);

            foreach (var file in query)
            {
                Console.WriteLine($"{file.Name,-20} : {file.Length,10:N0}");
            }
        }

        private static void ShowLargeFilesWithoutLinq(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            directory.GetFiles();

            FileInfo[] files = directory.GetFiles();
            Array.Sort(files, new FileInfoComparer());

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{files[i].Name,-20} : {files[i].Length, 10:N0}");
            }
        }
    }
}
