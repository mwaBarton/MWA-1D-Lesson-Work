using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L123___Functions
{
    internal class Program
    {
        static int Name(int param)
        {
            if (param == 0 ) return 0;

            Console.WriteLine(param);

            return param * 2;
        }

        static void Main(string[] args)
        {
            int result;

            result = Name(10);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
