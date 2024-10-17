
using Racing.Classes;
using System.Runtime.InteropServices;

namespace Racing
{
    public class Program
    {
        static void Main(string[] args)
        {
            Mobil mobil1 = new Mobil() { merk = "Ferrari", kecepatan = 120 };
            PembalapMobil pembalap1 = new PembalapMobil() { Name = "Lewis Hamilton", SkillLevel = 95, Mobil = mobil1 };

            Mobil mobil2 = new Mobil() { merk = "McLaren", kecepatan = 115 };
            PembalapMobil pembalap2 = new PembalapMobil() { Name = "Max Verstappen", SkillLevel = 90, Mobil = mobil2 };

            Mobil mobil3 = new Mobil() { merk = "Red Bull", kecepatan = 110 };
            PembalapMobil pembalap3 = new PembalapMobil() { Name = "Sebastian Vettel", SkillLevel = 85, Mobil = mobil3 };

            Mobil mobil4 = new Mobil() { merk = "Mercedes", kecepatan = 125 };
            PembalapMobil pembalap4 = new PembalapMobil() { Name = "Nico Rosberg", SkillLevel = 88, Mobil = mobil4 };

            Mobil mobil5 = new Mobil() { merk = "Porsche", kecepatan = 130 };
            PembalapMobil pembalap5 = new PembalapMobil() { Name = "Charles Leclerc", SkillLevel = 93, Mobil = mobil5 };

            Track track1 = new Track("Monaco", 5);

            List<PembalapMobil> pembalapList = new List<PembalapMobil> { pembalap1, pembalap2, pembalap3, pembalap4, pembalap5 };
            Match match = new Match(pembalapList, track1);
            match.StartMatch();
        }
    }
}

