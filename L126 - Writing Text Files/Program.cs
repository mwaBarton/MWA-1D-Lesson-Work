using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace L126___Writing_Text_Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filename = "TheFile.txt";

            // The easy way (for the weak)
            //File.WriteAllText(filename, "Hello there");

            // The proper way (for the true text file nerd)
            using (StreamWriter sw = new StreamWriter(filename, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine($"This is line number {i + 1}.");
                }

                sw.WriteLine("Another line");
            }
        }
    }
}
