using System.IO;

namespace Course
{
    class Program { 
    
    static void Main(string[] args)
        {
            // Add the path of your file.
            string path = @"C:\Users\guguo\source\repos\Stream\Stream\NovaPasta\file1.txt";

            StreamReader sr = null;
            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }
        }
    }
}