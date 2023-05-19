using System;
using System.IO;

namespace L125___Reading_Text_Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filename = "TheTextFile.txt";

            // THE PROPER WAY (ONE LINE AT A TIME)
            using (StreamReader words = new StreamReader(filename))
            {
                string line;
                while (!words.EndOfStream)
                {
                    line = words.ReadLine();
                    Console.WriteLine($"[{line.Length}] - {line}");
                }
            }
            // END OF THE PROPER WAY

            // THE EASY WAY (FOR THE WEAK)
            string contents = File.ReadAllText(filename);
            Console.WriteLine(contents);

            Console.ReadKey();
        }
    }
}
