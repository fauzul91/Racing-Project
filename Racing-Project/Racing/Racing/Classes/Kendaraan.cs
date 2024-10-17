using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Classes
{
    public abstract class Kendaraan
    {
        public string merk;
        public double kecepatan;

        public string Merk
        {
            get
            {
                return merk;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    merk = value;
                }
                else
                {
                    Console.WriteLine("Merk harus ada!!!");
                }
            }
        }

        public double Kecepatan
        {
            get
            { return kecepatan; }

            set
            {
                if (kecepatan > 0)
                {
                    kecepatan = value;
                }
                else
                {
                    Console.WriteLine("Kecepatan harus lebih dari 0");
                }
            }
        }

        public abstract void Drive();   
    }
}
