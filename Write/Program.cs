using System;
using System.IO;
using System.Threading;

namespace Write
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = Path.Combine(Path.GetFullPath(Path.Combine($"{AppDomain.CurrentDomain.BaseDirectory}", "..\\..\\..\\..")), "files\\out.json");
            
            using (var file = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read))
            {
                while (true)
                {
                    var writer = new StreamWriter(file);
                    writer.WriteLine(DateTime.Now.ToLongTimeString());
                    writer.Flush();
                    Thread.Sleep(500);
                }
            }
        }
    }
}
