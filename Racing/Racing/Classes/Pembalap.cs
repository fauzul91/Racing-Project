using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Classes
{
    public abstract class Pembalap
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }

        public abstract void Race();
    }
}
