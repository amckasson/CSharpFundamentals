using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges
{
    public enum CourseTaught { Cyber_Security, Software_Development, Web_Development }
    public class TeacherClass
    {
        public TeacherClass(int empolyeeId)
        {
            IdNumber = empolyeeId;
        }
        public TeacherClass(string firstName, string lastName, DateTime birthDate, CourseTaught teachCourse, int empolyeeId)
        {
            FName = firstName;
            LName = lastName;
            Birthday = birthDate;
            CourseTeach = teachCourse;
            IdNumber = empolyeeId;

        }

        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime Birthday { get; set; }
        public CourseTaught CourseTeach { get; set; }
        public int IdNumber { get; }

    }
}
