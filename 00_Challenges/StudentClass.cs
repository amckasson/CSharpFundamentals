using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges
{
    public enum BadgeType { White, Gold, Blue, Red}
    public enum CourseType { Cyber_Security, Software_Development, Web_Development  }
    public class StudentClass
    {
        public StudentClass() { }

        public StudentClass(string firstName, string lastName, bool hasGraduated, DateTime birthDate, decimal balancedOwed, BadgeType typeOfBadge, CourseType classTaking)
        {
            FName = firstName;
            LName = lastName;
            Birthday = birthDate;
            Graduated = hasGraduated;
            Balance = balancedOwed;
            TypeBadge = typeOfBadge;
            TakingClass = classTaking;
        }


        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime Birthday { get; set; }
        public bool Graduated { get; set; }
        public decimal Balance { get; set; }
        public BadgeType TypeBadge { get; set; }
        public CourseType TakingClass { get; set; }

    }
}
