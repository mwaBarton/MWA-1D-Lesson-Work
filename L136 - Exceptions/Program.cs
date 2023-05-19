using System;

namespace L136___Exceptions
{
    internal class Program
    {
        static char gradeCalculator(int scorePercentage)
        {
            if ((scorePercentage < 0) || (scorePercentage > 100))
            {
                throw new ArgumentOutOfRangeException("scorePercentage", "You must enter a number between 0 and 100.");
            }

            if (scorePercentage >= 80)
            {
                return 'A';
            }
            else if (scorePercentage >= 70)
            {
                return 'B';
            }
            else if (scorePercentage >= 60)
            {
                return 'C';
            }
            else if (scorePercentage >= 0)
            {
                return 'U';
            }

            return 'X';
        }


        static void Main(string[] args)
        {
            int score = 0;
            bool success = false;

            while (!success)
            {
                try
                {
                    Console.Write("Enter a score: ");
                    score = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Grade: {gradeCalculator(score)}");

                    success = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Invalid input.");
                    Console.WriteLine(e.Message);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("An unknown error has occurred");
                    Console.WriteLine(e.Message);
                }

            }

            

            Console.ReadKey();
        }
    }
}
