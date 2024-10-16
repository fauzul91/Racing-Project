using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Classes
{
    public class Track
    {
        private string trackName;
        private double trackDifficulty;

        public string TrackName
        {
            get { return trackName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    trackName = value;
                }
                else
                {
                    Console.WriteLine("Nama Track harus terisi");
                }
            }
        }

        public double TrackDifficulty
        {
            get { return trackDifficulty; }
            set
            {
                if (value > 0 && value <= 5)
                {
                    trackDifficulty = value;
                }
                else
                {
                    Console.WriteLine("Difficulty harus bernilai di antara 1 sampai 5");
                }
            }
        }

        public Track(string trackName, double trackDifficulty)
        {
            TrackName = trackName;
            TrackDifficulty = trackDifficulty;
        }

        public void StartRace()
        {
            Console.WriteLine($"Race on {TrackName} track has started. Difficulty: {TrackDifficulty}");
        }
    }
}
