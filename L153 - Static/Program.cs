using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L153___Static
{


    internal class Program
    {
        static int myVariable = 0;
        static void Main(string[] args)
        {
            Globals g = new Globals();
            Globals.theThing = 5;

            Console.WriteLine(Globals.theThing);

            Console.ReadKey();
        }
    }
}
