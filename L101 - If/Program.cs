using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L101___If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask user for their age
            int age;
            Console.Write("Enter age: ");
            age = int.Parse(Console.ReadLine());

            if (age >= 63)
            {
                Console.WriteLine("You're old.");
            } else if (age < 30)
            {
                Console.WriteLine("You're young.");
            } else
            {
                Console.WriteLine("You're middle-aged.");
            }

            Console.WriteLine("bye.");

            Console.ReadKey();
        }
    }
}
