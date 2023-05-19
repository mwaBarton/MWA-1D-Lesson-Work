using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L158___Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square mySquare = new Square(10, "Square");
            Console.ReadKey();
        }
    }

    public class Rectangle
    {
        private int width, height;
        public Rectangle(int inWidth, int inHeight)
        {
            width = inWidth;
            height = inHeight;
        }
        public int getArea()
        {
            return width * height;
        }
    }
    public class Square : Rectangle
    {
        private string nickname;
        public Square(int sideLength, string name) : base(sideLength, sideLength)
        {

            nickname = name;
            Console.WriteLine($"Square {nickname} created!");
        }
    }

}
