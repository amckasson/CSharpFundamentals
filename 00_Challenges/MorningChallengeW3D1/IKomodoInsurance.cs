using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges.MorningChallengeW3D1
{
    public interface IKomodoInsurance
    {
        bool IsRunning { get; }

        bool IsOff { get; }

        bool CanDrive { get; }

        string Make { get; }

        string Model { get; }

        string Color { get; }
    }
}
