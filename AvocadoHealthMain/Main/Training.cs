using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main.Interfaces;

namespace Main
{
    public class Training : ITrainings
    {
        public string TrainingName { get; private set; }

        // Тези дали да не са int-ове. Не изпадаме ли в излишен детайл да са double-и? - Мартин

        public double CaloriesUsedPerMinute { get; private set; }
        public double ProteinsUsedPerMinute { get; private set; }
        public double FatsUsedPerMinute { get; private set; }
        public double CarboHydratesUsedPerMinute {get; private set; }

        // Правя един конструктор, за да мога да инстанцирам тренировка с Trainer - Мартин

        public Training(string trainginName, double caloriesSpendPerMinute, double proteinsSpendPerMinute, double fatsSpendPerMinute, double carboHydratesSpendPerMinute)
        {
            this.TrainingName = trainginName;
            this.CaloriesUsedPerMinute = caloriesSpendPerMinute;
            this.ProteinsUsedPerMinute = proteinsSpendPerMinute;
            this.FatsUsedPerMinute = fatsSpendPerMinute;
            this.CarboHydratesUsedPerMinute = carboHydratesSpendPerMinute;
        }


        // Това не трябва ли да де метод на User??? Няма логика тренировката да може да тренира - Мартин
        public virtual void Train(User trainee, double duration) //unsure about this, not sure if the derived method will hide this implementation. WIll check it soon, Stefan
        {
            trainee._Calories -= (this.CaloriesUsedPerMinute * duration);
            trainee._Proteins -= (this.ProteinsUsedPerMinute * duration);
            trainee._Fats -= (this.FatsUsedPerMinute * duration);
            trainee._CarboHydrates -= (this.CaloriesUsedPerMinute * duration);
        }
    }
}
