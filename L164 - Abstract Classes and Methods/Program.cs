using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L164___Abstract_Classes_and_Methods
{

    public abstract class Shape
    {
        public abstract double GetArea();

        public string DoIt()
        {
            return "hi";
        }
    }
    public class Square : Shape
    {
        private double width;

        public Square(double inWidth)
        {
            width = inWidth;
        }
        public override double GetArea()
        {
            return width * width;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Square(5);

            Console.WriteLine(s.GetArea());

            Console.ReadKey();
        }
    }
}
