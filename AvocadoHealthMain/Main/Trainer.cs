using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Trainer :  Interfaces.IPerson
    {
        private List<Interfaces.IPerson> myTrainees = new List<Interfaces.IPerson>();

        // Създавам един лист с познатите на този треньор тренировки. Логично е всички тренировки, които той знае да са запазени някъде и той да може да "бърка там" и да ги назначава на User-и

        private List<Interfaces.ITrainings> myTrainings = new List<Interfaces.ITrainings>();

        public string FirstName { get; }
        public string LastName { get; }
        
        // Лист с user-ите, които тренират при този Trainer
        public List<Interfaces.IPerson> MyTrainees
        {
            get
            {
                return myTrainees;
            }
        }

        //Лист с тренировките, които този Trainer знае
        public List<Interfaces.ITrainings> MyTrainings
        {
            get
            {
                return myTrainings;
            }
        }

        public Trainer(string firstName, string lastName)
        {
        }

        public void Eat(Food Food, double mass)
        {
            throw new NotImplementedException();
        }

        public void Train(Training training, double duration)
        {
            throw new NotImplementedException();
        }

        // Трябва да се направи интерфейс за User
        // Добавяне на User към списъка с User-ите трениращи при този Trainer
        public void AddTrainee(Interfaces.IPerson trainee)
        {
            this.myTrainees.Add(trainee);
        }

        //Даден Trainer задава тренировка на даден User от листа му.
        public void SetTraining(User user, Interfaces.ITrainings training)
        {
            user.SetTraining(training);
        }

        //Създаване на тренировка от Trainer
        public void CreateTraining(string trainginName, double caloriesSpendPerMinute, double proteinsSpendPerMinute, double fatsSpendPerMinute, double carboHydratesSpendPerMinute)
        {
            Interfaces.ITrainings training = new Training(trainginName, caloriesSpendPerMinute, proteinsSpendPerMinute, fatsSpendPerMinute, carboHydratesSpendPerMinute);

            this.AddTrainingToMyList(training);

        }

        // Вътрешен метод да прибавя тренировка към познатите му тренировки
        private void AddTrainingToMyList(Interfaces.ITrainings training)
        {
            this.myTrainings.Add(training);
        }

        // Задава позволени храни на дадена истанция на User
        public void AllowUserToEat(User user, Interfaces.IFoods food)
        {
            user._RecomendedFood.Add(food);

            // Това е само идея. Като правим действия да принтираме потвърждение - Мартин
            Console.WriteLine($"You allowed {user._FirstName} {user._LastName} to eat {nameof(food)}");
        }

        // Листва всички юзери, които тренират при него
        public void PrintMyTrainees()
        {
            foreach (var item in myTrainees)
            {
                var trainee = item as Person;
                Console.WriteLine($"{trainee._FirstName} {trainee._LastName}, {nameof(trainee)}");
            }
        }

        // Листва си възможните действия
        public void ListMyOptions()
        {
            var list = typeof(Trainer).GetMethods();

            foreach (var item in list)
            {
                Console.WriteLine($"{item.Name}");
            }
        }




    }
}
