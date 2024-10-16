using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Classes
{
    public class Match
    {
        public List<PembalapMobil> PembalapMobilList { get; set; }
        public Track Track { get; set; }
        private double TrackLength = 5.0; // Panjang lintasan dalam kilometer
        private double LapTime = 1; // Simulasi waktu dalam menit per iterasi

        public Match(List<PembalapMobil> pembalapMobilList, Track track)
        {
            if (pembalapMobilList.Count < 5)
            {
                throw new ArgumentException("A race must have at least 5 participants.");
            }

            PembalapMobilList = pembalapMobilList;
            Track = track;
        }

        public void StartMatch()
        {
            Console.WriteLine("The match is starting...");
            Track.StartRace();

            bool raceOngoing = true;
            while (raceOngoing)
            {
                // Update jarak untuk setiap mobil
                foreach (var pembalap in PembalapMobilList)
                {
                    if (!pembalap.Mobil.IsFinished)
                    {
                        pembalap.Mobil.UpdateDistance(LapTime);
                        if (pembalap.Mobil.DistanceCovered >= TrackLength)
                        {
                            pembalap.Mobil.CompleteLap(TrackLength);
                        }
                    }
                }

                // Cek apakah ada mobil yang menyalip
                CheckForOvertake();

                // Periksa apakah semua mobil sudah selesai balapan
                if (PembalapMobilList.All(p => p.Mobil.IsFinished))
                {
                    raceOngoing = false;
                    Console.WriteLine("All cars have finished the race!");
                }

                // Istirahat sejenak untuk simulasi putaran
                System.Threading.Thread.Sleep(1000);
            }
        }

        // Fungsi untuk memeriksa apakah ada mobil yang menyalip
        private void CheckForOvertake()
        {
            // Urutkan mobil berdasarkan lap dan jarak yang ditempuh
            PembalapMobilList = PembalapMobilList.OrderByDescending(p => p.Mobil.LapCompleted)
                                                  .ThenByDescending(p => p.Mobil.DistanceCovered)
                                                  .ToList();

            for (int i = 0; i < PembalapMobilList.Count - 1; i++)
            {
                var pembalap = PembalapMobilList[i];
                var pembalapBelakang = PembalapMobilList[i + 1];

                // Cek apakah pembalap belakang lebih cepat dan menyalip
                if (pembalap.Mobil.LapCompleted == pembalapBelakang.Mobil.LapCompleted &&
                    pembalap.Mobil.DistanceCovered < pembalapBelakang.Mobil.DistanceCovered)
                {
                    Console.WriteLine($"{pembalapBelakang.Name} in {pembalapBelakang.Mobil.merk} overtook {pembalap.Name} in {pembalap.Mobil.merk}!");
                }
            }
        }
    }

}
