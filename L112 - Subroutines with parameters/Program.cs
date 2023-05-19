using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L112___Subroutines_with_parameters
{
    internal class Program
    {
        static void Colour(string colour, string message)
        {
            switch (colour.ToLower())
            {
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "white":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "yellow":  
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
            }

            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            Colour("red", "I like red.");
            Colour("yellow", "I like red.");

            Console.ReadKey();
        }
    }
}
