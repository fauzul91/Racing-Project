using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Classes
{
    public interface IKendaraanBalap
    {
        public interface _IKendaraanBalap
        {
            void StartEngine();
            void StopEngine();
            void Accelerate();
            void Brake();
        }
    }
}

