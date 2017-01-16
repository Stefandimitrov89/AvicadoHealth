using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class PowerTraining : Training
    {
        public PowerTraining(string trainginName, double caloriesSpendPerMinute, double proteinsSpendPerMinute, double fatsSpendPerMinute, double carboHydratesSpendPerMinute) : base(trainginName, caloriesSpendPerMinute, proteinsSpendPerMinute, fatsSpendPerMinute, carboHydratesSpendPerMinute)
        {
            this.TrainingName = trainginName;
            this.CaloriesUsedPerMinute = caloriesSpendPerMinute;
            this.ProteinsUsedPerMinute = proteinsSpendPerMinute;
            this.FatsUsedPerMinute = fatsSpendPerMinute;
            this.CarboHydratesUsedPerMinute = carboHydratesSpendPerMinute;
        }

        public double MuscleMassBuildingPerMinute { get { return CaloriesUsedPerMinute / 10; } private set { MassLostPerMinute = value; } }

        public override void Train(User trainee, double duration)
        {
            trainee._MuscleMass += (this.MuscleMassBuildingPerMinute * duration);
        }
    }
}
