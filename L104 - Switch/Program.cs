using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L104___Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string faveDay;
            Console.Write("What is your favourite day of the week? ");
            faveDay = Console.ReadLine();

            switch (faveDay.ToLower())
            {
                case "monday":
                    Console.WriteLine("Are you mad?? I hate Mondays.");
                    break;
                case "tuesday":
                case "wednesday":
                case "thursday":
                case "sunday":
                    Console.WriteLine("Interesting...");
                    break;
                case "friday":
                    Console.WriteLine("Almost the weekend!");
                    break;
                default:
                    Console.WriteLine($"Are you sure {faveDay} is a day?");
                    break;
            }

            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 0:
                    break;
                case 3:
                    break;
            }




            Console.ReadKey();
        }
    }
}
