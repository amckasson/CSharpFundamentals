using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges
{
    public class UserClass
    {
        public UserClass(string firstName, string lastName, double id, DateTime birthDate)
        {
            FName = firstName;
            LName = lastName;
            Id = id;
            Birthday = birthDate;
          }
        public UserClass() { }

        public string FName { get; set; }
        public string LName { get; set; }
        public double Id { get; set; }
        public DateTime Birthday { get; set; }

        public string FullName
        {
            get
            {
                return $"{FName} {LName}";
            }
        }

        public int Age
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - Birthday;
                double totalAgeInYears = ageSpan.TotalDays / 365.25;
                int yearsOld = Convert.ToInt32(Math.Floor(totalAgeInYears));
                return yearsOld;
            }
        }
    }
}
