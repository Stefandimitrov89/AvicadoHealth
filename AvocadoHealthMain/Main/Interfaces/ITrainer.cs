using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Interfaces
{
    public interface ITrainer
    {
        void Eat(Food Food, double mass);

        void Train(Training training, double duration);

        //Трябва да се имплементира интерфейс на User
        void AddTrainee(Interfaces.IPerson trainee);

        void SetTraining(User user, Interfaces.ITrainings training);

        void CreateTraining(string trainginName, double caloriesSpendPerMinute, double proteinsSpendPerMinute, double fatsSpendPerMinute, double carboHydratesSpendPerMinute);

        void AllowUserToEat(User user, Interfaces.IFood food);

        void PrintMyTrainees();

        void ListMyOptions();

    }
}
