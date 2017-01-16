using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class CardioTraining : Training
    {
        public CardioTraining(string trainginName, double caloriesSpendPerMinute, double proteinsSpendPerMinute, double fatsSpendPerMinute, double carboHydratesSpendPerMinute) : base(trainginName, caloriesSpendPerMinute, proteinsSpendPerMinute, fatsSpendPerMinute, carboHydratesSpendPerMinute)
        {
            this.TrainingName = trainginName;
            this.CaloriesUsedPerMinute = caloriesSpendPerMinute;
            this.ProteinsUsedPerMinute = proteinsSpendPerMinute;
            this.FatsUsedPerMinute = fatsSpendPerMinute;
            this.CarboHydratesUsedPerMinute = carboHydratesSpendPerMinute;
        }

        public double MassLostPerMinute { get; private set; }

        public override void Train(User trainee, double duration)
        {
            trainee._Mass -= (this.MassLostPerMinute * duration);
        }
    }
}
