using System;
using System.IO;
using System.Threading;

namespace Read
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = Path.Combine(Path.GetFullPath(Path.Combine($"{AppDomain.CurrentDomain.BaseDirectory}", "..\\..\\..\\..")), "files\\out.json");

            using (var file = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                while (true)
                {
                    var reader = new StreamReader(file);
                    var line = reader.ReadLine();
                    Console.WriteLine(line);
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
