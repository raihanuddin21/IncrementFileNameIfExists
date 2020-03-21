using System;
using System.IO;

namespace IncrementFileNameIfExists
{
    class Program
    {
        static void Main(string[] args)
        {
            string originalFileName = "TestFile";
            string generatedFileName;

            int count = 1;
            do
            {
                generatedFileName = $"{originalFileName}({count}).txt";
                count++;
            } while (File.Exists(generatedFileName));

            //Add your logic here
            File.Create(generatedFileName);

            Console.WriteLine($"{generatedFileName} created successfully!!!");
            Console.ReadLine();
        }
    }
}
