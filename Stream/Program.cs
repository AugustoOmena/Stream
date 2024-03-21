using System;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string sourceDirectory = Path.Combine(projectDirectory, "Arquivos1");
            string destinationDirectory = Path.Combine(projectDirectory, "Arquivos2");

            try
            {
                if (!Directory.Exists(destinationDirectory))
                {
                    Directory.CreateDirectory(destinationDirectory);
                }

                string[] files = Directory.GetFiles(sourceDirectory);

                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    string destinationPath = Path.Combine(destinationDirectory, fileName);
                    File.Copy(file, destinationPath, true);
                    Console.WriteLine($"Arquivo '{fileName}' copiado com sucesso.");
                }
            } catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro ao copiar os arquivos.");
                Console.WriteLine(e.Message);
            }
        }
    }
}
