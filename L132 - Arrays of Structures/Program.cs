using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L132___Arrays_of_Structures
{
    struct Train
    {
        public string colour;
        public int age;
        public int numberOfSeats;
    }
    internal class Program
    {
        static void PrintStation(Train[] S)
        {
            for (int i = 0; i < S.Length; i++)
            {
                Console.WriteLine($"Train {i + 1}: age = {S[i].age}, colour = {S[i].colour}, seats = {S[i].numberOfSeats}");
            }
        }
        static void Main(string[] args)
        {
            Train myFavouriteTrain;
            myFavouriteTrain.age = 11;
            myFavouriteTrain.colour = "Bright Green";
            myFavouriteTrain.numberOfSeats = -8000;

            Train yourLeastFavouriteTrain = new Train() { age = 11, colour = "Red", numberOfSeats = 5 };
            Train[] station = new Train[] { 
                myFavouriteTrain, 
                yourLeastFavouriteTrain, 
                new Train() { age = 0, colour = "Blue", numberOfSeats = 100 } 
            };

            PrintStation(station);

            Console.ReadKey();
        }
    }
}
