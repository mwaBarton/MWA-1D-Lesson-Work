using System;

namespace L125___Structures
{
    internal class Program
    {
        struct Student
        {
            public string Name;
            public double Attendance;
        }

        static Student GetBestAttendance(Student s1, Student s2)
        {
            Student bestAttendance;
            if (s1.Attendance > s2.Attendance)
            {
                bestAttendance = s1;
            }
            else
            {
                bestAttendance = s2;
            }
            return bestAttendance;
        }

        static void Main(string[] args)
        {
            Student student1, student2, student3;

            student1.Name = "Victor";
            student1.Attendance = 98.9;
            student2.Name = "Harry";
            student2.Attendance = 90.23;
            student3.Name = "Hafiff";
            student3.Attendance = 99;


            Console.WriteLine($"Best student: {GetBestAttendance(student1, GetBestAttendance(student2, student3)).Name}!");

            Console.ReadKey();
        }
    }
}
