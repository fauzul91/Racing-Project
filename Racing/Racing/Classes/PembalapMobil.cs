
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Classes
{
    public class PembalapMobil : Pembalap
    {
        public Mobil Mobil { get; set; }

        public override void Race()
        {
            if (!Mobil.IsFinished)
            {
                Console.WriteLine($"{Name} is racing with skill level {SkillLevel}");
                Mobil.Accelerate();
            }
        }
    }
}

