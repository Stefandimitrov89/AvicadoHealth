using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main.Interfaces;

namespace Main
{
    public class User : Person, IPerson
    {
        public string _Gender { get; private set; }
        public Trainer Trainer { get; set; }
        public double _Mass { get; set; }
        public double _MuscleMass { get; set; }
        public List<Training> _TrainingsList { get; set; }
        public List<Food> _RecomendedFood { get; set; }
        public double _Calories { get; set; }
        public double _CarboHydrates { get; set; }
        public double _Fats { get; set; }
        public double _Proteins { get; set; }




        public User(string firstName, string lastName, string gender) : base(firstName, lastName)
        {
            this._Gender = gender;
        }


        public override void Eat(Food Food, double mass)
        {
            this._Calories += (Food.Calories * mass);
            this._Fats += (Food.Fats * mass);
            this._Proteins += (Food.Proteins * mass);
        }

        public override void Train(Training training, double duration)
        {
            training.Train(this, duration);
        }
    }
}
