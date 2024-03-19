using System.IO;

namespace Course
{
    class Program { 
    
    static void Main(string[] args)
        {
            // Add the path of your file.
            string path = @"C:\Users\guguo\source\repos\Stream\Stream\Text\file1.txt";

            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
        }
    }
}