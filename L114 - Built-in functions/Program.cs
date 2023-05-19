using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L114___Built_in_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Matt";

            // Characters from strings
            char c = name[0];
            Console.WriteLine(c.ToString() + name[3].ToString());

            // Length of a string
            int num = name.Length;
            Console.WriteLine($"Length: {num}");
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(name[i]);
            }

            // Cases
            Console.WriteLine("Upper: " + name.ToUpper());
            Console.WriteLine("Lower: " + name.ToLower());

            // Substrings
            string sub;
            sub = name.Substring(2, 2);
            Console.WriteLine("Substring: " + sub);

            // Finding index of the first occurrence of
            // a substring
            int index;
            index = name.IndexOf("t");
            Console.WriteLine("Index of t: " + index);
            index = name.IndexOf("cat");
            Console.WriteLine("Index of cat: " + index);

            Console.ReadKey();
        }
    }
}
