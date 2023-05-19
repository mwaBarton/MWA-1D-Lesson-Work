using System;

namespace L150___Classes_and_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Classroom myMathsRoom = new Classroom();
            
            myMathsRoom.numOfTeachers = 10;
            myMathsRoom.roomName = "N68";
            Console.WriteLine(myMathsRoom.numOfTeachers);

            Console.WriteLine(myMathsRoom.Talk());

            Console.ReadKey();
        }
    }
}
