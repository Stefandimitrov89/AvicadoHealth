using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main.Interfaces;

namespace Main
{
    public abstract class Training : ITrainings
    {
        public string TrainingName { get; private set; }

        public double CaloriesUsedPerMinute { get; private set; }
        public double ProteinsUsedPerMinute { get; private set; }
        public double FatsUsedPerMinute { get; private set; }
        public double CarboHydratesUsedPerMinute {get; private set; }

        public virtual void Train(User trainee, double duration) //unsure about this, not sure if the derived method will hide this implementation. WIll check it soon, Stefan
        {
            trainee._Calories -= (this.CaloriesUsedPerMinute * duration);
            trainee._Proteins -= (this.ProteinsUsedPerMinute * duration);
            trainee._Fats -= (this.FatsUsedPerMinute * duration);
            trainee._CarboHydrates -= (this.CaloriesUsedPerMinute * duration);
        }
    }
}
