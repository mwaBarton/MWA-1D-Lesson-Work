using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L150___Classes_and_Objects
{
    internal class Classroom
    {
        public string roomName;
        public int numOfStudents;
        public int numOfTeachers;

        public void IncreaseStudentCapacity()
        {
            numOfStudents++;
        }

        public string Talk()
        {
            return "Hello, I'm a classroom! My name is " + roomName;
        }
    }
}
