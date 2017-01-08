using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class CardioTraining : Training
    {
        public double MassLostPerMinute { get; private set; }

        public override void Train(User trainee, double duration)
        {
            trainee._Mass -= (this.MassLostPerMinute * duration);
        }
    }
}
