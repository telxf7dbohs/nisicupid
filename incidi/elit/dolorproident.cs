using System;
using System.IO;
using System.Text;

namespace FileOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "example.txt";

            // Check if the file exists
            if (File.Exists(filePath))
            {
                // Read the content of the file
                string content = ReadFile(filePath);
                Console.WriteLine("Original Content:");
                Console.WriteLine(content);

                // Modify the content
                string modifiedContent = content.ToUpperInvariant();

                // Write the modified content to a new file
                string newFilePath = "modified_example.txt";
                WriteFile(newFilePath, modifiedContent);
                Console.WriteLine($"Modified content written to {newFilePath}");
            }
            else
            {
                Console.WriteLine($"The file {filePath} does not exist.");
            }
        }

        // Method to read the content of a file
        static string ReadFile(string filePath)
        {
            return File.ReadAllText(filePath, Encoding.UTF8);
        }

        // Method to write content to a file
        static void WriteFile(string filePath, string content)
        {
            File.WriteAllText(filePath, content, Encoding.UTF8);
        }
    }
}
