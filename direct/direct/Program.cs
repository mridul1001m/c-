using System;
using System.IO;

class FileManager
{
    static void Main()
    {
        Console.Write("Enter the directory path: ");
        string path = Console.ReadLine();

        if (Directory.Exists(path))
        {
            string[] files = Directory.GetFiles(path);

            Console.WriteLine($"\nFiles in directory '{path}':");
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
        }
        else
        {
            Console.WriteLine("The specified directory does not exist.");
        }
    }
}
