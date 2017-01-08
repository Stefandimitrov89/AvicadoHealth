using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class PowerTraining : Training
    {
        public double MuscleMassBuildingPerMinute { get; private set; }

        public override void Train(User trainee, double duration)
        {
            trainee._MuscleMass += (this.MuscleMassBuildingPerMinute * duration);
        }
    }
}
