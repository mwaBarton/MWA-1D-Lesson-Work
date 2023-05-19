using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Call_stack_code
{
    class Program
    {

        static void printList(List<int> L)
        {
            Console.Write("[");
            for (int i = 0; i < L.Count; i++)
            {
                Console.Write(L[i]);
                if (i < L.Count - 1) Console.Write(", ");
            }
            Console.WriteLine("]");
        }

        static void printList(List<string> L)
        {
            Console.Write("[");
            for (int i = 0; i < L.Count; i++)
            {
                Console.Write(L[i]);
                if (i < L.Count - 1) Console.Write(", ");
            }
            Console.WriteLine("]");
        }

        static void ArrayToList()
        {
            int[] myArray = { 1, 2, 3, 4, 5 };
            List<int> myList = new List<int>();

            foreach (int item in myArray)
            {
                myList.Add(item);
            }

            printList(myList);
        }

        static void ListToArray()
        {
            List<int> myList = new List<int>() { 3, 24, 13, 64, 57 };

            int[] myarray = new int[myList.Count];
            for (int i = 0; i < myList.Count; i++)
            {
                myarray[i] = myList[i];
            }

            foreach (int item in myarray)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
        
        static void RemoveDuplicates()
        {
            List<string> names = new List<string>();
            string input;
            do
            {
                Console.Write("Enter next name, or \"done\" to stop: ");
                input = Console.ReadLine();
                if (input != "done" && !names.Contains(input)) names.Add(input);
            } while (input != "done");

            printList(names);
        }

        static void SplitStringIntoList()
        {
            Console.Write("Enter names separated by spaces: ");
            string input = Console.ReadLine();
            string[] myArray = input.Split(' ');

            List<string> myList = new List<string>();

            foreach (string item in myArray)
            {
                myList.Add(item);
            }

            printList(myList);
        }

        static void Main()
        {
            ArrayToList(); // Q2(a)

            ListToArray(); // Q2(b)

            //RemoveDuplicates(); // Q3

            SplitStringIntoList(); // Q4

            Console.ReadKey();
        }
    }
}
