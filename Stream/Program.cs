using System.IO;

namespace Course
{
    class Program { 
    
    static void Main(string[] args)
        {
            // Add the path of your file.
            string path = @"C:\Users\guguo\source\repos\Stream\Stream\NovaPasta\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (fs != null) fs.Close();
                if (sr != null) sr.Close();
            }
        }
    }
}