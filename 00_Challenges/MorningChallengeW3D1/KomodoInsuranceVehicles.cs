using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges.MorningChallengeW3D1
{
    public class Sedans : IKomodoInsurance
    {
        public bool IsRunning => true;
        public bool IsOff => false;
        public bool CanDrive => true;
        public string Make => "Cheverlette";
        public string Model => "Impala";
        public string Color => "grey";
    }

    public class SUV : IKomodoInsurance
    {
        public bool IsRunning => true;
        public bool IsOff => false;
        public bool CanDrive => true;
        public string Make => "Cheverlette";
        public string Model => "Suburban";
        public string Color => "black";
    }

    public class Motorcylce : IKomodoInsurance
    {
        public bool IsRunning => true;
        public bool IsOff => false;
        public bool CanDrive => true;
        public string Make => "Honda";
        public string Model => "Rebel CMX";
        public string Color => "black";
    }
}
