using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L100___Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            age = int.Parse(Console.ReadLine());
            Console.WriteLine(name + " loves C#, it's better than Python!");

            Console.ReadKey();
        }
    }
}
