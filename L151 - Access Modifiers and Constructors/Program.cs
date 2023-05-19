using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L151___Access_Modifiers_and_Constructors
{

    public class Film
    {
        private string title;

        public Film()
        {
            title = "Pacific Rim";
        }

        public Film(string filmTitle)
        {
            title = filmTitle;
            Console.WriteLine("Congratulations - you made a film!");
        }

        public string GetTitle()
        {
            return title;
        }
    }


    internal class Program
    {

        static void Main(string[] args)
        {

            Film film = new Film();
            Console.WriteLine($"Title: {film.GetTitle()}");

            Film film2 = new Film("Doom");
            Console.WriteLine($"Title: {film2.GetTitle()}");

            Console.ReadKey();

        }
    }
}
