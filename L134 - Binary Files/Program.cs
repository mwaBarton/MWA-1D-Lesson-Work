using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace L134___Binary_Files
{
    internal class Program
    {
        struct Lesson
        {
            public string teacherName, room;
            public int numberOfStudents;
        }


        static void Main(string[] args)
        {
            string filename = "myFile.bin";

            // Writing to a binary file
            using (BinaryWriter bw = new BinaryWriter(File.Open(filename, FileMode.OpenOrCreate)))
            {
                bw.Write("Happy New Year");
                bw.Write(5);
                bw.Write(false);
            }


            // Reading from a Binary File
            int myInt = 0; string myString = ""; bool myBool = false;

            using (BinaryReader br = new BinaryReader(File.Open(filename, FileMode.OpenOrCreate)))
            {
                // Reading must happen in the correct order
                myString = br.ReadString();
                myInt = br.ReadInt32();
                myBool = br.ReadBoolean();
                
                
            }

            Console.WriteLine($"{myInt}, {myString}, {myBool}");

            Console.ReadKey();


            // Worksheet task
            string fileName = "MyFile.bin";
            List<Lesson> lessonsToWrite = new List<Lesson>();
            Lesson tempLesson;
            //Populate list of structures


            lessonsToWrite.Add(new Lesson() 
            { 
                numberOfStudents = 23,
                room = "N68",
                teacherName = "Matt"
            });

            lessonsToWrite.Add(new Lesson() 
            { 
                numberOfStudents = 26,
                room = "N54",
                teacherName = "Tim" 
            });

            lessonsToWrite.Add(new Lesson() 
            { 
                numberOfStudents = 24,
                room = "N52",
                teacherName = "Dani" 
            });


            //Write list of structures to file
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.OpenOrCreate)))
            {
                //Write the length of the list. We'll need that later
                writer.Write(lessonsToWrite.Count);
                //Followed by data for each of the structures
                for (int i = 0; i < lessonsToWrite.Count; i++)
                {
                    writer.Write(lessonsToWrite[i].teacherName);
                    writer.Write(lessonsToWrite[i].room);
                    writer.Write(lessonsToWrite[i].numberOfStudents);
                }
            }
            //read list of lessons from file, in the same format as was written
            List<Lesson> lessonsRead = new List<Lesson>();
            using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.OpenOrCreate)))
            {
                //read how many are stored
                int numLessons = reader.ReadInt32();
                for (int i = 0; i < numLessons; i++)
                {
                    //read each one into a separate structure
                    tempLesson.teacherName = reader.ReadString();
                    tempLesson.room = reader.ReadString();
                    tempLesson.numberOfStudents = reader.ReadInt32();
                    lessonsRead.Add(tempLesson);
                }
            }


            foreach (Lesson lesson in lessonsRead)
            {
                Console.WriteLine("Next lesson:");
                Console.WriteLine($"{lesson.teacherName}'s class in {lesson.room} with {lesson.numberOfStudents} student(s).");
            }
            Console.ReadKey();
        }
    }
}
