﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main.Interfaces;

namespace Main
{
    public class User :  Person, IPerson
    {
        
        public string _Gender { get; private set; }
        public Trainer Trainer { get; set; }
        public double _Mass { get; set; }
        public double _MuscleMass { get; set; }
        public List<Training> _TrainingsList { get; set; }
        //Тук промених да очаква интерфейса за храна, а не конректен клас храна - Мартин
        public List<IFood> _RecomendedFood { get; set; } 
        public double _Calories { get; set; }
        public double _CarboHydrates { get; set; }
        public double _Fats { get; set; }
        public double _Proteins { get; set; }
        // Липсват списъци за история какво е ял, какво е тренирал и тн. - Мартин



        public User(string firstName, string lastName, string gender) : base(firstName, lastName)
        {
            this._Gender = gender;
            this._FirstName = firstName;
            this._LastName = lastName;
            
        }


        public void Eat(IFood Food, double mass)
        {
            this._Calories += (Food.Calories * mass);
            this._Fats += (Food.Fats * mass);
            this._Proteins += (Food.Proteins * mass);
        }

        // Смених тук да иска интерфейса, а не конкретен клас - Мартин
        internal void CreateTraining(Interfaces.ITrainings training)
        {
            throw new NotImplementedException();
        }

        public void Train(Training training, double duration)
        {
            training.Train(this, duration);
        }

        public void printUserInfo()
        {
            Console.WriteLine($"{this._FirstName} {this._LastName} is {this._Gender}. He has {this._Mass} mass index and {this._MuscleMass} muscle mass");
        }
        // Svetlomir added this Method because it is needed for TrainerUI
        public void printTrainingList()
        {
            for (int i = 0; i < this._TrainingsList.Count; i++)
            {
                Console.WriteLine($"{this._TrainingsList[i].TrainingName}, it uses {this._TrainingsList[i].ProteinsUsedPerMinute} and takes {this._TrainingsList[i].CaloriesUsedPerMinute} call/min");
            }
        }
    }
}
