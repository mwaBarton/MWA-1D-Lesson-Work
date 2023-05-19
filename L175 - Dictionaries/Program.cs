using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L175___Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> wordCounts = new Dictionary<string, int>();

            Console.Write("Enter string: ");
            string input = Console.ReadLine();

            string[] words = input.Split(' ');

            foreach (string word in words)
            {
                if (wordCounts.ContainsKey(word))
                {
                    wordCounts[word]++;
                }
                else
                {
                    wordCounts.Add(word, 1);
                }
            }

            foreach (string word in wordCounts.Keys)
            {
                Console.WriteLine($"{word} : {wordCounts[word]}");
            }

            Console.ReadKey();
        }
    }
}
