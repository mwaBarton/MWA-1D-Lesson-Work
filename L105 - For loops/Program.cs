using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L105___For_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("I love Computing!");
            //}


            //string message;
            //Console.Write("Enter message: ");
            //message = Console.ReadLine();

            //int times;
            //Console.Write("times: ");
            //times = int.Parse(Console.ReadLine());

            //for (int i = 0; i < times; i++)
            //{
            //    Console.WriteLine(message);
            //}


            //for (int i = 0; i < 10; i += 1)
            //{
            //    if (i < 5)
            //    {
            //        Console.WriteLine("Less than halfway");
            //    } else
            //    {
            //        Console.WriteLine("More than halfway");
            //    }
            //}


            // Pyramid of stars
            int numRows;
            Console.Write("Enter number of rows: ");
            numRows = int.Parse(Console.ReadLine());

            for (int i = 0; i < numRows; i++)
            {
                // Print (numRows - i - 1) spaces
                for (int j = 0; j < numRows - i - 1; j++)
                {
                    Console.Write(" ");
                }

                // Print (2 * (i + 1)) stars
                for (int j = 0; j < 2 * (i + 1); j++)
                {
                    Console.Write("*");
                }

                // Go onto the next line, ready for the next row
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
