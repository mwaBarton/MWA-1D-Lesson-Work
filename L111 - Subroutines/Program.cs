using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L111___Subroutines
{
    internal class Program
    {
        static int numOfLemons = 5; // Global variable

        static void Joe()
        {
            numOfLemons += 1;
            Console.WriteLine("This is Joe. Hi!");
        }

        static void Fruit()
        {
            Console.WriteLine($"Have {numOfLemons} lemons!");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome.");
            Joe();
            Fruit();
            Joe();
            Fruit();
            

            Console.ReadKey();
        }
    }
}
