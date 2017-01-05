using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class PowerTraining : Training
    {
        public PowerTraining(Person trainee, int time) : base(trainee, time)
        {
        }

        public override void Train(Person Trainee, int time)
        {
            throw new NotImplementedException();
        }
    }
}
