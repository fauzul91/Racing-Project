
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Classes
{
    public class Mobil : Kendaraan, IKendaraanBalap
    {
        public int LapCompleted { get; set; } = 0;
        public bool IsFinished { get; set; } = false;
        public double DistanceCovered { get; set; } = 0;

        public override void Drive()
        {
            Console.WriteLine($"{merk} is driving at {kecepatan} km/h");
        }

        public void StartEngine()
        {
            Console.WriteLine($"{merk} engine started");
        }

        public void StopEngine()
        {
            Console.WriteLine($"{merk} engine stopped");
        }

        public void Accelerate()
        {
            kecepatan += 20;
            Console.WriteLine($"{merk} accelerated to {kecepatan} km/h");
        }

        public void Brake()
        {
            kecepatan -= 20;
            Console.WriteLine($"{merk} braked to {kecepatan} km/h");
        }

        public void CompleteLap(double trackLength)
        {
            LapCompleted++;
            DistanceCovered = 0;
            Console.WriteLine($"{merk} completed lap {LapCompleted}");
            if (LapCompleted >= 2)
            {
                IsFinished = true;
                Console.WriteLine($"{merk} has finished the race!");
            }
        }

        public void UpdateDistance(double time)
        {
            DistanceCovered += kecepatan * time / 60;
            Console.WriteLine($"{merk} has covered {DistanceCovered:F2} km.");
        }
    }
}

