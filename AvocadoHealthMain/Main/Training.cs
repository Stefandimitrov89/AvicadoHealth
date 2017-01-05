using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main.Interfaces;

namespace Main
{
    abstract class Training : ITrainings
    {
        readonly int _CaloriesPerMinute;
        public abstract void Train(Person Trainee, int time);

        public int CaloriesPerMinute { get; }

        public Training(Person trainee, int time)
        {

        }
    }
}
